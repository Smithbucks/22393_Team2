// <copyright file="ResetMyPassword.cs" company="Adam J. Smith at NWTC">
//     Copyright 2018 Smithbucks Computing (Adam J. Smith, radarsmith83@gmail.com)
// </copyright>

namespace CoachConnect
{
    using System;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// A form that allows a user to reset his/her password
    /// </summary>
    public partial class ResetMyPassword : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResetMyPassword" /> class.
        /// </summary>
        public ResetMyPassword()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Event handler to click to save the new password into the database
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnSaveNewPasswordClick(object sender, EventArgs e)
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var userQuery = from u in context.Users
                        where u.UserID.Equals(Program.CurrentUser)
                        select u;

                    var userResult = userQuery.FirstOrDefault();

                    if (SaltedHash.Verify(userResult.PasswordSalt, userResult.Password, this.txtCurrentPassword.Text))
                    {
                        if (!string.IsNullOrEmpty(this.txtNewPassword.Text) ||
                            !string.IsNullOrEmpty(this.txtConfirmPassword.Text))
                        {
                            if (this.txtNewPassword.Text == this.txtConfirmPassword.Text)
                            {
                                // Generate salt and salted hash
                                SaltedHash sh = new SaltedHash(this.txtNewPassword.Text);
                                userResult.Password = sh.Hash;
                                userResult.PasswordSalt = sh.Salt;
                                userResult.ResetPassword = null;
                                context.SaveChanges();

                                this.txtCurrentPassword.Text = string.Empty;
                                this.txtNewPassword.Text = string.Empty;
                                this.txtConfirmPassword.Text = string.Empty;
                                MessageBox.Show(@"Your passsword has been saved!");

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(@"Passwords do not match!");
                            }
                        }
                        else
                        {
                            MessageBox.Show(@"New password or confirm password is empty!");
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Your current password is incorrect!");
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
        /// Event handler to cancel the reset new password.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnCancelResetPasswordClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event handler to validate current password input.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        /*
        private void TxtStdPasswordLeave(object sender, EventArgs e)
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    var userQuery = from u in context.Users
                        where u.UserID.Equals(Program.CurrentUser)
                        select u;
                    var userResult = userQuery.FirstOrDefault();

                    if (SaltedHash.Verify(userResult.PasswordSalt, userResult.Password, this.txtStdPassword.Text))
                    {
                        this.pwdCorrect.Visible = true;
                        this.currentPWDWrong.Visible = false;
                    }
                    else
                    {
                        this.currentPWDWrong.Visible = true;
                        this.pwdCorrect.Visible = false;
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
        */

        /// <summary>
        /// Event handler to validate the new password and confirm whether the two entries are identical.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void TxtNewConfirmPasswordLeave(object sender, EventArgs e)
        {
            if (this.txtNewPassword.Text == this.txtConfirmPassword.Text && (this.txtNewPassword.Text != string.Empty || this.txtConfirmPassword.Text != string.Empty))
            {
                this.newPWD.Visible = true;
                this.newPWDConfirmCorrect.Visible = true;
                this.newPWDNotMatch.Visible = false;
                this.newPWDConfirmWrong.Visible = false;
            }
            else
            {
                this.newPWDNotMatch.Visible = true;
                this.newPWDConfirmWrong.Visible = true;
                this.newPWD.Visible = false;
                this.newPWDConfirmCorrect.Visible = false;
            }
        }

        /// <summary>
        /// Event handler to hover the new saved password button.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnSaveNewPasswordMouseHover(object sender, EventArgs e)
        {
            if (this.txtCurrentPassword.Text != string.Empty && this.txtNewPassword.Text == this.txtConfirmPassword.Text && (this.txtNewPassword.Text != string.Empty || this.txtConfirmPassword.Text != string.Empty))
            {
                this.newPWD.Visible = true;
                this.newPWDConfirmCorrect.Visible = true;
                this.newPWDNotMatch.Visible = false;
                this.newPWDConfirmWrong.Visible = false;
            }
            else
            {
                this.newPWDNotMatch.Visible = true;
                this.newPWDConfirmWrong.Visible = true;
                this.newPWD.Visible = false;
                this.newPWDConfirmCorrect.Visible = false;
            }
        }
    }
}
