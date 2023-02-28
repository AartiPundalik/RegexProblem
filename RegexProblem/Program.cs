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
            RegexProgram regex = new RegexProgram();
            regex.ValidateFirstName("Aarti");
            regex.ValidateLastName("Pundalik");
            regex.ValidateEmail("abc.xyz@bl.co.in");
            Console.ReadLine();
        }
    }
}
        
    

