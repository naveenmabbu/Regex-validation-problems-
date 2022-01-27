using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration_Methods_In_Regex
{
    internal class FirstName
    {

        public bool ValidateFirstName(string fName)
        {
            string FIRST_NAME_REGEX = "^[A-Z][a-z]{2,}$";//Naveen

            return Regex.IsMatch(fName, FIRST_NAME_REGEX);
        }
    }
}
