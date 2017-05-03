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
    public partial class ResetStudentPassword : Form
    {
        public ResetStudentPassword()
        {
            InitializeComponent();
        }

        //Button click to save the new password into the database
        private void btnSaveNewPassword_Click(object sender, EventArgs e)
        {
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from u in context.Users
                                where u.UserID.Equals(Program.CurrentUser)
                                select u;
                var userResult = userQuery.FirstOrDefault<User>();
                if (userResult.Password == txtStdPassword.Text)
                {
                    
                    if (!String.IsNullOrEmpty(txtStdNewPassword.Text) || !String.IsNullOrEmpty(txtStdNewConfirmPassowrd.Text))
                    {
                        if (txtStdNewPassword.Text == txtStdNewConfirmPassowrd.Text)
                        {
                            userResult.Password = txtStdNewPassword.Text;
                            context.SaveChanges();
                            txtStdPassword.Text = "";
                            txtStdNewPassword.Text = "";
                            txtStdNewConfirmPassowrd.Text = "";
                            MessageBox.Show("Your passsword is save!");
                            FindCoachForm coach = new FindCoachForm();
                            coach.Show();
                            this.Close();
                        }
                        else
                        {
                            
                            MessageBox.Show("Both passwords do not match eachother!");
                        }
                    }
                }
                else
                {  
                    MessageBox.Show("Your current password is incorect!");
                }
            }
        }

        //Cancle the reset new password
        private void btnCancleResetPassword_Click(object sender, EventArgs e)
        {
            FindCoachForm mainForm = new FindCoachForm();
            mainForm.Show();
            this.Close();
        }

        //An event handler used to validate current password input
        private void txtStdPassword_Leave(object sender, EventArgs e)
        {
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from u in context.Users
                                where u.UserID.Equals(Program.CurrentUser)
                                select u;
                var userResult = userQuery.FirstOrDefault<User>();
                if (userResult.Password == txtStdPassword.Text)
                {
                    pwdCorrect.Visible = true;
                    currentPWDWrong.Visible = false;
                }
                else
                {
                    currentPWDWrong.Visible = true;
                    pwdCorrect.Visible = false;
                }
            }
        }

        //An event handler used to validate the new password with the confirm weither they are matched
        private void txtStdNewConfirmPassowrd_Leave(object sender, EventArgs e)
        {
            if (txtStdNewPassword.Text == txtStdNewConfirmPassowrd.Text && (txtStdNewPassword.Text != "" || txtStdNewConfirmPassowrd.Text != ""))
            {
                newPWD.Visible = true;
                newPWDConfirmCorrect.Visible = true;
                newPWDNotMatch.Visible = false;
                newPWDConfirmWrong.Visible = false;
            }
            else
            {
                newPWDNotMatch.Visible = true;
                newPWDConfirmWrong.Visible = true;
                newPWD.Visible = false;
                newPWDConfirmCorrect.Visible = false;
            }
        }

        private void btnSaveNewPassword_MouseHover(object sender, EventArgs e)
        {
            if (txtStdNewPassword.Text == txtStdNewConfirmPassowrd.Text && (txtStdNewPassword.Text != "" || txtStdNewConfirmPassowrd.Text != ""))
            {
                newPWD.Visible = true;
                newPWDConfirmCorrect.Visible = true;
                newPWDNotMatch.Visible = false;
                newPWDConfirmWrong.Visible = false;
            }
            else
            {
                newPWDNotMatch.Visible = true;
                newPWDConfirmWrong.Visible = true;
                newPWD.Visible = false;
                newPWDConfirmCorrect.Visible = false;
            }
        }
    }
}
