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
        /// An icon that will allow users to step away from 
        /// </summary>
        private System.Windows.Forms.PictureBox currentPWDWrong;

        /// <summary>
        /// A picture box to validate matching passwords
        /// </summary>
        private System.Windows.Forms.PictureBox newPWD;

        /// <summary>
        /// A picture box to confirm that the passwords were correct.
        /// </summary>
        private System.Windows.Forms.PictureBox newPWDConfirmCorrect;

        /// <summary>
        /// Icon for "correct"
        /// </summary>
        private System.Windows.Forms.PictureBox pwdCorrect;

        /// <summary>
        /// Text box to store and update password
        /// </summary>
        private System.Windows.Forms.TextBox txtStdPassword;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label1;

        /// <summary>
        /// Text box to enter the confirmation password
        /// </summary>
        private System.Windows.Forms.TextBox txtStdNewConfirmPassword;

        /// <summary>
        /// A text box to enter the password function.
        /// </summary>
        private System.Windows.Forms.TextBox txtStdNewPassword;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label36;

        /// <summary>
        /// A label
        /// </summary>
        private System.Windows.Forms.Label label35;

        /// <summary>
        /// Button to save new password
        /// </summary>
        private System.Windows.Forms.Button btnSaveNewPassword;

        /// <summary>
        /// Button to cancel the password reset
        /// </summary>
        private System.Windows.Forms.Button btnCancleResetPassword;

        /// <summary>
        /// A group box
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox1;

        /// <summary>
        /// An icon to show when password entries do not match
        /// </summary>
        private System.Windows.Forms.PictureBox newPWDNotMatch;

        /// <summary>
        /// An icon that will appear when signing passwords that were "confirmed" but the password does not match the current string.
        /// </summary>
        private System.Windows.Forms.PictureBox newPWDConfirmWrong;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newPWDNotMatch = new System.Windows.Forms.PictureBox();
            this.newPWDConfirmWrong = new System.Windows.Forms.PictureBox();
            this.currentPWDWrong = new System.Windows.Forms.PictureBox();
            this.newPWD = new System.Windows.Forms.PictureBox();
            this.newPWDConfirmCorrect = new System.Windows.Forms.PictureBox();
            this.pwdCorrect = new System.Windows.Forms.PictureBox();
            this.txtStdPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStdNewConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtStdNewPassword = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.btnSaveNewPassword = new System.Windows.Forms.Button();
            this.btnCancleResetPassword = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPWDNotMatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPWDConfirmWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPWDWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPWD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPWDConfirmCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwdCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newPWDNotMatch);
            this.groupBox1.Controls.Add(this.newPWDConfirmWrong);
            this.groupBox1.Controls.Add(this.currentPWDWrong);
            this.groupBox1.Controls.Add(this.newPWD);
            this.groupBox1.Controls.Add(this.newPWDConfirmCorrect);
            this.groupBox1.Controls.Add(this.pwdCorrect);
            this.groupBox1.Controls.Add(this.txtStdPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStdNewConfirmPassword);
            this.groupBox1.Controls.Add(this.txtStdNewPassword);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.label35);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // newPWDNotMatch
            // 
            this.newPWDNotMatch.Image = global::CoachConnect.Properties.Resources.wrong;
            resources.ApplyResources(this.newPWDNotMatch, "newPWDNotMatch");
            this.newPWDNotMatch.Name = "newPWDNotMatch";
            this.newPWDNotMatch.TabStop = false;
            // 
            // newPWDConfirmWrong
            // 
            this.newPWDConfirmWrong.Image = global::CoachConnect.Properties.Resources.wrong;
            resources.ApplyResources(this.newPWDConfirmWrong, "newPWDConfirmWrong");
            this.newPWDConfirmWrong.Name = "newPWDConfirmWrong";
            this.newPWDConfirmWrong.TabStop = false;
            // 
            // currentPWDWrong
            // 
            this.currentPWDWrong.Image = global::CoachConnect.Properties.Resources.wrong;
            resources.ApplyResources(this.currentPWDWrong, "currentPWDWrong");
            this.currentPWDWrong.Name = "currentPWDWrong";
            this.currentPWDWrong.TabStop = false;
            // 
            // newPWD
            // 
            this.newPWD.Image = global::CoachConnect.Properties.Resources.correct1;
            resources.ApplyResources(this.newPWD, "newPWD");
            this.newPWD.Name = "newPWD";
            this.newPWD.TabStop = false;
            // 
            // newPWDConfirmCorrect
            // 
            this.newPWDConfirmCorrect.Image = global::CoachConnect.Properties.Resources.correct1;
            resources.ApplyResources(this.newPWDConfirmCorrect, "newPWDConfirmCorrect");
            this.newPWDConfirmCorrect.Name = "newPWDConfirmCorrect";
            this.newPWDConfirmCorrect.TabStop = false;
            // 
            // pwdCorrect
            // 
            this.pwdCorrect.Image = global::CoachConnect.Properties.Resources.correct1;
            resources.ApplyResources(this.pwdCorrect, "pwdCorrect");
            this.pwdCorrect.Name = "pwdCorrect";
            this.pwdCorrect.TabStop = false;
            // 
            // txtStdPassword
            // 
            resources.ApplyResources(this.txtStdPassword, "txtStdPassword");
            this.txtStdPassword.Name = "txtStdPassword";
            this.txtStdPassword.Leave += new System.EventHandler(this.TxtStdPasswordLeave);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtStdNewConfirmPassword
            // 
            resources.ApplyResources(this.txtStdNewConfirmPassword, "txtStdNewConfirmPassword");
            this.txtStdNewConfirmPassword.Name = "txtStdNewConfirmPassword";
            this.txtStdNewConfirmPassword.Leave += new System.EventHandler(this.TxtStdNewConfirmPasswordLeave);
            // 
            // txtStdNewPassword
            // 
            resources.ApplyResources(this.txtStdNewPassword, "txtStdNewPassword");
            this.txtStdNewPassword.Name = "txtStdNewPassword";
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.Name = "label36";
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.Name = "label35";
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
            resources.ApplyResources(this.btnCancleResetPassword, "btnCancleResetPassword");
            this.btnCancleResetPassword.Name = "btnCancleResetPassword";
            this.btnCancleResetPassword.UseVisualStyleBackColor = true;
            this.btnCancleResetPassword.Click += new System.EventHandler(this.BtnCancelResetPasswordClick);
            // 
            // ResetMyPassword
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSaveNewPassword);
            this.Controls.Add(this.btnCancleResetPassword);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResetMyPassword";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPWDNotMatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPWDConfirmWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPWDWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPWD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPWDConfirmCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwdCorrect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}