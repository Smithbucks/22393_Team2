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
            this.WindowState = FormWindowState.Maximized;

            displayUsers();
        }

        private void displayUsers()
        {
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from u in context.Users
                                select u;
                lstBoxUsers.Items.Clear();
                foreach (var item in userQuery)
                {
                    string username = (item.UserID + " " + item.DisplayName);
                    lstBoxUsers.Items.Add(username);
                }
            }
        }

        private void chkBoxClear()
        {
           
            chkBoxAdmin.Checked = false;
            chkBoxActive.Checked = false;
            chkBoxCoach.Checked = false;
            chkBoxStudent.Checked = false;
            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxMiddleName.Clear();
            txtBoxPassword.Clear();
            txtBoxUserID.Clear();
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

      
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtBoxFirstName.Text = String.Empty;
            txtBoxLastName.Text = String.Empty;
            txtBoxMiddleName.Text = String.Empty;
            txtBoxUserID.Text = String.Empty;
            txtBoxPassword.Text = String.Empty;
            lstBoxUsers.Items.Add("First Name Middle Name Last Name");
            lstBoxUsers.SelectedIndex = lstBoxUsers.Items.Count - 1;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (lstBoxUsers.SelectedItem.Equals("First Name Middle Name Last Name"))
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
                    user.DisplayName = txtBoxFirstName.Text + " " + txtBoxMiddleName.Text + " " + txtBoxLastName.Text;
                    user.ProfilePic = "http://i.imgur.com/X8XhA6M.png?1";



                    var userQuery = context.Users.Add(user);
                    context.SaveChanges();
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

                        User user = new User();
                        userResult.FirstName = txtBoxFirstName.Text;
                        userResult.MiddleName = txtBoxMiddleName.Text;
                        userResult.LastName = txtBoxLastName.Text;
                        userResult.UserID = txtBoxUserID.Text;
                        userResult.Password = txtBoxPassword.Text;
                        userResult.IsAdmin = chkBoxAdmin.Checked;
                        userResult.IsActive = chkBoxActive.Checked;
                        userResult.IsCoach = chkBoxCoach.Checked;
                        userResult.IsStudent = chkBoxStudent.Checked;
                        userResult.DisplayName = txtBoxFirstName.Text + " " + txtBoxMiddleName.Text + " " + txtBoxLastName.Text;
                        context.SaveChanges();

                    }

                }
            }
            displayUsers();
            chkBoxClear();
            MessageBox.Show("User Profile Updated");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            chkBoxAdmin.Checked = false;
            chkBoxActive.Checked = false;
            chkBoxCoach.Checked = false;
            chkBoxStudent.Checked = false;
        }
    }
   
}

    