// <copyright file="EditSession.Designer.cs" company="Adam J. Smith at NWTC">
//     Copyright 2018 Smithbucks Computing (Adam J. Smith, radarsmith83@gmail.com)
// </copyright>
namespace CoachConnect
{
    /// <summary>
    /// EditSession: A form which allows users to create and edit session data, then save the data to the database.
    /// </summary>
    public partial class EditSession
    {
        /// <summary>
        /// Label for the Room combo box
        /// </summary>
        private System.Windows.Forms.Label lblStartTime;

        /// <summary>
        /// Combo box containing active rooms
        /// </summary>
        private System.Windows.Forms.ComboBox cbxStartTime;

        /// <summary>
        /// Label for the Day combo box
        /// </summary>
        private System.Windows.Forms.Label lblDay;

        /// <summary>
        /// Combo box containing active Days
        /// </summary>
        private System.Windows.Forms.ComboBox cbxDay;

        /// <summary>
        /// Label for the Time combo box
        /// </summary>
        private System.Windows.Forms.Label lblEndTime;

        /// <summary>
        /// Combo box containing active Times
        /// </summary>
        private System.Windows.Forms.ComboBox cbxEndTime;

        /// <summary>
        /// Label for the Coach combo box
        /// </summary>
        private System.Windows.Forms.Label lblCoach;

        /// <summary>
        /// Combo box containing active coaches
        /// </summary>
        private System.Windows.Forms.ComboBox cbxCoach;

        /// <summary>
        /// Label for the form title
        /// </summary>
        private System.Windows.Forms.Label lblEditSessionHeader;

        /// <summary>
        /// Button allowing users to save changes
        /// </summary>
        private System.Windows.Forms.Button btnSave;

        /// <summary>
        /// Button allowing users to cancel changes
        /// </summary>
        private System.Windows.Forms.Button btnCancel;

        /// <summary>
        /// Label for the Active combo box
        /// </summary>
        private System.Windows.Forms.Label lblActive;

        /// <summary>
        /// Combo box allowing users to select an active value (Yes or No)
        /// </summary>
        private System.Windows.Forms.ComboBox cbxActive;

        /// <summary>
        /// Validation label indicating a room was not selected
        /// </summary>
        private System.Windows.Forms.Label lblInvalidStartTime;

        /// <summary>
        /// Validation label indicating a day was not selected
        /// </summary>
        private System.Windows.Forms.Label lblInvalidDay;

        /// <summary>
        /// Validation label indicating a time was not selected
        /// </summary>
        private System.Windows.Forms.Label lblInvalidEndTime;

        /// <summary>
        /// Validation label indicating an inactive value was not selected
        /// </summary>
        private System.Windows.Forms.Label lblInvalidActive;

        /// <summary>
        /// Another group box
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox2;

        /// <summary>
        /// A validation label to indicate an invalid or non-selected coach
        /// </summary>
        private System.Windows.Forms.Label lblInvalidCoach;

        /// <summary>
        /// A validation label to indicate an invalid or non-selected room
        /// </summary>
        private System.Windows.Forms.Label lblInvalidRoom;

        /// <summary>
        /// A label to mark the Room combo box
        /// </summary>
        private System.Windows.Forms.Label lblRoom;

        /// <summary>
        /// A label to select the room location
        /// </summary>
        private System.Windows.Forms.ComboBox cbxRoom;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSession));
            this.lblStartTime = new System.Windows.Forms.Label();
            this.cbxStartTime = new System.Windows.Forms.ComboBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.cbxDay = new System.Windows.Forms.ComboBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.cbxEndTime = new System.Windows.Forms.ComboBox();
            this.lblCoach = new System.Windows.Forms.Label();
            this.cbxCoach = new System.Windows.Forms.ComboBox();
            this.lblEditSessionHeader = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblActive = new System.Windows.Forms.Label();
            this.cbxActive = new System.Windows.Forms.ComboBox();
            this.lblInvalidStartTime = new System.Windows.Forms.Label();
            this.lblInvalidDay = new System.Windows.Forms.Label();
            this.lblInvalidEndTime = new System.Windows.Forms.Label();
            this.lblInvalidActive = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblInvalidRoom = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cbxRoom = new System.Windows.Forms.ComboBox();
            this.lblInvalidCoach = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(18, 85);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(55, 13);
            this.lblStartTime.TabIndex = 5;
            this.lblStartTime.Text = "Start Time";
            // 
            // cbxStartTime
            // 
            this.cbxStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStartTime.FormattingEnabled = true;
            this.cbxStartTime.Location = new System.Drawing.Point(79, 82);
            this.cbxStartTime.Name = "cbxStartTime";
            this.cbxStartTime.Size = new System.Drawing.Size(121, 21);
            this.cbxStartTime.TabIndex = 4;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(18, 58);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(26, 13);
            this.lblDay.TabIndex = 7;
            this.lblDay.Text = "Day";
            // 
            // cbxDay
            // 
            this.cbxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.Location = new System.Drawing.Point(79, 55);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(121, 21);
            this.cbxDay.TabIndex = 6;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(18, 112);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(52, 13);
            this.lblEndTime.TabIndex = 9;
            this.lblEndTime.Text = "End Time";
            // 
            // cbxEndTime
            // 
            this.cbxEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEndTime.FormattingEnabled = true;
            this.cbxEndTime.Location = new System.Drawing.Point(79, 109);
            this.cbxEndTime.Name = "cbxEndTime";
            this.cbxEndTime.Size = new System.Drawing.Size(121, 21);
            this.cbxEndTime.TabIndex = 8;
            // 
            // lblCoach
            // 
            this.lblCoach.AutoSize = true;
            this.lblCoach.Location = new System.Drawing.Point(18, 31);
            this.lblCoach.Name = "lblCoach";
            this.lblCoach.Size = new System.Drawing.Size(38, 13);
            this.lblCoach.TabIndex = 11;
            this.lblCoach.Text = "Coach";
            // 
            // cbxCoach
            // 
            this.cbxCoach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCoach.FormattingEnabled = true;
            this.cbxCoach.Location = new System.Drawing.Point(79, 28);
            this.cbxCoach.Name = "cbxCoach";
            this.cbxCoach.Size = new System.Drawing.Size(121, 21);
            this.cbxCoach.TabIndex = 10;
            // 
            // lblEditSessionHeader
            // 
            this.lblEditSessionHeader.AutoSize = true;
            this.lblEditSessionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEditSessionHeader.Location = new System.Drawing.Point(117, 9);
            this.lblEditSessionHeader.Name = "lblEditSessionHeader";
            this.lblEditSessionHeader.Size = new System.Drawing.Size(114, 24);
            this.lblEditSessionHeader.TabIndex = 12;
            this.lblEditSessionHeader.Text = "Edit Session";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(11, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(262, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(18, 168);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(37, 13);
            this.lblActive.TabIndex = 16;
            this.lblActive.Text = "Active";
            // 
            // cbxActive
            // 
            this.cbxActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxActive.FormattingEnabled = true;
            this.cbxActive.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbxActive.Location = new System.Drawing.Point(79, 163);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(121, 21);
            this.cbxActive.TabIndex = 15;
            // 
            // lblInvalidStartTime
            // 
            this.lblInvalidStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidStartTime.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidStartTime.Location = new System.Drawing.Point(206, 82);
            this.lblInvalidStartTime.Name = "lblInvalidStartTime";
            this.lblInvalidStartTime.Size = new System.Drawing.Size(90, 18);
            this.lblInvalidStartTime.TabIndex = 26;
            this.lblInvalidStartTime.Text = "Invalid Start Time";
            this.lblInvalidStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInvalidStartTime.Visible = false;
            // 
            // lblInvalidDay
            // 
            this.lblInvalidDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidDay.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidDay.Location = new System.Drawing.Point(206, 58);
            this.lblInvalidDay.Name = "lblInvalidDay";
            this.lblInvalidDay.Size = new System.Drawing.Size(75, 13);
            this.lblInvalidDay.TabIndex = 27;
            this.lblInvalidDay.Text = "Invalid Day";
            this.lblInvalidDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInvalidDay.Visible = false;
            // 
            // lblInvalidEndTime
            // 
            this.lblInvalidEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidEndTime.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidEndTime.Location = new System.Drawing.Point(206, 112);
            this.lblInvalidEndTime.Name = "lblInvalidEndTime";
            this.lblInvalidEndTime.Size = new System.Drawing.Size(90, 13);
            this.lblInvalidEndTime.TabIndex = 28;
            this.lblInvalidEndTime.Text = "Invalid End Time";
            this.lblInvalidEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInvalidEndTime.Visible = false;
            // 
            // lblInvalidActive
            // 
            this.lblInvalidActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidActive.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidActive.Location = new System.Drawing.Point(206, 164);
            this.lblInvalidActive.Name = "lblInvalidActive";
            this.lblInvalidActive.Size = new System.Drawing.Size(75, 20);
            this.lblInvalidActive.TabIndex = 30;
            this.lblInvalidActive.Text = "Invalid Choice";
            this.lblInvalidActive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInvalidActive.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInvalidRoom);
            this.groupBox2.Controls.Add(this.lblRoom);
            this.groupBox2.Controls.Add(this.cbxRoom);
            this.groupBox2.Controls.Add(this.lblInvalidActive);
            this.groupBox2.Controls.Add(this.lblInvalidCoach);
            this.groupBox2.Controls.Add(this.lblInvalidEndTime);
            this.groupBox2.Controls.Add(this.lblInvalidDay);
            this.groupBox2.Controls.Add(this.lblInvalidStartTime);
            this.groupBox2.Controls.Add(this.lblActive);
            this.groupBox2.Controls.Add(this.cbxDay);
            this.groupBox2.Controls.Add(this.lblDay);
            this.groupBox2.Controls.Add(this.cbxActive);
            this.groupBox2.Controls.Add(this.lblCoach);
            this.groupBox2.Controls.Add(this.cbxCoach);
            this.groupBox2.Controls.Add(this.lblEndTime);
            this.groupBox2.Controls.Add(this.cbxEndTime);
            this.groupBox2.Controls.Add(this.lblStartTime);
            this.groupBox2.Controls.Add(this.cbxStartTime);
            this.groupBox2.Location = new System.Drawing.Point(16, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 200);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Session Details";
            // 
            // lblInvalidRoom
            // 
            this.lblInvalidRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidRoom.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidRoom.Location = new System.Drawing.Point(206, 135);
            this.lblInvalidRoom.Name = "lblInvalidRoom";
            this.lblInvalidRoom.Size = new System.Drawing.Size(75, 20);
            this.lblInvalidRoom.TabIndex = 33;
            this.lblInvalidRoom.Text = "Invalid Room";
            this.lblInvalidRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInvalidRoom.Visible = false;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(18, 139);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(35, 13);
            this.lblRoom.TabIndex = 32;
            this.lblRoom.Text = "Room";
            // 
            // cbxRoom
            // 
            this.cbxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoom.FormattingEnabled = true;
            this.cbxRoom.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbxRoom.Location = new System.Drawing.Point(79, 136);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.Size = new System.Drawing.Size(121, 21);
            this.cbxRoom.TabIndex = 31;
            // 
            // lblInvalidCoach
            // 
            this.lblInvalidCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidCoach.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidCoach.Location = new System.Drawing.Point(206, 28);
            this.lblInvalidCoach.Name = "lblInvalidCoach";
            this.lblInvalidCoach.Size = new System.Drawing.Size(75, 18);
            this.lblInvalidCoach.TabIndex = 29;
            this.lblInvalidCoach.Text = "Invalid Coach";
            this.lblInvalidCoach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInvalidCoach.Visible = false;
            // 
            // EditSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 285);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEditSessionHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Session";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}