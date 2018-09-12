// <copyright file="CoachProfileForm.designer.cs" company="Smithbucks Designs">
//     Copyright 2018 Smithbucks Designs (Adam J. Smith)
// </copyright>
namespace CoachConnect
{
    /// <summary>
    /// A form to allow admins to edit user information
    /// </summary>
    public partial class CoachProfileForm
    {
        /// <summary>
        /// A label for the User admin form header.
        /// </summary>
        private System.Windows.Forms.Label lblAdminForm;

        /// <summary>
        /// A label for the password text box
        /// </summary>
        private System.Windows.Forms.Label lblSupervisor;

        /// <summary>
        /// A text box to hold the userID
        /// </summary>
        private System.Windows.Forms.TextBox txtDisplayName;

        /// <summary>
        /// A label for the user ID text box
        /// </summary>
        private System.Windows.Forms.Label lblDisplayName;

        /// <summary>
        /// A label for the middle name text box
        /// </summary>
        private System.Windows.Forms.Label lblMiddleName;

        /// <summary>
        /// A label for the last name text box
        /// </summary>
        private System.Windows.Forms.Label lblLastName;

        /// <summary>
        /// A label for the first name text box
        /// </summary>
        private System.Windows.Forms.Label lblFirstName;

        /// <summary>
        /// A text box to hold the middle name
        /// </summary>
        private System.Windows.Forms.TextBox txtMiddleName;

        /// <summary>
        /// A text box to hold the last name
        /// </summary>
        private System.Windows.Forms.TextBox txtLastName;

        /// <summary>
        /// A text box to hold the first name
        /// </summary>
        private System.Windows.Forms.TextBox txtFirstName;

        /// <summary>
        /// A button to make the current user active
        /// </summary>
        private System.Windows.Forms.CheckBox chkActive;

        /// <summary>
        /// A button to submit user profile changes
        /// </summary>
        private System.Windows.Forms.Button btnApply;

        /// <summary>
        /// A text box to hold the phone number
        /// </summary>
        private System.Windows.Forms.TextBox txtPhone;

        /// <summary>
        /// A label to mark the Phone text box
        /// </summary>
        private System.Windows.Forms.Label lblPhone;

        /// <summary>
        /// A text box to hold the email address
        /// </summary>
        private System.Windows.Forms.TextBox txtEmail;

        /// <summary>
        /// A label to mark the Email text box
        /// </summary>
        private System.Windows.Forms.Label lblEmail;

        /// <summary>
        /// A combo box to hold the list of supervisor options
        /// </summary>
        private System.Windows.Forms.ComboBox cbxSupervisor;

        /// <summary>
        /// A group box to display coach profile data
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox1;

        /// <summary>
        /// A combo box to hold the list of available coaches
        /// </summary>
        private System.Windows.Forms.ComboBox cbxChooseCoach;

        /// <summary>
        /// A label to mark the Choose Coach combo box
        /// </summary>
        private System.Windows.Forms.Label lblChooseCoach;

        /// <summary>
        /// A button to perform the Add Coach action
        /// </summary>
        private System.Windows.Forms.Button btnAddCoach;

        /// <summary>
        /// A button to perform the Close window action
        /// </summary>
        private System.Windows.Forms.Button btnClose;

        /// <summary>
        /// A label to mark the NWTC ID text box
        /// </summary>
        private System.Windows.Forms.Label lblNWTCID;

        /// <summary>
        /// A text box for the Coach ID field
        /// </summary>
        private System.Windows.Forms.TextBox txtID;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoachProfileForm));
            this.lblAdminForm = new System.Windows.Forms.Label();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cbxSupervisor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNWTCID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbxChooseCoach = new System.Windows.Forms.ComboBox();
            this.lblChooseCoach = new System.Windows.Forms.Label();
            this.btnAddCoach = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstUnselectedCourses = new System.Windows.Forms.ListBox();
            this.lstSelectedCourses = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnSelectCourse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdminForm
            // 
            this.lblAdminForm.AutoSize = true;
            this.lblAdminForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminForm.Location = new System.Drawing.Point(320, 18);
            this.lblAdminForm.Name = "lblAdminForm";
            this.lblAdminForm.Size = new System.Drawing.Size(231, 31);
            this.lblAdminForm.TabIndex = 7;
            this.lblAdminForm.Text = "Edit Coach Profile";
            this.lblAdminForm.UseWaitCursor = true;
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisor.Location = new System.Drawing.Point(36, 273);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(60, 13);
            this.lblSupervisor.TabIndex = 43;
            this.lblSupervisor.Text = " Supervisor";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayName.Location = new System.Drawing.Point(102, 165);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(188, 20);
            this.txtDisplayName.TabIndex = 5;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.Location = new System.Drawing.Point(24, 168);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(72, 13);
            this.lblDisplayName.TabIndex = 40;
            this.lblDisplayName.Text = "Display Name";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(27, 133);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lblMiddleName.TabIndex = 39;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(38, 98);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 38;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(39, 63);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(102, 130);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(188, 20);
            this.txtMiddleName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(102, 95);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(188, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(102, 60);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(188, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(148, 315);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 9;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(378, 477);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(125, 22);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "Save";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnSubmitClick);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(102, 200);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(188, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(58, 203);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 50;
            this.lblPhone.Text = "Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(102, 235);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(188, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(64, 238);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 52;
            this.lblEmail.Text = "Email";
            // 
            // cbxSupervisor
            // 
            this.cbxSupervisor.FormattingEnabled = true;
            this.cbxSupervisor.Location = new System.Drawing.Point(102, 270);
            this.cbxSupervisor.Name = "cbxSupervisor";
            this.cbxSupervisor.Size = new System.Drawing.Size(188, 21);
            this.cbxSupervisor.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNWTCID);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.cbxSupervisor);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.chkActive);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblSupervisor);
            this.groupBox1.Controls.Add(this.txtDisplayName);
            this.groupBox1.Controls.Add(this.lblDisplayName);
            this.groupBox1.Controls.Add(this.lblMiddleName);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.txtMiddleName);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(17, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 345);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coach Profile";
            // 
            // lblNWTCID
            // 
            this.lblNWTCID.AutoSize = true;
            this.lblNWTCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNWTCID.Location = new System.Drawing.Point(42, 28);
            this.lblNWTCID.Name = "lblNWTCID";
            this.lblNWTCID.Size = new System.Drawing.Size(54, 13);
            this.lblNWTCID.TabIndex = 55;
            this.lblNWTCID.Text = "NWTC ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(102, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(188, 20);
            this.txtID.TabIndex = 1;
            // 
            // cbxChooseCoach
            // 
            this.cbxChooseCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbxChooseCoach.FormattingEnabled = true;
            this.cbxChooseCoach.Location = new System.Drawing.Point(397, 70);
            this.cbxChooseCoach.Name = "cbxChooseCoach";
            this.cbxChooseCoach.Size = new System.Drawing.Size(192, 21);
            this.cbxChooseCoach.TabIndex = 0;
            this.cbxChooseCoach.SelectedIndexChanged += new System.EventHandler(this.CbxChooseCoach_SelectedIndexChanged);
            // 
            // lblChooseCoach
            // 
            this.lblChooseCoach.AutoSize = true;
            this.lblChooseCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseCoach.Location = new System.Drawing.Point(275, 73);
            this.lblChooseCoach.Name = "lblChooseCoach";
            this.lblChooseCoach.Size = new System.Drawing.Size(104, 13);
            this.lblChooseCoach.TabIndex = 54;
            this.lblChooseCoach.Text = "Choose a Coach:";
            // 
            // btnAddCoach
            // 
            this.btnAddCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCoach.Location = new System.Drawing.Point(17, 477);
            this.btnAddCoach.Name = "btnAddCoach";
            this.btnAddCoach.Size = new System.Drawing.Size(125, 22);
            this.btnAddCoach.TabIndex = 10;
            this.btnAddCoach.Text = "Add New Coach";
            this.btnAddCoach.UseVisualStyleBackColor = true;
            this.btnAddCoach.Click += new System.EventHandler(this.BtnAddCoachClick);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(729, 477);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 22);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lstUnselectedCourses
            // 
            this.lstUnselectedCourses.FormattingEnabled = true;
            this.lstUnselectedCourses.Location = new System.Drawing.Point(26, 98);
            this.lstUnselectedCourses.Name = "lstUnselectedCourses";
            this.lstUnselectedCourses.Size = new System.Drawing.Size(200, 225);
            this.lstUnselectedCourses.TabIndex = 55;
            // 
            // lstSelectedCourses
            // 
            this.lstSelectedCourses.FormattingEnabled = true;
            this.lstSelectedCourses.Location = new System.Drawing.Point(279, 98);
            this.lstSelectedCourses.Name = "lstSelectedCourses";
            this.lstSelectedCourses.Size = new System.Drawing.Size(200, 225);
            this.lstSelectedCourses.TabIndex = 56;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbxDepartment);
            this.groupBox2.Controls.Add(this.lblDepartment);
            this.groupBox2.Controls.Add(this.btnRemoveCourse);
            this.groupBox2.Controls.Add(this.btnSelectCourse);
            this.groupBox2.Controls.Add(this.lstUnselectedCourses);
            this.groupBox2.Controls.Add(this.lstSelectedCourses);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(352, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 345);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available Courses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(348, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Selected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(92, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Available";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(165, 33);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(192, 21);
            this.cbxDepartment.TabIndex = 58;
            this.cbxDepartment.SelectedIndexChanged += new System.EventHandler(this.CbxDepartment_SelectedIndexChanged);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDepartment.Location = new System.Drawing.Point(94, 36);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(65, 13);
            this.lblDepartment.TabIndex = 58;
            this.lblDepartment.Text = "Department:";
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(232, 203);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(41, 23);
            this.btnRemoveCourse.TabIndex = 58;
            this.btnRemoveCourse.Text = "<<";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            // 
            // btnSelectCourse
            // 
            this.btnSelectCourse.Location = new System.Drawing.Point(232, 168);
            this.btnSelectCourse.Name = "btnSelectCourse";
            this.btnSelectCourse.Size = new System.Drawing.Size(41, 23);
            this.btnSelectCourse.TabIndex = 57;
            this.btnSelectCourse.Text = ">>";
            this.btnSelectCourse.UseVisualStyleBackColor = true;
            // 
            // CoachProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 514);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddCoach);
            this.Controls.Add(this.cbxChooseCoach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblChooseCoach);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblAdminForm);
            this.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CoachProfileForm";
            this.Text = "Edit Coach Profile";
            this.Load += new System.EventHandler(this.CoachAdminFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ListBox lstUnselectedCourses;
        private System.Windows.Forms.ListBox lstSelectedCourses;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Button btnSelectCourse;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
