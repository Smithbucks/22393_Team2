// <copyright file="ResetUserPasswordAdmin.cs" company="Adam J. Smith at NWTC">
//     Copyright 2018 Smithbucks Computing (Adam J. Smith, radarsmith83@gmail.com)
// </copyright>
namespace CoachConnect
{
    using System;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// A form for admin's to reset a password and enter a new temporary access code.
    /// </summary>
    public partial class ResetUserPasswordAdmin : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResetUserPasswordAdmin" /> class. 
        /// </summary>
        /// <param name="userId">The userID whose password needs to be updated</param>
        public ResetUserPasswordAdmin(string userId)
        {
            this.CurrentUserId = userId;
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets the current UserID whose password needs to be updated
        /// </summary>
        private string CurrentUserId { get; }

        /// <summary>
        /// Event handler to set temporary access code
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnUpdateClick(object sender, EventArgs e)
        {
            // Verify that the two entered passwords match
            if (!this.txtTempCode.Text.Equals(this.txtConfirmTempCode.Text))
            {
                MessageBox.Show(@"Sorry, the codes do not match.  Please try again!");

                // Clear the password boxes
                this.txtTempCode.Text = string.Empty;
                this.txtConfirmTempCode.Text = string.Empty;

                this.txtTempCode.Focus();
            }
            else if (this.txtTempCode.Text.Equals(string.Empty))
            {
                MessageBox.Show(@"Please enter a code (max 10 characters).");

                // Clear the password boxes
                this.txtTempCode.Text = string.Empty;
                this.txtConfirmTempCode.Text = string.Empty;

                this.txtTempCode.Focus();
            }
            else
            {
                // Find current user, then update temporary code in database
                try
                {
                    using (var context = new db_sft_2172Entities())
                    {
                        // Run query to get user data
                        var userQuery = from users in context.Users
                                        where users.UserID.Equals(this.CurrentUserId)
                                        select users;

                        User currentUser = userQuery.FirstOrDefault();

                        if (currentUser != null)
                        {
                        currentUser.ResetPassword = this.txtTempCode.Text;
                        context.SaveChanges();

                        // Show confirmation if save is successful
                        MessageBox.Show(@"Temporary code updated successfully!");
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

                // Close the form when finished
                this.Close();
            }
        }

        /// <summary>
        /// Event handler to close the form when the Cancel button is clicked
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">     The parameter is not used.</param>
        private void BtnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event handler to validate the new password and confirm the entries are identical.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void TxtStdNewConfirmPasswordLeave(object sender, EventArgs e)
        {
            if (this.txtTempCode.Text == this.txtConfirmTempCode.Text && (this.txtTempCode.Text != string.Empty || this.txtConfirmTempCode.Text != string.Empty))
            {
                this.imgPasswordValid.Visible = true;
                this.imgPasswordNotValid.Visible = false;
            }
            else
            {
                this.imgPasswordNotValid.Visible = true;
                this.imgPasswordValid.Visible = false;
            }
        }
    }
}
