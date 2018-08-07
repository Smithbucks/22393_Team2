// <copyright file="CourseAdminForm.designer.cs" company="Adam J. Smith at NWTC">
//     Copyright 2018 Smithbucks Computing (Adam J. Smith, radarsmith83@gmail.com)
// </copyright>
namespace CoachConnect
{
    /// <summary>
    /// A form to allow admins to edit user information
    /// </summary>
    public partial class CourseAdminForm
    {
        /// <summary>
        /// A label for the User admin form header.
        /// </summary>
        private System.Windows.Forms.Label lblAdminForm;

        /// <summary>
        /// A label for the last name text box
        /// </summary>
        private System.Windows.Forms.Label lblLastName;

        /// <summary>
        /// A label for the first name text box
        /// </summary>
        private System.Windows.Forms.Label lblFirstName;

        /// <summary>
        /// A text box to hold the first name
        /// </summary>
        private System.Windows.Forms.TextBox txtCourseName;

        /// <summary>
        /// A button to make the current user active
        /// </summary>
        private System.Windows.Forms.CheckBox chkActive;

        /// <summary>
        /// A button to submit user profile changes
        /// </summary>
        private System.Windows.Forms.Button btnSubmit;

        /// <summary>
        /// A combo box to choose a course
        /// </summary>
        private System.Windows.Forms.ComboBox cbxChooseCourse;

        /// <summary>
        /// A label to mark the Choose Course combo box
        /// </summary>
        private System.Windows.Forms.Label lblChooseCourse;

        /// <summary>
        /// A group box to display course information
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox1;

        /// <summary>
        /// A button to create a new Course when the button is clicked
        /// </summary>
        private System.Windows.Forms.Button btnAddCourse;

        /// <summary>
        /// A label to mark the CourseID text box
        /// </summary>
        private System.Windows.Forms.Label lblCourseID;

        /// <summary>
        /// A text box to store the Course ID
        /// </summary>
        private System.Windows.Forms.TextBox txtCourseID;

        /// <summary>
        /// A combo box for selecting the course's Department
        /// </summary>
        private System.Windows.Forms.ComboBox cbxDepartment;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseAdminForm));
            this.lblAdminForm = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbxChooseCourse = new System.Windows.Forms.ComboBox();
            this.lblChooseCourse = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdminForm
            // 
            this.lblAdminForm.AutoSize = true;
            this.lblAdminForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminForm.Location = new System.Drawing.Point(78, 17);
            this.lblAdminForm.Name = "lblAdminForm";
            this.lblAdminForm.Size = new System.Drawing.Size(197, 31);
            this.lblAdminForm.TabIndex = 7;
            this.lblAdminForm.Text = "Update Course";
            this.lblAdminForm.UseWaitCursor = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(34, 98);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(62, 13);
            this.lblLastName.TabIndex = 38;
            this.lblLastName.Text = "Department";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(25, 63);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(71, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "Course Name";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(102, 60);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(188, 20);
            this.txtCourseName.TabIndex = 3;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(131, 134);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 8;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(227, 281);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 22);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
            // 
            // cbxChooseCourse
            // 
            this.cbxChooseCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbxChooseCourse.FormattingEnabled = true;
            this.cbxChooseCourse.Location = new System.Drawing.Point(128, 70);
            this.cbxChooseCourse.Name = "cbxChooseCourse";
            this.cbxChooseCourse.Size = new System.Drawing.Size(207, 21);
            this.cbxChooseCourse.TabIndex = 55;
            this.cbxChooseCourse.SelectedIndexChanged += new System.EventHandler(this.CbxChooseCourse_SelectedIndexChanged);
            // 
            // lblChooseCourse
            // 
            this.lblChooseCourse.AutoSize = true;
            this.lblChooseCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseCourse.Location = new System.Drawing.Point(11, 74);
            this.lblChooseCourse.Name = "lblChooseCourse";
            this.lblChooseCourse.Size = new System.Drawing.Size(107, 13);
            this.lblChooseCourse.TabIndex = 56;
            this.lblChooseCourse.Text = "Choose a Course:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxDepartment);
            this.groupBox1.Controls.Add(this.chkActive);
            this.groupBox1.Controls.Add(this.lblCourseID);
            this.groupBox1.Controls.Add(this.txtCourseID);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.txtCourseName);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(19, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 166);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Details";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(102, 95);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(188, 21);
            this.cbxDepartment.TabIndex = 58;
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.Location = new System.Drawing.Point(39, 30);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(54, 13);
            this.lblCourseID.TabIndex = 57;
            this.lblCourseID.Text = "Course ID";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseID.Location = new System.Drawing.Point(102, 25);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(188, 20);
            this.txtCourseID.TabIndex = 56;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(19, 281);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(108, 22);
            this.btnAddCourse.TabIndex = 1;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.BtnAddClick);
            // 
            // CourseAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 319);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxChooseCourse);
            this.Controls.Add(this.lblChooseCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblAdminForm);
            this.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CourseAdminForm";
            this.Text = "User Admin";
            this.Load += new System.EventHandler(this.CourseAdminFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}
