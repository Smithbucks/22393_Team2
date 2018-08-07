// <copyright file="MainForm.cs" company="Adam J. Smith at NWTC">
//     Copyright 2018 Smithbucks Computing (Adam J. Smith, radarsmith83@gmail.com)
// </copyright>
namespace CoachConnect
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Declaration for the <see cref="MainForm"/> class.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
            this.Show();

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        /// <summary>
        /// A method to display the CoachProfileForm when the appropriate menu item is selected
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void ProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoachProfileForm coachForm = new CoachProfileForm { MdiParent = this };
            coachForm.Show();
        }

        /// <summary>
        /// A method to display the UserProfileForm when the appropriate menu item is selected
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void AddUpdateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProfileForm userForm = new UserProfileForm { MdiParent = this };
            userForm.Show();
        }

        /// <summary>
        /// A method to exit the program when the appropriate menu item is selected
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                @"Are you sure you want to exit?",
                @"Confirm exit", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// A method to display the CoachAvailabilityForm when the appropriate menu item is selected
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void SetAvailabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoachAvailabilityForm coachAvailabilityForm = new CoachAvailabilityForm { MdiParent = this };
            coachAvailabilityForm.Show();
        }

        /// <summary>
        /// A method to display the ResetMyPassword form when the appropriate menu item is selected
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void ChangeMyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetMyPassword passwordResetForm = new ResetMyPassword { MdiParent = this };
            passwordResetForm.Show();
        }

        /// <summary>
        /// A method to display the CoachScheduleForm when the appropriate menu item is selected
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void SetScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoachScheduleForm coachScheduleForm = new CoachScheduleForm { MdiParent = this };
            coachScheduleForm.Show();
        }

        /// <summary>
        /// A method to display the PrintSchedule form when the appropriate menu item is selected
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void PrintScheduleByDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintSchedule printScheduleForm = new PrintSchedule { MdiParent = this };
            printScheduleForm.Show();
        }

        /// <summary>
        /// A method to display the CourseAdminForm when the appropriate menu item is selected
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void UpdateCourseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseAdminForm courseAdminForm = new CourseAdminForm { MdiParent = this };
            courseAdminForm.Show();
        }
    }
}
