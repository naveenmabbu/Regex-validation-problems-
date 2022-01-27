using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration_Methods_In_Regex
{
    internal class LastName
    {
        public static string LAST_NAME_REGEX = "^[A-Z][a-z]{2,}$";  //Mabbu

        public bool ValidateLastName(string lName)
        {
            return Regex.IsMatch(lName, LAST_NAME_REGEX);
        }
    }
}
