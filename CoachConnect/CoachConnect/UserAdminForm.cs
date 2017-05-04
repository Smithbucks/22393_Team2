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
    public partial class UserAdminForm : Form
    {
        public UserAdminForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblUsers_Click(object sender, EventArgs e)
        {

        }

        private void UserAdminForm_Load(object sender, EventArgs e)
        {
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from u in context.Users
                                select u;
                foreach (var item in userQuery)
                {
                    string username = (item.UserID + " " + item.DisplayName);
                    lstBoxUsers.Items.Add(username);
                }
            }
        }

        private void lstBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new db_sft_2172Entities())
            {

                string username = lstBoxUsers.SelectedItem.ToString();
                string[] userNameSplit = username.Split(' ');
                string usernum = userNameSplit[0];
                var userQuery = from u in context.Users
                                where u.UserID.Equals(usernum)
                                select u;
                if (userQuery.Count<User>() > 0)
                {
                    var userResult = userQuery.FirstOrDefault<User>();
                    txtBoxFirstName.Text = userResult.FirstName;
                    txtBoxLastName.Text = userResult.LastName;
                    txtBoxMiddleName.Text = userResult.MiddleName;
                    txtBoxUserID.Text = userResult.UserID;
                    txtBoxPassword.Text = userResult.Password;

                    chkBoxAdmin.Checked = userResult.IsAdmin;
                    chkBoxActive.Checked = userResult.IsActive;
                    chkBoxStudent.Checked = userResult.IsStudent;
                    chkBoxCoach.Checked = userResult.IsCoach;
                }
            }
        }

        private void txtBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtBoxFirstName.Text = String.Empty;
            txtBoxLastName.Text = String.Empty;
            txtBoxMiddleName.Text = String.Empty;
            txtBoxUserID.Text = String.Empty;
            txtBoxPassword.Text = String.Empty;
            lstBoxUsers.Items.Add("First Name Middle Name Last Name");
            chkBoxActive.Checked = false;
            chkBoxAdmin.Checked = false;
            chkBoxStudent.Checked = false;
            chkBoxCoach.Checked = false;
            lstBoxUsers.SelectedIndex = lstBoxUsers.Items.Count - 1;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (lstBoxUsers.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select from list or click the plus button on bottom to add");
            }

           else if (lstBoxUsers.SelectedItem.Equals("First Name Middle Name Last Name"))
            {
                //add
                using (var context = new db_sft_2172Entities())
                {
                    User user = new User();
                    user.FirstName = txtBoxFirstName.Text;
                    user.MiddleName = txtBoxMiddleName.Text;
                    user.LastName = txtBoxLastName.Text;
                    user.UserID = txtBoxUserID.Text;
                    user.Password = txtBoxPassword.Text;
                    user.IsAdmin = chkBoxAdmin.Checked;
                    user.IsActive = chkBoxActive.Checked;
                    user.IsCoach = chkBoxCoach.Checked;
                    user.IsStudent = chkBoxStudent.Checked;
                    user.ResetPassword = false;
                    user.DisplayName = user.FirstName + " " + user.MiddleName + " " + user.LastName;



                    var userQuery = context.Users.Add(user);
                    try
                    {
                        context.SaveChanges();
                        //pop up windows for add 
                        MessageBox.Show("Profile has been added");
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.Message);
                        // Provide for exceptions.
                    }
                }
            }
            else
            {
                //update
                using (var context = new db_sft_2172Entities())
                {
                    string username = lstBoxUsers.SelectedItem.ToString();
                    string[] userNameSplit = username.Split(' ');
                    string usernum = userNameSplit[0];
                    var userQuery = from u in context.Users
                                    where u.UserID.Equals(usernum)
                                    select u;
                    if (userQuery.Count<User>() > 0)
                    {
                        var userResult = userQuery.FirstOrDefault<User>();

                        
                        userResult.FirstName = txtBoxFirstName.Text;
                        userResult.MiddleName = txtBoxMiddleName.Text;
                        userResult.LastName = txtBoxLastName.Text;
                        userResult.UserID = txtBoxUserID.Text;
                        userResult.Password = txtBoxPassword.Text;
                        userResult.IsAdmin = chkBoxAdmin.Checked;
                        userResult.IsActive = chkBoxActive.Checked;
                        userResult.IsCoach = chkBoxCoach.Checked;
                        userResult.IsStudent = chkBoxStudent.Checked;
                        userResult.DisplayName = userResult.FirstName + " " + userResult.MiddleName + " " + userResult.LastName;

                        // Submit the changes to the database.
                        try
                        {
                            context.SaveChanges();
                            //pop up windows for update 
                            MessageBox.Show("Profile has been updated");
                        }
                        catch (Exception f)
                        {
                            MessageBox.Show(f.Message);
                            // Provide for exceptions.
                        }



                    }

                }
            }
            lstBoxUsers.Items.Clear();
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from u in context.Users
                                select u;
                foreach (var item in userQuery)
                {
                    string username = (item.UserID + " " + item.DisplayName);
                    lstBoxUsers.Items.Add(username);
                }
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm reset = new ChangePasswordForm();
            reset.ShowDialog();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

    