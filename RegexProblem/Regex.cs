using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static RegexProblem.UserRegistrationException;

namespace RegexProblem
{
    public class RegexProgram
    {
        string message;

        public RegexProgram(string message)
        {
            this.message = message;
        }
        public string ValidateFirstName(string name)
        {
            //Aarti
            string FirstName = "^[A-Z][a-z]{3,}?";
            try
            {
                if (Regex.IsMatch(name, FirstName))
                {
                    Console.WriteLine("First Name is Matching with regex");
                }
                else
                {
                    Console.WriteLine("First Name is not Matching with regex");
                }
                return name;
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(ExceptionType.Null_FIRSTNAME, "Please do not Enter the Null Input");
            }

        }
        public string ValidateLastName(string name)
        {
            //Pundalik
            string lastName = "^[A-Z][a-z]{3,}?";
            try
            {
                if (Regex.IsMatch(name, lastName))
                {
                    Console.WriteLine("Last name is matching with Regex");
                }
                else
                {
                    Console.WriteLine("Last Name is not matching with Regex");
                }
                return name;
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(ExceptionType.Null_LASTNAME, "Please do not Enter the Null Input");
            }


        }
        public string ValidateEmail(string email)
        {
            //abc.xyz@bridgelabz.co.in
            string emailID = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
            try
            {

                if (Regex.IsMatch(email, emailID))
                {
                    Console.WriteLine("Email id is matching with Regex");
                }
                else
                {
                    Console.WriteLine("Email is not matching with Regex");
                }
                return email;
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(ExceptionType.Null_EMAIL_ID, "Please do not Enter the Null Input");
            }
        }

        public string ValidatePhoneNumber(string phoneNumber)
        {
            //"91 0127131236"
            string phoneNum = @"[0-9]{2}[ ][0-9]{10}";
            try
            {
                if (Regex.IsMatch(phoneNumber, phoneNum))
                {
                    Console.WriteLine("Phone Number is matching with regex");
                }
                else
                {
                    Console.WriteLine("Phone Number is not matching with Regex ");
                }
                return phoneNumber;
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(ExceptionType.Null_PHONENUMBER, "Please do not Enter the Null Input");
            }
        }

        public string ValidatePassword(string pswrd)
        {
            string password = @"[A-Z]{1}[a-z0-9]";
            try
            {
                if (Regex.IsMatch(pswrd, password))
                {
                    Console.WriteLine("Password is matching with Regex");
                }
                else
                {
                    Console.WriteLine("Password is not matching with Regex");
                }
                return pswrd;
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(ExceptionType.Null_PASSWORD, "Please do not Enter the Null Input");
            }

        }
        public string ValidateStringPassword(string numPassword)
        {
            string password = "[A-Z]{1,}[a-z0-9]";
            try
            {
                if (Regex.IsMatch(numPassword, password))
                {
                    Console.WriteLine("Numeric Password is matching with Regex");
                }
                else
                {
                    Console.WriteLine("Numeric password is not matching with Regex");
                }
                return numPassword;
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(ExceptionType.Null_STRINGPASSWORD, "Please do not Enter the Null Input");
            }

        }

        public string ValidateNumericPassword(string numPassword)
        {
            string password = "[a-zA-Z][0-9]{1,}";
            try
            {
                if (Regex.IsMatch(numPassword, password))
                {
                    Console.WriteLine("Numeric Password is matching with Regex");
                }
                else
                {
                    Console.WriteLine("Numeric password is not matching with Regex");
                }
                return numPassword;
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(ExceptionType.Null_NUMERICPASSWORD, "Please do not Enter the Null Input");
            }

        }
        public string ValidateSpecialCharacter(string character)
        {
            string spclChar = "[0-9a-zA-Z][!@#$%&*]{1}";
            try
            {
                if (Regex.IsMatch(character, spclChar))
                {
                    Console.WriteLine("Special Character is matched with Regex");
                }
                else
                {
                    Console.WriteLine("Special Character is not matched with Regex");
                }
                return character;
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(ExceptionType.Null_SPECIALCHARACTER, "Please do not Enter the Null Input");
            }

        }
    }
}







    


