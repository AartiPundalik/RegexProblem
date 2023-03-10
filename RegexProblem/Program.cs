using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            RegexProgram regex = new RegexProgram(null);
            regex.ValidateFirstName("Aarti");
            regex.ValidateLastName("Pundalik");
            regex.ValidateEmail("abc.xyz@bl.co.in");
            regex.ValidatePhoneNumber("91 8668285117");
            regex.ValidatePassword("Password");
            regex.ValidateStringPassword("Aarti123");
            regex.ValidateNumericPassword("Aarti689");
            regex.ValidateSpecialCharacter("Aarti#");
            Console.ReadLine();
        }
    }
}
        
    

