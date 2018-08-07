// <copyright file="CoachScheduleForm.cs" company="Adam J. Smith at NWTC">
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
    /// Definition of the <see cref="CoachScheduleForm"/> class.
    /// </summary>
    public partial class CoachScheduleForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoachScheduleForm"/> class.
        /// </summary>
        public CoachScheduleForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Displays the list of available coaches
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CoachScheduleFormLoad(object sender, EventArgs e)
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
        private void PopulateScheduleGrid()
        {
            // Query obtains the coach ID from the combo box.
            string coachId = this.cbxChooseCoach.SelectedValue.ToString();

            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var coachScheduleQuery = from coachSchedules in context.GetCoachSchedules
                                                 where coachSchedules.CoachID.Equals(coachId)
                                                 select coachSchedules;

                    this.dataGridViewSchedule.DataSource = coachScheduleQuery.ToList();

                    // ReSharper disable once PossibleNullReferenceException
                    this.dataGridViewSchedule.Columns["SessionID"].Visible = false;
                    this.dataGridViewSchedule.Columns["CoachID"].Visible = false;
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
        /// A method to update data in the coach schedule data grid when a new coach is selected
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CbxChooseCoach_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateScheduleGrid();
        }

        /// <summary>
        /// A method to add a new schedule record to the database when the button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnAddToSchedule_Click(object sender, EventArgs e)
        {
            EditSession editCoachSession = new EditSession(this.cbxChooseCoach.SelectedValue.ToString());
            editCoachSession.ShowDialog();

            this.PopulateScheduleGrid();
        }

        /// <summary>
        /// A method to open a schedule record when it is double-clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void DataGridViewSchedule_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the SessionID for the selected row
            int selectedScheduleId = Convert.ToInt32(this.dataGridViewSchedule.SelectedRows[0].Cells["SessionID"].Value.ToString());

            EditSession editCoachAvailability = new EditSession(selectedScheduleId);
            editCoachAvailability.ShowDialog();

            this.PopulateScheduleGrid();
        }

        /// <summary>
        /// A method to remove the selected schedule record when the button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            // Determine which row is selected
            int selectedSessionId = Convert.ToInt32(this.dataGridViewSchedule.SelectedRows[0].Cells["SessionID"].Value.ToString());

            // Confirm whether user truly wants to remove this scheduled block
            DialogResult confirmRemove = MessageBox.Show(
                @"Are you sure you want to remove this scheduled time?",
                @"Confirm delete",                                                     
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // If yes, remove the record
            if (confirmRemove.Equals(DialogResult.Yes))
            {
                var session = new CoachSession { SessionID = selectedSessionId };

                try
                {
                    using (var context = new db_sft_2172Entities())
                    {
                        context.CoachSessions.Attach(session);
                        context.CoachSessions.Remove(session);
                        context.SaveChanges();

                        MessageBox.Show(@"Delete successful!");

                        this.PopulateScheduleGrid();
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
