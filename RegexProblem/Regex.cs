﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexProblem
{
    public class RegexProgram
    {
        public void ValidateFirstName(string name)
        {
            //Aarti
            string FirstName = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(name, FirstName))
            {
                Console.WriteLine("First Name is Matching with regex");
            }
            else
            {
                Console.WriteLine("First Name is not Matching with regex");
            }

        }

    }
}

