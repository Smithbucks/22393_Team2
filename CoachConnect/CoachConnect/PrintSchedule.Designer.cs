// <copyright file="PrintSchedule.Designer.cs" company="Adam J. Smith at NWTC">
//     Copyright 2018 Smithbucks Computing (Adam J. Smith, radarsmith83@gmail.com)
// </copyright>
namespace CoachConnect
{
    /// <summary>
    /// Defines design elements for the PrintSchedule class
    /// </summary>
    public partial class PrintSchedule
    {
        /// <summary>
        /// Button to save the displayed schedule to an Excel file
        /// </summary>
        private System.Windows.Forms.Button btnSaveScheduleToExcel;

        /// <summary>
        /// Label for the Session Admin form header
        /// </summary>
        private System.Windows.Forms.Label lblSessionAdminForm;

        /// <summary>
        /// Data grid view to display the current department's schedule
        /// </summary>
        private System.Windows.Forms.DataGridView dataGridViewSchedule;

        /// <summary>
        /// Combo box to choose the desired department
        /// </summary>
        private System.Windows.Forms.ComboBox cbxChooseDepartment;

        /// <summary>
        /// Label for the Choose Department combo box
        /// </summary>
        private System.Windows.Forms.Label lblChooseDepartment;

        /// <summary>
        /// Button to close the current window
        /// </summary>
        private System.Windows.Forms.Button btnCloseWindow;

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
            this.btnSaveScheduleToExcel = new System.Windows.Forms.Button();
            this.lblSessionAdminForm = new System.Windows.Forms.Label();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.cbxChooseDepartment = new System.Windows.Forms.ComboBox();
            this.lblChooseDepartment = new System.Windows.Forms.Label();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveScheduleToExcel
            // 
            this.btnSaveScheduleToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveScheduleToExcel.Location = new System.Drawing.Point(49, 412);
            this.btnSaveScheduleToExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveScheduleToExcel.Name = "btnSaveScheduleToExcel";
            this.btnSaveScheduleToExcel.Size = new System.Drawing.Size(139, 23);
            this.btnSaveScheduleToExcel.TabIndex = 23;
            this.btnSaveScheduleToExcel.Text = "Save Schedule to Excel";
            this.btnSaveScheduleToExcel.UseVisualStyleBackColor = true;
            this.btnSaveScheduleToExcel.Click += new System.EventHandler(this.BtnSaveScheduleToExcel_Click);
            // 
            // lblSessionAdminForm
            // 
            this.lblSessionAdminForm.AutoSize = true;
            this.lblSessionAdminForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionAdminForm.Location = new System.Drawing.Point(314, 27);
            this.lblSessionAdminForm.Name = "lblSessionAdminForm";
            this.lblSessionAdminForm.Size = new System.Drawing.Size(339, 31);
            this.lblSessionAdminForm.TabIndex = 24;
            this.lblSessionAdminForm.Text = "Print Department Schedule";
            this.lblSessionAdminForm.UseWaitCursor = true;
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.AllowUserToAddRows = false;
            this.dataGridViewSchedule.AllowUserToDeleteRows = false;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(49, 112);
            this.dataGridViewSchedule.MultiSelect = false;
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(871, 295);
            this.dataGridViewSchedule.TabIndex = 22;
            // 
            // cbxChooseDepartment
            // 
            this.cbxChooseDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbxChooseDepartment.FormattingEnabled = true;
            this.cbxChooseDepartment.Location = new System.Drawing.Point(456, 74);
            this.cbxChooseDepartment.Name = "cbxChooseDepartment";
            this.cbxChooseDepartment.Size = new System.Drawing.Size(192, 21);
            this.cbxChooseDepartment.TabIndex = 57;
            this.cbxChooseDepartment.SelectedIndexChanged += new System.EventHandler(this.CbxChooseDepartment_SelectedIndexChanged);
            // 
            // lblChooseDepartment
            // 
            this.lblChooseDepartment.AutoSize = true;
            this.lblChooseDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseDepartment.Location = new System.Drawing.Point(317, 77);
            this.lblChooseDepartment.Name = "label3";
            this.lblChooseDepartment.Size = new System.Drawing.Size(133, 13);
            this.lblChooseDepartment.TabIndex = 58;
            this.lblChooseDepartment.Text = "Choose a Department:";
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseWindow.Location = new System.Drawing.Point(781, 412);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(139, 23);
            this.btnCloseWindow.TabIndex = 59;
            this.btnCloseWindow.Text = "Close Window";
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.BtnCloseWindow_Click);
            // 
            // PrintSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 464);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.cbxChooseDepartment);
            this.Controls.Add(this.lblChooseDepartment);
            this.Controls.Add(this.btnSaveScheduleToExcel);
            this.Controls.Add(this.lblSessionAdminForm);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Name = "PrintSchedule";
            this.Text = "Print Schedule by Interest";
            this.Load += new System.EventHandler(this.PrintScheduleFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}