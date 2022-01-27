using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_Methods_In_Regex
{
    public class CheckEmail
    {

        public static string REGEX_EMail = "^[A-Za-z0-9]+([.+#_-][A-Za-z0-9]+)*[@][A-Za-z0-9]+[.][a-z]{2,3}([.][a-z]{2})?"; //abc.xyz@bl.co.in

        public bool ValidateEMail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMail);
        }
    }
  
}

