// <copyright file="UserAdminForm.cs" company="Adam J. Smith at NWTC">
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
    /// Initializes a new instance of the <see cref="UserProfileForm"/> class.
    /// </summary>
    public partial class UserProfileForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileForm"/> class.
        /// </summary>
        public UserProfileForm()
        {
            this.InitializeComponent();
        }
  
        /// <summary>
        /// Maximizes Form and displays the users with load event of the form.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void UserAdminFormLoad(object sender, EventArgs e)
        {
            this.DisplayUsers();
        }

        /// <summary>
        /// Method to display the list of users
        /// </summary>
        private void DisplayUsers()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Query user table in database and returns the list of the users in ascending order according to last name
                    var userQuery = from users in context.Users
                        orderby users.LastName
                        select users;

                    // Convert query results to list
                    List<User> userList = userQuery.ToList();

                    // Set combo box data source and update data member settings
                    this.cbxChooseUser.DataSource = userList;
                    this.cbxChooseUser.ValueMember = "UserID";
                    this.cbxChooseUser.DisplayMember = "DisplayName";
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
            this.chkActive.Checked = false;
            this.chkAdmin.Checked = false;
            this.chkSupervisor.Checked = false;
        }

        /// <summary>
        /// Populates the combo boxes and text boxes with the selected user's information
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CbxChooseUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbxChooseUser.SelectedIndex == -1)
            {
                return;
            }

            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Query obtains the user ID from the combo box
                    string userId = this.cbxChooseUser.SelectedValue.ToString();

                    // Find the user in the database
                    var userQuery = from user in context.Users
                                    where user.UserID.Equals(userId)
                                    select user;

                    // If the query returns a user, display the corresponding info in the form
                    if (userQuery.Any())
                    {
                        var userResult = userQuery.FirstOrDefault();

                        if (userResult != null)
                        {
                            this.txtID.Text = userResult.UserID;
                            this.txtFirstName.Text = userResult.FirstName;
                            this.txtLastName.Text = userResult.LastName;
                            this.txtMiddleName.Text = userResult.MiddleName;
                            this.txtDisplayName.Text = userResult.DisplayName;
                            this.txtEmail.Text = userResult.Email;
                            this.txtPhone.Text = userResult.Phone;
                            this.chkActive.Checked = userResult.IsActive;
                            this.chkAdmin.Checked = userResult.IsAdmin;
                            this.chkSupervisor.Checked = userResult.IsSupervisor;   
                        }
                    }
                }
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
                // Run query to check for a corresponding user in the database
                using (var context = new db_sft_2172Entities())
                {
                    string userId = this.txtID.Text;
                    var userQuery = from user in context.Users
                                    where user.UserID.Equals(userId)
                                    select user;

                    if (userQuery.Any())
                    {
                        var userResult = userQuery.FirstOrDefault();
                        userResult.FirstName = this.txtFirstName.Text;
                        userResult.MiddleName = this.txtMiddleName.Text;
                        userResult.LastName = this.txtLastName.Text;
                        userResult.DisplayName = this.txtDisplayName.Text;
                        userResult.Phone = this.txtPhone.Text;
                        userResult.Email = this.txtEmail.Text;
                        userResult.IsActive = this.chkActive.Checked;
                        userResult.IsAdmin = this.chkAdmin.Checked;
                        userResult.IsSupervisor = this.chkSupervisor.Checked;
                        
                        context.SaveChanges();

                        MessageBox.Show(@"User Profile Updated");
                    }
                    else
                    {
                        User newUser = new User
                        {
                            UserID = this.txtID.Text,
                            FirstName = this.txtFirstName.Text,
                            MiddleName = this.txtMiddleName.Text,
                            LastName = this.txtLastName.Text,
                            DisplayName = this.txtDisplayName.Text,
                            Phone = this.txtPhone.Text,
                            Email = this.txtEmail.Text,
                            IsActive = this.chkActive.Checked,
                            IsAdmin = this.chkAdmin.Checked,
                            IsSupervisor = this.chkSupervisor.Checked
                        };

                        context.Users.Add(newUser);
                        context.SaveChanges();

                        MessageBox.Show(@"User Profile Created");

                        // If save is successful, update the user list and display the new user profile
                        this.DisplayUsers();
                        this.cbxChooseUser.SelectedValue = newUser.UserID;
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

            this.DisplayUsers();
            this.ClearAllFields();
            MessageBox.Show(@"User Profile Updated");
        }

        /// <summary>
        /// A method to disable a selected user
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnMinusClick(object sender, EventArgs e)
        {
            this.chkAdmin.Checked = false;
            this.chkActive.Checked = false;
            this.chkSupervisor.Checked = false;
        }

        /// <summary>
        /// A button to allow users to reset their password
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnResetPasswordClick(object sender, EventArgs e)
        {
            string username = this.txtID.Text;

            ResetUserPasswordAdmin resetPasswordForm = new ResetUserPasswordAdmin(username);
            resetPasswordForm.ShowDialog();
        }
    }
}