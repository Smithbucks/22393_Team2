﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoachConnect
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Show();

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoachProfileForm coachForm = new CoachProfileForm();
            coachForm.MdiParent = this;
            coachForm.Show();
        }

        private void addUpdateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProfileForm userForm = new UserProfileForm();
            userForm.MdiParent = this;
            userForm.Show();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?",
                "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void setAvailabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoachAvailabilityForm coachAvailabilityForm = new CoachAvailabilityForm();
            coachAvailabilityForm.MdiParent = this;
            coachAvailabilityForm.Show();
        }

        private void changeMyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetMyPassword passwordResetForm = new ResetMyPassword();
            passwordResetForm.MdiParent = this;
            passwordResetForm.Show();
        }

        private void setScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoachScheduleForm coachScheduleForm = new CoachScheduleForm();
            coachScheduleForm.MdiParent = this;
            coachScheduleForm.Show();
        }

        private void printScheduleByDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintSchedule printScheduleForm = new PrintSchedule();
            printScheduleForm.MdiParent = this;
            printScheduleForm.Show();
        }

        private void updateCourseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseAdminForm courseAdminForm = new CourseAdminForm();
            courseAdminForm.MdiParent = this;
            courseAdminForm.Show();
        }
    }
}
