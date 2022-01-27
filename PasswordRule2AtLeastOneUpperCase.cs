using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_Methods_In_Regex
{
    internal class PasswordRule2AtLeastOneUpperCase
    {
        public static string REGEX_Password2 = "^[A-Z]+[A-Z a-z]{7,}$"; //Programing

        public bool ValidatePassword2(string password)
        {
            return Regex.IsMatch(password, REGEX_Password2);
        }
    }
}
