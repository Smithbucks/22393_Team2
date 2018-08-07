// <copyright file="MainForm.Designer.cs" company="Adam J. Smith at NWTC">
//     Copyright 2018 Smithbucks Computing (Adam J. Smith, radarsmith83@gmail.com)
// </copyright>
namespace CoachConnect
{
    /// <summary>
    /// Defines design elements for the MainForm class
    /// </summary>
    public partial class MainForm
    {
        /// <summary>
        /// A Menu Strip to store program options
        /// </summary>
        private System.Windows.Forms.MenuStrip menuStrip1;

        /// <summary>
        /// MenuItem for the File menu
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

        /// <summary>
        /// MenuItem for the File -> Print Schedule menu item
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem printScheduleByDepartmentToolStripMenuItem;

        /// <summary>
        /// MenuItem for the File -> Exit menu item
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        /// <summary>
        /// MenuItem for the Admin menu
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;

        /// <summary>
        /// MenuItem for the Admin -> Add/Update User menu option
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem addUpdateUserToolStripMenuItem;

        /// <summary>
        /// MenuItem for the Admin -> Update Course List menu option
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem updateCourseListToolStripMenuItem;

        /// <summary>
        /// MenuItem for the Coaches menu
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem coachesToolStripMenuItem;

        /// <summary>
        /// MenuItem for the Coaches -> Update Profile menu item
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;

        /// <summary>
        /// MenuItem for the Coaches -> Set Availability menu item
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem setAvailabilityToolStripMenuItem;

        /// <summary>
        /// MenuItem for the Coaches -> Set Schedule menu item
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem setScheduleToolStripMenuItem;
        
        /// <summary>
        /// MenuItem for the Help menu
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

        /// <summary>
        /// MenuItem for the Help -> Change My Password menu item
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem changeMyPasswordToolStripMenuItem;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printScheduleByDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUpdateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCourseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coachesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAvailabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeMyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.coachesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1218, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printScheduleByDepartmentToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printScheduleByDepartmentToolStripMenuItem
            // 
            this.printScheduleByDepartmentToolStripMenuItem.Name = "printScheduleByDepartmentToolStripMenuItem";
            this.printScheduleByDepartmentToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.printScheduleByDepartmentToolStripMenuItem.Text = "Print Schedule by Department";
            this.printScheduleByDepartmentToolStripMenuItem.Click += new System.EventHandler(this.PrintScheduleByDepartmentToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
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
            // addUpdateUserToolStripMenuItem
            // 
            this.addUpdateUserToolStripMenuItem.Name = "addUpdateUserToolStripMenuItem";
            this.addUpdateUserToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addUpdateUserToolStripMenuItem.Text = "Add/Update User";
            this.addUpdateUserToolStripMenuItem.Click += new System.EventHandler(this.AddUpdateUserToolStripMenuItem_Click);
            // 
            // updateCourseListToolStripMenuItem
            // 
            this.updateCourseListToolStripMenuItem.Name = "updateCourseListToolStripMenuItem";
            this.updateCourseListToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.updateCourseListToolStripMenuItem.Text = "Update Course List";
            this.updateCourseListToolStripMenuItem.Click += new System.EventHandler(this.UpdateCourseListToolStripMenuItem_Click);
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
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.profileToolStripMenuItem.Text = "Update Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.ProfileToolStripMenuItem_Click);
            // 
            // setAvailabilityToolStripMenuItem
            // 
            this.setAvailabilityToolStripMenuItem.Name = "setAvailabilityToolStripMenuItem";
            this.setAvailabilityToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.setAvailabilityToolStripMenuItem.Text = "Set Availability";
            this.setAvailabilityToolStripMenuItem.Click += new System.EventHandler(this.SetAvailabilityToolStripMenuItem_Click);
            // 
            // setScheduleToolStripMenuItem
            // 
            this.setScheduleToolStripMenuItem.Name = "setScheduleToolStripMenuItem";
            this.setScheduleToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.setScheduleToolStripMenuItem.Text = "Set Schedule";
            this.setScheduleToolStripMenuItem.Click += new System.EventHandler(this.SetScheduleToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeMyPasswordToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // changeMyPasswordToolStripMenuItem
            // 
            this.changeMyPasswordToolStripMenuItem.Name = "changeMyPasswordToolStripMenuItem";
            this.changeMyPasswordToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.changeMyPasswordToolStripMenuItem.Text = "Change My Password";
            this.changeMyPasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangeMyPasswordToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 691);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CoachConnect";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}