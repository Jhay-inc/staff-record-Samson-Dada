using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StaffRecord
{
    public static class Validate
    {
        public static bool ValidateEmail(string email)
        {
            Regex regex = new Regex(@"^[\w-\.]+[\w]@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(email);
        }
        public static bool ValidatePassoword(string password)
        {
            if (password.Length < 4 || password.Length > 10 || password.EndsWith(" "))
                return false;
            if (password.Contains(" "))
            {
                return false;
            }
            password.Trim();
            return true;
        }

        public static string ValidateUserName(string validateStr)
        {
            if (string.IsNullOrEmpty(validateStr))
            {
                return string.Empty;
            }
            return char.ToUpper(validateStr[0]) + validateStr.Substring(1);
        }
        public static SecureString PassowrdEncrypt()
        {
            var  passString = new SecureString();
            //passwordStr = passString;

           
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);
                if (!char.IsControl(keyInfo.KeyChar))
                {
                    passString.AppendChar(keyInfo.KeyChar);
                    Console.Write("*");
                }


                else if (keyInfo.Key == ConsoleKey.Backspace && passString.Length > 0)
                {
                    passString.RemoveAt(passString.Length - 1);
                    Console.Write("\b \b");

                }
            }
            while (keyInfo.Key != ConsoleKey.Enter);
            return passString;
        }
    }
}

