// <copyright file="ResetMyPassword.Designer.cs" company="Adam J. Smith at NWTC">
//     Copyright 2018 Smithbucks Computing (Adam J. Smith, radarsmith83@gmail.com)
// </copyright>
namespace CoachConnect
{
    /// <summary>
    /// A form that allows a user to reset his/her password
    /// </summary>
    public partial class ResetMyPassword
    {
        /// <summary>
        /// Button to save new password
        /// </summary>
        private System.Windows.Forms.Button btnSaveNewPassword;

        /// <summary>
        /// Button to cancel the password reset
        /// </summary>
        private System.Windows.Forms.Button btnCancleResetPassword;

        /// <summary>
        /// A label for the New Password text box
        /// </summary>
        private System.Windows.Forms.Label lblNewPwd;

        /// <summary>
        /// A label for the Confirm Password text box
        /// </summary>
        private System.Windows.Forms.Label lblConfirmPwd;

        /// <summary>
        /// A text box for entering a new password
        /// </summary>
        private System.Windows.Forms.TextBox txtNewPassword;

        /// <summary>
        /// A text box for re-entering the new password
        /// </summary>
        private System.Windows.Forms.TextBox txtConfirmPassword;

        /// <summary>
        /// A label for the Current Password text box
        /// </summary>
        private System.Windows.Forms.Label lblCurrentPwd;

        /// <summary>
        /// A text box for entering the current password
        /// </summary>
        private System.Windows.Forms.TextBox txtCurrentPassword;

        /// <summary>
        /// A picture that appears next to Confirm Password when the New and Confirm passwords match
        /// </summary>
        private System.Windows.Forms.PictureBox newPWDConfirmCorrect;

        /// <summary>
        /// A picture that appears next to New Password when the New and Confirm passwords match
        /// </summary>
        private System.Windows.Forms.PictureBox newPWD;

        /// <summary>
        /// A picture that appears next to Confirm Password when the New and Confirm passwords do not match
        /// </summary>
        private System.Windows.Forms.PictureBox newPWDConfirmWrong;

        /// <summary>
        /// A picture that appears next to New Password when the New and Confirm passwords do not match
        /// </summary>
        private System.Windows.Forms.PictureBox newPWDNotMatch;

        /// <summary>
        /// A header for the Reset My Password window
        /// </summary>
        private System.Windows.Forms.Label lblHeader;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetMyPassword));
            this.btnSaveNewPassword = new System.Windows.Forms.Button();
            this.btnCancleResetPassword = new System.Windows.Forms.Button();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.lblConfirmPwd = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblCurrentPwd = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.newPWDConfirmCorrect = new System.Windows.Forms.PictureBox();
            this.newPWD = new System.Windows.Forms.PictureBox();
            this.newPWDConfirmWrong = new System.Windows.Forms.PictureBox();
            this.newPWDNotMatch = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.newPWDConfirmCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPWD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPWDConfirmWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPWDNotMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveNewPassword
            // 
            resources.ApplyResources(this.btnSaveNewPassword, "btnSaveNewPassword");
            this.btnSaveNewPassword.Name = "btnSaveNewPassword";
            this.btnSaveNewPassword.UseVisualStyleBackColor = true;
            this.btnSaveNewPassword.Click += new System.EventHandler(this.BtnSaveNewPasswordClick);
            this.btnSaveNewPassword.MouseHover += new System.EventHandler(this.BtnSaveNewPasswordMouseHover);
            // 
            // btnCancleResetPassword
            // 
            this.btnCancleResetPassword.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancleResetPassword, "btnCancleResetPassword");
            this.btnCancleResetPassword.Name = "btnCancleResetPassword";
            this.btnCancleResetPassword.UseVisualStyleBackColor = true;
            this.btnCancleResetPassword.Click += new System.EventHandler(this.BtnCancelResetPasswordClick);
            // 
            // lblNewPwd
            // 
            resources.ApplyResources(this.lblNewPwd, "lblNewPwd");
            this.lblNewPwd.Name = "lblNewPwd";
            // 
            // lblConfirmPwd
            // 
            resources.ApplyResources(this.lblConfirmPwd, "lblConfirmPwd");
            this.lblConfirmPwd.Name = "lblConfirmPwd";
            // 
            // txtNewPassword
            // 
            resources.ApplyResources(this.txtNewPassword, "txtNewPassword");
            this.txtNewPassword.Name = "txtNewPassword";
            // 
            // txtConfirmPassword
            // 
            resources.ApplyResources(this.txtConfirmPassword, "txtConfirmPassword");
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Leave += new System.EventHandler(this.TxtNewConfirmPasswordLeave);
            // 
            // lblCurrentPwd
            // 
            resources.ApplyResources(this.lblCurrentPwd, "lblCurrentPwd");
            this.lblCurrentPwd.Name = "lblCurrentPwd";
            // 
            // txtCurrentPassword
            // 
            resources.ApplyResources(this.txtCurrentPassword, "txtCurrentPassword");
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            // 
            // newPWDConfirmCorrect
            // 
            this.newPWDConfirmCorrect.Image = global::CoachConnect.Properties.Resources.correct1;
            resources.ApplyResources(this.newPWDConfirmCorrect, "newPWDConfirmCorrect");
            this.newPWDConfirmCorrect.Name = "newPWDConfirmCorrect";
            this.newPWDConfirmCorrect.TabStop = false;
            // 
            // newPWD
            // 
            this.newPWD.Image = global::CoachConnect.Properties.Resources.correct1;
            resources.ApplyResources(this.newPWD, "newPWD");
            this.newPWD.Name = "newPWD";
            this.newPWD.TabStop = false;
            // 
            // newPWDConfirmWrong
            // 
            this.newPWDConfirmWrong.Image = global::CoachConnect.Properties.Resources.wrong;
            resources.ApplyResources(this.newPWDConfirmWrong, "newPWDConfirmWrong");
            this.newPWDConfirmWrong.Name = "newPWDConfirmWrong";
            this.newPWDConfirmWrong.TabStop = false;
            // 
            // newPWDNotMatch
            // 
            this.newPWDNotMatch.Image = global::CoachConnect.Properties.Resources.wrong;
            resources.ApplyResources(this.newPWDNotMatch, "newPWDNotMatch");
            this.newPWDNotMatch.Name = "newPWDNotMatch";
            this.newPWDNotMatch.TabStop = false;
            // 
            // lblHeader
            // 
            resources.ApplyResources(this.lblHeader, "lblHeader");
            this.lblHeader.Name = "lblHeader";
            // 
            // ResetMyPassword
            // 
            this.AcceptButton = this.btnSaveNewPassword;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancleResetPassword;
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.newPWDNotMatch);
            this.Controls.Add(this.btnSaveNewPassword);
            this.Controls.Add(this.newPWDConfirmWrong);
            this.Controls.Add(this.btnCancleResetPassword);
            this.Controls.Add(this.newPWD);
            this.Controls.Add(this.newPWDConfirmCorrect);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.lblNewPwd);
            this.Controls.Add(this.lblCurrentPwd);
            this.Controls.Add(this.lblConfirmPwd);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResetMyPassword";
            ((System.ComponentModel.ISupportInitialize)(this.newPWDConfirmCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPWD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPWDConfirmWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPWDNotMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}