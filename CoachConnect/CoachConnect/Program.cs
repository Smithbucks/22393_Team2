// <copyright file="Program.cs" company="Adam J. Smith at NWTC">
//     Copyright 2018 Smithbucks Computing (Adam J. Smith, radarsmith83@gmail.com)
// </copyright>
namespace CoachConnect
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The base class for the CoachConnect app
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Gets or sets a mainForm object that is loaded when the program starts
        /// </summary>
        public static MainForm MainForm { get; set; }

        /// <summary>
        /// Gets or sets the username that is logged into the app.
        /// </summary>
        public static string CurrentUser { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is a supervisor.
        /// </summary>
        public static bool IsSupervisor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is an admin.
        /// </summary>
        public static bool IsAdmin { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new MainForm();

            Application.Run(MainForm);
        }

        /// <summary>
        /// Method to handle Logout process
        /// </summary>
        public static void Logout()
        {
            // Clear out all static variables related to user
            Program.CurrentUser = null;
            Program.IsSupervisor = false;
            Program.IsAdmin = false;
        }

        /// <summary>
        /// A method to open a new LoginForm and display it as a dialog.
        /// </summary>
        public static void Login()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
