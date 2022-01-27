using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_Methods_In_Regex
{
    internal class PasswordRule1Min8Char
    {

		public static string REGEX_Password1 = "^[A-Z a-z]{8,}$";    //programing (or) naninaveen or any letter which have more than 8 char

		public bool ValidatePassword1(string password)
		{
			return Regex.IsMatch(password, REGEX_Password1);
		}
	}
}
