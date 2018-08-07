// <copyright file="EditCoachAvailability.Designer.cs" company="Adam J. Smith at NWTC">
//     Copyright 2018 Smithbucks Computing (Adam J. Smith, radarsmith83@gmail.com)
// </copyright>
namespace CoachConnect
{
    /// <summary>
    /// EditSession: A form which allows users to create and edit session data, then save the data to the database.
    /// </summary>
    public partial class EditCoachAvailability
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
        /// Another group box
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox2;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCoachAvailability));
            this.lblStartTime = new System.Windows.Forms.Label();
            this.cbxStartTime = new System.Windows.Forms.ComboBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.cbxDay = new System.Windows.Forms.ComboBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.cbxEndTime = new System.Windows.Forms.ComboBox();
            this.lblEditSessionHeader = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInvalidStartTime = new System.Windows.Forms.Label();
            this.lblInvalidDay = new System.Windows.Forms.Label();
            this.lblInvalidEndTime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(18, 62);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(55, 13);
            this.lblStartTime.TabIndex = 5;
            this.lblStartTime.Text = "Start Time";
            // 
            // cbxStartTime
            // 
            this.cbxStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStartTime.FormattingEnabled = true;
            this.cbxStartTime.Location = new System.Drawing.Point(79, 59);
            this.cbxStartTime.Name = "cbxStartTime";
            this.cbxStartTime.Size = new System.Drawing.Size(121, 21);
            this.cbxStartTime.TabIndex = 4;
            this.cbxStartTime.Leave += new System.EventHandler(this.CbxStartTime_Leave);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(18, 35);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(26, 13);
            this.lblDay.TabIndex = 7;
            this.lblDay.Text = "Day";
            // 
            // cbxDay
            // 
            this.cbxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.Location = new System.Drawing.Point(79, 32);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(121, 21);
            this.cbxDay.TabIndex = 6;
            this.cbxDay.Leave += new System.EventHandler(this.CbxDay_Leave);
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(18, 89);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(52, 13);
            this.lblEndTime.TabIndex = 9;
            this.lblEndTime.Text = "End Time";
            // 
            // cbxEndTime
            // 
            this.cbxEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEndTime.FormattingEnabled = true;
            this.cbxEndTime.Location = new System.Drawing.Point(79, 86);
            this.cbxEndTime.Name = "cbxEndTime";
            this.cbxEndTime.Size = new System.Drawing.Size(121, 21);
            this.cbxEndTime.TabIndex = 8;
            this.cbxEndTime.Leave += new System.EventHandler(this.CbxEndTime_Leave);
            // 
            // lblEditSessionHeader
            // 
            this.lblEditSessionHeader.AutoSize = true;
            this.lblEditSessionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEditSessionHeader.Location = new System.Drawing.Point(81, 9);
            this.lblEditSessionHeader.Name = "lblEditSessionHeader";
            this.lblEditSessionHeader.Size = new System.Drawing.Size(193, 24);
            this.lblEditSessionHeader.TabIndex = 12;
            this.lblEditSessionHeader.Text = "Edit Coach Availability";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 180);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(262, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // lblInvalidStartTime
            // 
            this.lblInvalidStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidStartTime.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidStartTime.Location = new System.Drawing.Point(206, 59);
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
            this.lblInvalidDay.Location = new System.Drawing.Point(206, 35);
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
            this.lblInvalidEndTime.Location = new System.Drawing.Point(206, 89);
            this.lblInvalidEndTime.Name = "lblInvalidEndTime";
            this.lblInvalidEndTime.Size = new System.Drawing.Size(90, 13);
            this.lblInvalidEndTime.TabIndex = 28;
            this.lblInvalidEndTime.Text = "Invalid End Time";
            this.lblInvalidEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInvalidEndTime.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInvalidEndTime);
            this.groupBox2.Controls.Add(this.lblInvalidDay);
            this.groupBox2.Controls.Add(this.lblInvalidStartTime);
            this.groupBox2.Controls.Add(this.cbxDay);
            this.groupBox2.Controls.Add(this.lblDay);
            this.groupBox2.Controls.Add(this.lblEndTime);
            this.groupBox2.Controls.Add(this.cbxEndTime);
            this.groupBox2.Controls.Add(this.lblStartTime);
            this.groupBox2.Controls.Add(this.cbxStartTime);
            this.groupBox2.Location = new System.Drawing.Point(16, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 125);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // EditCoachAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 216);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEditSessionHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditCoachAvailability";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Availability";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}