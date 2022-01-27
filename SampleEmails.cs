using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_Methods_In_Regex
{
    internal class SampleEmails
    {
        public static string REGEX_SampleEmails = "^[A-Za-z0-9]+([.+#_-][A-Za-z0-9]+)*[@][A-Za-z0-9]+[.][a-z]{2,3}([.][a-z]{2})?$"; //sample email

        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_SampleEmails);
        }
    }
}
