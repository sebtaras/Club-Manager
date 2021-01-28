using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManager.BaseLib
{
    public class ValidationFunctions
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidAge(string text)
        {
            try
            {
                var age = int.Parse(text);
                return age >= 6 && age <= 30;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidName(string[] names)
        {
            foreach(string name in names)
            {
                if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                    return false;
            }
            return true;
        }

        public static bool IsValidPassword(string password)
        {
            return password.Length >= 6;
        }

        public static bool IsValidTrainingDuration(string duration)
        {
            if (!int.TryParse(duration, out int dur))
                return false;
            if (dur < 30 || dur > 120)
                return false;
            return true;
        }
    }
}
