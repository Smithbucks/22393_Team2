// <copyright file="EditCoachAvailability.cs" company="Adam J. Smith at NWTC">
//     Copyright 2018 Smithbucks Computing (Adam J. Smith, radarsmith83@gmail.com)
// </copyright>
namespace CoachConnect
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// EditSession: A form which allows users to create and edit session data, then save the data to the database.
    /// </summary>
    public partial class EditCoachAvailability : Form
    {
        /// <summary>
        /// Validator: An object to handle data form validation
        /// </summary>
        private readonly Validation validator = new Validation();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditCoachAvailability" /> class.
        /// In this version a coachID is provided to create a new session
        /// </summary>
        /// <param name="coachId">The Coach ID to be updated.</param>
        public EditCoachAvailability(string coachId)
        {
            try
            {
                this.InitializeComponent();

                this.CurrentAvailability = new CoachAvailability
                {
                    CoachID = coachId
                };

                // Set session ID to a negative value (indicates a new session)
                this.CoachAvailabilityId = -1;

                // Update header text to show "Add" instead of "Edit"
                this.lblEditSessionHeader.Text = @"Add Coach Availability";

                // Call method to populate combo boxes
                this.PopulateComboBoxes();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditCoachAvailability" /> class.
        /// A sessionID is provided to show which session should be updated
        /// </summary>
        /// <param name="coachAvailabilityId">The ID for the session to be updated</param>
        public EditCoachAvailability(int coachAvailabilityId)
        {
            try
            {
                this.CoachAvailabilityId = coachAvailabilityId;

                this.InitializeComponent();

                // Call method to populate combo boxes
                this.PopulateComboBoxes();

                // Call method to pull current availability data from the database
                this.LoadSessionData();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Gets the coach availability record to be edited
        /// </summary>
        private int CoachAvailabilityId { get; }

        /// <summary>
        /// Gets or sets an object to hold the current session data
        /// </summary>
        private CoachAvailability CurrentAvailability { get; set; }

        /// <summary>
        /// Event handler to save session data and close form when the Save button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnSaveClick(object sender, EventArgs e)
        {
            // Get data from form and insert into current Availability object
            this.CurrentAvailability.DayID = this.cbxDay.SelectedValue.ToString();

            // Get selected start time as a TimeSpan
            Time selectedStartTime = (Time)this.cbxStartTime.SelectedItem;
            this.CurrentAvailability.StartTime = selectedStartTime.Time1;

            // Get selected end time as a TimeSpan
            Time selectedEndTime = (Time)this.cbxEndTime.SelectedItem;
            this.CurrentAvailability.EndTime = selectedEndTime.Time1;
            
            // If end time is earlier or the same as the start time, display an error message, then cancel the save action. 
            if (TimeSpan.Compare(this.CurrentAvailability.StartTime, this.CurrentAvailability.EndTime) >= 0)
            {
                MessageBox.Show(@"Error: Start time must be earlier than the end time.");
                return;
            }

            // Verify that the current availablility block does not overlap another block on the same day
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var sameDayCoachAvailability = from coachAvailability in context.CoachAvailabilities
                                                   where
                                                       coachAvailability.CoachID.Equals(this.CurrentAvailability.CoachID)
                                                       && coachAvailability.DayID.Equals(this.CurrentAvailability.DayID)
                                                       && !coachAvailability.CoachAvailabilityID.Equals(this.CurrentAvailability.CoachAvailabilityID)
                                                   select coachAvailability;

                    if (sameDayCoachAvailability.Any())
                    {
                        var overlappingCoachAvailability = from overlapping in sameDayCoachAvailability
                                                           where (!(this.CurrentAvailability.StartTime < overlapping.StartTime && this.CurrentAvailability.EndTime <= overlapping.StartTime) &&
                                                                  !(this.CurrentAvailability.StartTime >= overlapping.EndTime && this.CurrentAvailability.EndTime > overlapping.EndTime))
                                                           select overlapping;

                        if (overlappingCoachAvailability.Any())
                        {
                            MessageBox.Show(
                            @"Sorry, the desired coach is already available for part or all of this time block.\nPlease select another combination or modify an existing block!");
                            return;
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // Call appropriate method to add or update session data
            if (this.CoachAvailabilityId == -1)
            {
                this.AddNewAvailability();
            }
            else
            {
                this.UpdateAvailability();
            }
                
            // Close form once finished
            this.Close();   
        }

        /// <summary>
        /// Event handler to close the current form when the Cancel button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method to query the database and populate the combo boxes with valid items
        /// </summary>
        private void PopulateComboBoxes()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Run queries to get combo box data
                    var dayQuery = from days in context.Days
                                   orderby days.SortOrder
                                   select days;

                    var timeQuery = from times in context.Times
                                    orderby times.Time1
                                    select times;

                    // Convert query results to lists
                    List<Day> dayList = dayQuery.ToList();
                    List<Time> startTimeList = timeQuery.ToList();
                    List<Time> endTimeList = timeQuery.ToList();

                    // Set combo box data sources and update data member settings
                    this.cbxDay.DataSource = dayList;
                    this.cbxDay.ValueMember = "DayID";
                    this.cbxDay.DisplayMember = "DayID";

                    this.cbxStartTime.DataSource = startTimeList;
                    this.cbxStartTime.ValueMember = "Time1";
                    this.cbxStartTime.DisplayMember = "TimeName";

                    this.cbxEndTime.DataSource = endTimeList;
                    this.cbxEndTime.ValueMember = "Time1";
                    this.cbxEndTime.DisplayMember = "TimeName";

                    this.cbxDay.SelectedIndex = -1;
                    this.cbxStartTime.SelectedIndex = -1;
                    this.cbxEndTime.SelectedIndex = -1;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Method to query the database and display data for the desired availability block
        /// </summary>
        private void LoadSessionData()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var availabilityQuery = from availability in context.CoachAvailabilities
                                       where availability.CoachAvailabilityID.Equals(this.CoachAvailabilityId)
                                       select availability;

                    if (availabilityQuery.Any())
                    {
                        this.CurrentAvailability = availabilityQuery.FirstOrDefault();
                    }
                    else
                    {
                        MessageBox.Show(@"Sorry, could not load availability data from the database.  Please try again later.");
                        return;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // Populate combo boxes with current session data
            if (this.CurrentAvailability != null)
            {
                this.cbxDay.SelectedValue = this.CurrentAvailability.DayID;
                this.cbxStartTime.SelectedValue = this.CurrentAvailability.StartTime;
                this.cbxEndTime.SelectedValue = this.CurrentAvailability.EndTime;
            }
        }

        /// <summary>
        /// Method to create a new session in the database
        /// </summary>
        private void AddNewAvailability()
        {
            // Add new user to the database and save changes
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Run query and save new user data to database
                    context.CoachAvailabilities.Add(this.CurrentAvailability);
                    context.SaveChanges();
                }
            }
            catch (DbUpdateException dbUEx)
            {
                MessageBox.Show(dbUEx.InnerException != null ? dbUEx.InnerException.Message : dbUEx.Message);
                return;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show(@"Save completed...new session created successfully!");
        }

        /// <summary>
        /// Method to update an existing session in the database
        /// </summary>
        private void UpdateAvailability()
        {
            // Add new user to the database and save changes
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Run query and pull matching session from database
                    var availabilityQuery = from availability in context.CoachAvailabilities
                                       where availability.CoachAvailabilityID.Equals(this.CoachAvailabilityId)
                                       select availability;

                    if (availabilityQuery.Any())
                    {
                        CoachAvailability foundAvailability = availabilityQuery.FirstOrDefault();

                        // Update database records
                        if (foundAvailability != null)
                        {
                            foundAvailability.CoachID = this.CurrentAvailability.CoachID;
                            foundAvailability.DayID = this.CurrentAvailability.DayID;
                            foundAvailability.StartTime = this.CurrentAvailability.StartTime;
                            foundAvailability.EndTime = this.CurrentAvailability.EndTime;
                        }

                        // Save changes to database
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show(
                            @"Sorry, a matching session was not found in the database.\nPlease try again or contact an administrator for assistance.");
                    }
                }
            }
            catch (DbUpdateException dbUEx)
            {
                MessageBox.Show(dbUEx.InnerException != null ? dbUEx.InnerException.Message : dbUEx.Message);
                return;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show(@"Save completed...Session updated successfully!");
        }

        /// <summary>
        /// Event handler to validate Day combo box when it loses focus
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CbxDay_Leave(object sender, EventArgs e)
        {
            this.lblInvalidDay.Visible = !this.validator.ValidateComboBox(this.cbxDay.SelectedIndex);

            if (this.lblInvalidDay.Visible)
            {
                this.cbxDay.Focus();
            }
        }

        /// <summary>
        /// Event handler to validate Start Time combo box when it loses focus
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CbxStartTime_Leave(object sender, EventArgs e)
        {
            this.lblInvalidStartTime.Visible = !this.validator.ValidateComboBox(this.cbxStartTime.SelectedIndex);

            if (this.lblInvalidStartTime.Visible)
            {
                this.cbxStartTime.Focus();
            }
        }

        /// <summary>
        /// Event handler to validate End Time combo box when it loses focus
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CbxEndTime_Leave(object sender, EventArgs e)
        {
            this.lblInvalidEndTime.Visible = !this.validator.ValidateComboBox(this.cbxEndTime.SelectedIndex);

            if (this.lblInvalidEndTime.Visible)
            {
                this.cbxEndTime.Focus();
            }
        }
    }
}
