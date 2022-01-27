using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_Methods_In_Regex
{
    internal class PasswordRule3AtLeastOneNumericNumber
    {
        public static string REGEX_Password3 = "^[A-Z]+[A-Z a-z]{6,}[0-9]+$";  //Programing123

        public bool ValidatePassword3(string password)
        {
            return Regex.IsMatch(password, REGEX_Password3);
        }
    }
}
