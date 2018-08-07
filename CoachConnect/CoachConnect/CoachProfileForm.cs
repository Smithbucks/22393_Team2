// <copyright file="CoachProfileForm.cs" company="Adam J. Smith at NWTC">
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
    /// Definition of the <see cref="CoachProfileForm"/> class.
    /// </summary>
    public partial class CoachProfileForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoachProfileForm"/> class.
        /// </summary>
        public CoachProfileForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Maximizes Form and displays the users with load event of the form.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CoachAdminFormLoad(object sender, EventArgs e)
        {
            this.DisplaySupervisors();
            this.DisplayCoaches();
        }

        /// <summary>
        /// Method to display the list of users
        /// </summary>
        private void DisplayCoaches()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Query coach table in database and returns the list of the users in ascending order according to last name
                    var coachQuery = from coaches in context.Coaches
                        orderby coaches.LastName
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
        /// Method to display the list of supervisors in a combo box
        /// </summary>
        private void DisplaySupervisors()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Query user table in database and return the list of supervisors in ascending order according to last name
                    var supervisorQuery = from users in context.Users
                        where users.IsSupervisor
                        orderby users.LastName
                        select users;

                    List<User> supervisorList = supervisorQuery.ToList();

                    // Set combo box data source and update data member listings
                    this.cbxSupervisor.DataSource = supervisorList;
                    this.cbxSupervisor.ValueMember = "UserID";
                    this.cbxSupervisor.DisplayMember = "DisplayName";
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
        /// Clear all data fields
        /// </summary>
        private void ClearAllFields()
        {
            // Clearing check boxes and text boxes.
            this.txtID.Clear();
            this.txtFirstName.Clear();
            this.txtLastName.Clear();
            this.txtMiddleName.Clear();
            this.txtDisplayName.Clear();
            this.txtEmail.Clear();
            this.txtPhone.Clear();
            this.cbxSupervisor.SelectedValue = -1;
            this.chkActive.Checked = false;
        }

        /// <summary>
        /// Populates the combo boxes and text boxes with the selected coach's information.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CbxChooseCoach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbxChooseCoach.SelectedIndex == -1)
            {
                return;
            }

            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Query is getting the coach ID from the combo box.
                    string coachId = this.cbxChooseCoach.SelectedValue.ToString();

                    // Find the coach in the database.
                    var coachQuery = from coach in context.Coaches
                                     where coach.CoachID.Equals(coachId)
                                     select coach;

                    // If the query returns a a user, display the corresponding info in the form
                    if (coachQuery.Any())
                    {
                        var coachResult = coachQuery.FirstOrDefault();

                        if (coachResult != null)
                        {
                            this.txtID.Text = coachResult.CoachID;
                            this.txtFirstName.Text = coachResult.FirstName;
                            this.txtLastName.Text = coachResult.LastName;
                            this.txtMiddleName.Text = coachResult.MiddleName;
                            this.txtDisplayName.Text = coachResult.DisplayName;
                            this.txtEmail.Text = coachResult.Email;
                            this.txtPhone.Text = coachResult.Phone;
                            this.cbxSupervisor.SelectedValue = coachResult.SupervisorID;
                            this.chkActive.Checked = coachResult.IsActive;
                        }
                    }
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
        /// Add button clears all text boxes and check boxes so user can enter new information.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnAddClick(object sender, EventArgs e)
        {
            this.ClearAllFields();
        }

        /// <summary>
        /// Submit button sends the added or updated info to the database.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnSubmitClick(object sender, EventArgs e)
        {
            try
            {
                // Query updates the user in the database
                using (var context = new db_sft_2172Entities())
                {
                    string coachId = this.txtID.Text;
                    var coachQuery = from coach in context.Coaches
                                     where coach.CoachID.Equals(coachId)
                                     select coach;

                    if (coachQuery.Any())
                    {
                        var coachResult = coachQuery.FirstOrDefault();
                        coachResult.FirstName = this.txtFirstName.Text;
                        coachResult.MiddleName = this.txtMiddleName.Text;
                        coachResult.LastName = this.txtLastName.Text;
                        coachResult.DisplayName = this.txtDisplayName.Text;
                        coachResult.Phone = this.txtPhone.Text;
                        coachResult.Email = this.txtEmail.Text;
                        coachResult.IsActive = this.chkActive.Checked;

                        coachResult.SupervisorID = this.cbxSupervisor.SelectedIndex == -1 ? string.Empty : this.cbxSupervisor.SelectedValue.ToString();

                        context.SaveChanges();
                        MessageBox.Show(@"Coach Profile Updated");
                    }
                    else
                    {
                        Coach newCoach = new Coach
                        {
                            CoachID = this.txtID.Text,
                            FirstName = this.txtFirstName.Text,
                            MiddleName = this.txtMiddleName.Text,
                            LastName = this.txtLastName.Text,
                            DisplayName = this.txtDisplayName.Text,
                            Phone = this.txtPhone.Text,
                            Email = this.txtEmail.Text,
                            IsActive = this.chkActive.Checked,
                            SupervisorID =
                                this.cbxSupervisor.SelectedIndex == -1 ? string.Empty : this.cbxSupervisor.SelectedValue.ToString()
                        };

                        context.Coaches.Add(newCoach);
                        context.SaveChanges();

                        MessageBox.Show(@"Coach Profile Added");

                        // If save is successful, update the coach list and display the new coach profile
                        this.DisplayCoaches();
                        this.cbxChooseCoach.SelectedValue = newCoach.CoachID;
                    }
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

        /// <summary>
        /// Close button closes the current window.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}