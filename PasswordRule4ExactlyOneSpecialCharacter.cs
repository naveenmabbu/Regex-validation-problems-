using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_Methods_In_Regex
{
    internal class PasswordRule4ExactlyOneSpecialCharacter
    {
        public static string REGEX_Password4 = "^[A-Z]+[A-Z a-z]{5,}[!.*@#$%^&+=][0-9]+$"; //Programing@123

        public bool ValidatePassword4(string password)
        {
            return Regex.IsMatch(password, REGEX_Password4);
        }
    }
}
