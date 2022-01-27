using UserRegistration_Methods_In_Regex;

Console.WriteLine("Welcome to Regex Program  \n");

#region FirstName
FirstName firstName = new FirstName();
if (firstName.ValidateFirstName("Naveen"))
{
    Console.WriteLine("The First Name is Valid");
}
else
    Console.WriteLine("The First Name is Invalid");
#endregion

#region LastName
LastName lastName = new LastName();
if (lastName.ValidateLastName("Mabbu"))
{
    Console.WriteLine("The Last Name is Valid");
}
else
    Console.WriteLine("The Last Name is Invalid");
#endregion

#region Valid_Email
CheckEmail checkEmail = new CheckEmail();
if (checkEmail.ValidateEMail("abc.xyz@bl.co.in"))
{
    Console.WriteLine("The Email is Valid");
}
else
    Console.WriteLine("The Email is Invalid");
#endregion

#region MobileFormate
MobileNumberFormate mobileFormate = new MobileNumberFormate();
if (mobileFormate.ValidateMobileNo("91 7660962370"))
{
    Console.WriteLine("The Mobile Number is Valid");
}
else
    Console.WriteLine("The Mobile Number is Invalid");
#endregion

#region Password1_Minimum 8 Character
PasswordRule1Min8Char Min8Char = new PasswordRule1Min8Char();
if (Min8Char.ValidatePassword1("programing"))
{
    Console.WriteLine("The Password1 is Valid");
}
else
    Console.WriteLine("The Password1 is Invalid");
#endregion

#region Password2_AtLeastOneUpperCase
PasswordRule2AtLeastOneUpperCase AtLeastOneUpperCase = new PasswordRule2AtLeastOneUpperCase();
if (AtLeastOneUpperCase.ValidatePassword2("Programing"))
{
    Console.WriteLine("The Password2 is Valid");
}
else
    Console.WriteLine("The Password2 is Invalid");
#endregion

#region Password3_AtLeastOneNumericNumber
PasswordRule3AtLeastOneNumericNumber AtLeastOneNumericNumber = new PasswordRule3AtLeastOneNumericNumber();
if (AtLeastOneNumericNumber.ValidatePassword3("Proraming123"))
{
    Console.WriteLine("The Password3 is Valid");
}
else
    Console.WriteLine("The Password3 is Invalid");
#endregion

#region Password4_ExactlyOneSpecialCharacter
PasswordRule4ExactlyOneSpecialCharacter ExactlyOneSpecialCharacter = new PasswordRule4ExactlyOneSpecialCharacter();
if (ExactlyOneSpecialCharacter.ValidatePassword4("Programing@123"))
{
    Console.WriteLine("The Password4 is Valid");
}
else
    Console.WriteLine("The Password4 is Invalid");
#endregion

#region Check_SampleEmails
SampleEmails sampleEmails = new SampleEmails();
if (sampleEmails.ValidateEmail("abc@gmail.com.in"))
{
    Console.WriteLine("The Sample Email is Valid");
}
else
    Console.WriteLine("The Sample Email is Invalid");
#endregion