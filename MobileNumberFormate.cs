using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_Methods_In_Regex
{
    internal class MobileNumberFormate
    {
        public static string REGEX_MobileNo = "^[0-9]{1,3}[ ][6-9][0-9]{9}$"; // 91 7660962370

        public bool ValidateMobileNo(string MobileNo)
        {
            return Regex.IsMatch(MobileNo, REGEX_MobileNo);
        }
    }
}
