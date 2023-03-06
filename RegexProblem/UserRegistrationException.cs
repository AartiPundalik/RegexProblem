using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class UserRegistrationException:Exception
    {
        public enum ExceptionType
        {
            Null_FIRSTNAME,
            
        }
        public ExceptionType Type;

        public UserRegistrationException(ExceptionType Type,string message ): base (message)
        {
            this.Type = Type;
        }
    }
}
