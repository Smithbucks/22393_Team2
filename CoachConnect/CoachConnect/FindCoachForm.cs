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
    public partial class FindCoachForm : Form
    {
        public FindCoachForm()
        {
            InitializeComponent();
            displayInfo();
            displayCoachList();
            displayAppointment();
            panelCoach.Visible = false;
        }

        private void SelectedInterest(Image interest, string title)
        {
            this.Hide();
            frmCoachInterest frm2 = new frmCoachInterest(this, interest,title);
            frm2.Show();
            frm2.Location = this.Location;
        }

        private void btnAgri_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnAgri.BackgroundImage, lblAgri.Text);
        }

        private void btnArch_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnArch.BackgroundImage, lblArch.Text);
        }

        private void btnBusiness_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnBusiness.BackgroundImage,lblBusiness.Text);
        }

        private void btnDigital_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnDigital.BackgroundImage,lblDigital.Text);
        }

        private void btnEnergy_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnEnergy.BackgroundImage,lblEnergy.Text);
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnGeneral.BackgroundImage,lblGeneral.Text);
        }

        private void bthHealth_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnHealth.BackgroundImage,lblHealth.Text);
        }

        private void btnHuman_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnHuman.BackgroundImage,lblHuman.Text);
        }

        private void btnIT_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnIT.BackgroundImage, lblIT.Text);
        }

        private void btnLaw_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnLaw.BackgroundImage,lblLaw.Text);
        }

        private void btnManu_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnManu.BackgroundImage, lblManu.Text);
        }

        private void btnScience_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnScience.BackgroundImage,lblScience.Text);
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            SelectedInterest(btnTransport.BackgroundImage,lblTransport.Text);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Disipaly student info to the home tab
        private void displayInfo()
        {
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from u in context.Users
                                where u.UserID.Equals(Program.CurrentUser)
                                select u;
                var userResult = userQuery.FirstOrDefault<User>();
                lblStdID.Text = userResult.UserID;
                lblStdName.Text = userResult.FirstName + " " + userResult.LastName;
                lblStdEmail.Text = userResult.Email;
                lblStdPhone.Text = displayPhoneFormat(userResult.Phone);
                     
            }
        }

        //Display phone number in the phone format
        private string displayPhoneFormat(string phone)
        {
            string p = phone;
            string formatedPhoneNumber = string.Format("({0}) {1}-{2}", p.Substring(0, 3), p.Substring(3, 3), p.Substring(6, 4));
            return formatedPhoneNumber;
        }
        //Display all available coaches on the combobox
        private void displayCoachList()
        {    
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = (from u in context.Users
                                where u.IsCoach.Equals(true)
                                select u.FirstName).ToList();
                
                foreach(var c in userQuery)
                {
                    
                    comboBoxCoaches.Items.Add(c);
                }
            }
        }

        //Button click to search for specific coach from the database
        private void button2_Click(object sender, EventArgs e)
        {          
            string selectedCoach = (string)comboBoxCoaches.SelectedItem;
            seachForCoach(selectedCoach);
        }

        //Called in the button2 to search a coach
        private void seachForCoach(string coach)
        {
            using (var context = new db_sft_2172Entities())
            {
                var userQuery = from u in context.Users
                                where u.IsCoach.Equals(true) && u.FirstName.Equals(coach)
                                select u;
                var userResult = userQuery.FirstOrDefault<User>();
                if (!String.IsNullOrEmpty(userResult.FirstName))
                {
                    panelCoach.Visible = true;
                    var request = System.Net.WebRequest.Create(userResult.ProfilePic);

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBoxCoachProfile.Image = Bitmap.FromStream(stream);
                    }
                    lblCoachName.Text = userResult.FirstName + " " + userResult.LastName;
                    lblActiveCoach.Text = userResult.ActiveCoachSince.ToString();
                    lblEmail.Text = userResult.Email;
                    lblPhone.Text = userResult.Phone;
                }

            }
        }
        
        //Display the appointments for that student in datagridview
        private void displayAppointment()
        {
            using (var context = new db_sft_2172Entities())
            {
                List<CoachByTime> appointment = new List<CoachByTime>();
                var userQuery = from u in context.CoachByTimes
                                where u.UserID.Equals(Program.CurrentUser)
                                select u;
                var userResult = userQuery.ToList();
                foreach(var u in userResult)
                {
                    appointment.Add(u);
                }
                if(appointment.Count() > 0)
                {
                    dgrShowAppointments.Visible = true;
                    dgrShowAppointments.DataSource = appointment;
                    appointmentMessage.Visible = false;
                }
                else
                {
                    dgrShowAppointments.Visible = false;
                    appointmentMessage.Visible = true;
                }
                
            }
        }  

        //Reset password button click
        private void btnResetPassowrd_Click(object sender, EventArgs e)
        {
            ResetStudentPassword resetForm = new ResetStudentPassword();
            resetForm.Show();
            this.Hide();
        }

        //Edit profile button click
        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditStudentProfileForm editForm = new EditStudentProfileForm();
            editForm.Show();
            this.Hide();
        }
    }
}
