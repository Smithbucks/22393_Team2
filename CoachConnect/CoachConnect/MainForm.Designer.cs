﻿namespace CoachConnect
{
    partial class MainForm
    {
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coachesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUpdateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCourseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAvailabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.coachesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUpdateUserToolStripMenuItem,
            this.updateCourseListToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // coachesToolStripMenuItem
            // 
            this.coachesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.setAvailabilityToolStripMenuItem,
            this.setScheduleToolStripMenuItem});
            this.coachesToolStripMenuItem.Name = "coachesToolStripMenuItem";
            this.coachesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.coachesToolStripMenuItem.Text = "Coaches";
            // 
            // addUpdateUserToolStripMenuItem
            // 
            this.addUpdateUserToolStripMenuItem.Name = "addUpdateUserToolStripMenuItem";
            this.addUpdateUserToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addUpdateUserToolStripMenuItem.Text = "Add/Update User";
            this.addUpdateUserToolStripMenuItem.Click += new System.EventHandler(this.addUpdateUserToolStripMenuItem_Click);
            // 
            // updateCourseListToolStripMenuItem
            // 
            this.updateCourseListToolStripMenuItem.Name = "updateCourseListToolStripMenuItem";
            this.updateCourseListToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.updateCourseListToolStripMenuItem.Text = "Update Course List";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.profileToolStripMenuItem.Text = "Update Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // setAvailabilityToolStripMenuItem
            // 
            this.setAvailabilityToolStripMenuItem.Name = "setAvailabilityToolStripMenuItem";
            this.setAvailabilityToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.setAvailabilityToolStripMenuItem.Text = "Set Availability";
            // 
            // setScheduleToolStripMenuItem
            // 
            this.setScheduleToolStripMenuItem.Name = "setScheduleToolStripMenuItem";
            this.setScheduleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.setScheduleToolStripMenuItem.Text = "Set Schedule";
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eToolStripMenuItem.Text = "Exit";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.eToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 533);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CoachConnect";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coachesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUpdateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCourseListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAvailabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
    }
}