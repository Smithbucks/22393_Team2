// <copyright file="Validation.cs" company="Adam J. Smith at NWTC">
//     Copyright 2018 Smithbucks Computing (Adam J. Smith, radarsmith83@gmail.com)
// </copyright>
namespace CoachConnect
{
    using System.Linq;

    /// <summary>
    /// Validation of textboxes
    /// Standard Text along with Phone and Email
    /// also allows for formatting of phone
    /// </summary>
    public class Validation
    {
        /// <summary>
        /// Validates Standard Name Textbox
        /// </summary>
        /// <param name="tb">incoming string</param>
        /// <returns>boolean if valid name</returns>
         public bool ValidateTextBox(string tb)
        {
            if (string.IsNullOrEmpty(tb) || !tb.Trim().All(char.IsLetter))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Validates email address. Uses built in function in Visual Studio
        /// </summary>
        /// <param name="tb">String argument to be assessed</param>
        /// <returns>returns boolean if valid email</returns>
        public bool ValidateEmail(string tb)
        {
            try
            {
                var emailAddress = new System.Net.Mail.MailAddress(tb);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Validates that the phone number is 10 characters
        /// gets cleaned up before coming here
        /// </summary>
        /// <param name="tb">Incoming String to be assessed</param>
        /// <returns>return boolean value of valid string</returns>
        public bool ValidatePhone(string tb)
        {
            return tb.Length == 10;
        }

        /// <summary>
        /// Verify if selected index is -1 and no values
        /// are put into Combo box
        /// </summary>
        /// <param name="selectedIndex">past the currently selected index</param>
        /// <returns>returns boolean dependent on if something is selected</returns>
        public bool ValidateComboBox(int selectedIndex)
        {
            return selectedIndex != -1;
        }

        /// <summary>
        /// Trim spaces off name, set to lowercase and just capitalized the first letter
        /// </summary>
        /// <param name="dirty">incoming string that is untouched</param>
        /// <returns>trimmed name properly formatted</returns>
        public string CleanString(string dirty)
        {
            string clean = dirty.Trim();
            return clean.Length > 1 ? char.ToUpper(clean[0]) + clean.Substring(1).ToLower() : clean.ToUpper();
        }

        /// <summary>
        /// Removes digits from string and returns just the numbers
        /// </summary>
        /// <param name="dirty">Incoming Phone number not edited</param>
        /// <returns>Numbers without non digit characters</returns>
        public string CleanNumber(string dirty)
        {
            string clean = string.Empty;
            foreach (char num in dirty)
            {
                if (char.IsDigit(num))
                {
                    clean += num.ToString();
                }
            }

            return clean;
        }

        /// <summary>
        /// format phone for easier viewing
        /// </summary>
        /// <param name="phone">just the 10 digits </param>
        /// <returns>returns string properly formatted</returns>
        public string FormatPhone(string phone)
        {
            string formatPhone = "(" + phone.Substring(0, 3) + ")" + phone.Substring(3, 3) + "-" + phone.Substring(6, 4);
            return formatPhone; 
        }
    }
}
