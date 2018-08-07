// <copyright file="CoachAvailabilityForm.cs" company="Adam J. Smith at NWTC">
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
    /// Initializes a new instance of the <see cref="CoachAvailabilityForm"/> class.
    /// </summary>
    public partial class CoachAvailabilityForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoachAvailabilityForm"/> class.
        /// </summary>
        public CoachAvailabilityForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Maximizes Form and displays the users with load event of the form.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CoachAvailabilityFormLoad(object sender, EventArgs e)
        {
            this.DisplayCoaches();
            this.cbxChooseCoach.SelectedIndex = 0;
        }

        /// <summary>
        /// Method to display the list of coaches
        /// </summary>
        private void DisplayCoaches()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Query coach table in database and returns the list of the users in ascending order according to last name
                    var coachQuery = from coaches in context.Coaches
                        orderby coaches.LastName ascending
                        select coaches;

                    // Convert query results to list
                    List<Coach> coachList = coachQuery.ToList();

                    // Set combo box data sources and update data member settings
                    this.cbxChooseCoach.DataSource = coachList;
                    this.cbxChooseCoach.ValueMember = "CoachID";
                    this.cbxChooseCoach.DisplayMember = "DisplayName";
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
        /// A method to populate data in the coach availability data grid
        /// </summary>
        private void PopulateAvailabilityGrid()
        {
            // Query obtains the coach ID from the combo box.
            string coachId = this.cbxChooseCoach.SelectedValue.ToString();

            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var coachAvailabilityQuery = from coachAvailability in context.GetCoachAvailabilities
                                                 where coachAvailability.CoachID.Equals(coachId)
                                                 select coachAvailability;

                    this.dataGridViewAvailability.DataSource = coachAvailabilityQuery.ToList();
                    this.dataGridViewAvailability.Columns["CoachID"].Visible = false;
                    this.dataGridViewAvailability.Columns["CoachAvailabilityID"].Visible = false;
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
        /// Maximizes Form and displays the users with load event of the form.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CbxChooseCoach_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateAvailabilityGrid();
        }

        /// <summary>
        /// Event handler to open the EditCoachAvailability form when the button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnAddToCourseList_Click(object sender, EventArgs e)
        {
            EditCoachAvailability editCoachAvailability = new EditCoachAvailability(this.cbxChooseCoach.SelectedValue.ToString());
            editCoachAvailability.ShowDialog();

            this.PopulateAvailabilityGrid();
        }

        /// <summary>
        /// Event handler to open the selected Availability record when double-clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void DataGridViewAvailability_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the AvailabilityID for the selected row
            int selectedAvailabilityId = Convert.ToInt32(this.dataGridViewAvailability.SelectedRows[0].Cells["CoachAvailabilityID"].Value.ToString());

            EditCoachAvailability editCoachAvailability = new EditCoachAvailability(selectedAvailabilityId);
            editCoachAvailability.ShowDialog();

            this.PopulateAvailabilityGrid();
        }

        /// <summary>
        /// Event handler to delete the selected Availability record when the Remove button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            // Determine which row is selected
            int selectedAvailabilityId = Convert.ToInt32(this.dataGridViewAvailability.SelectedRows[0].Cells["CoachAvailabilityID"].Value.ToString());

            // Confirm whether user truly wants to remove this availability record
            DialogResult confirmRemove = MessageBox.Show(
                @"Are you sure you want to remove this record?", 
                @"Confirm delete",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            // If yes, remove the record
            if (confirmRemove.Equals(DialogResult.Yes))
            {
                var availability = new CoachAvailability { CoachAvailabilityID = selectedAvailabilityId };

                try
                {
                    using (var context = new db_sft_2172Entities())
                    {
                        context.CoachAvailabilities.Attach(availability);
                        context.CoachAvailabilities.Remove(availability);
                        context.SaveChanges();

                        MessageBox.Show(@"Delete successful!");

                        this.PopulateAvailabilityGrid();
                    }
                }
                catch (DbUpdateException dbUEx)
                {
                    MessageBox.Show(dbUEx.InnerException != null ? dbUEx.InnerException.Message : dbUEx.Message);
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
        }
    }
}
