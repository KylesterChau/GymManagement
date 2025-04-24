using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Exceptions
{
   public class InvalidInputException : Exception
    {
        public InvalidInputException(string message) : base(message)
        {
        }

        public static InvalidInputException FieldsCannotBeNull()
        {
            return new InvalidInputException("Fields cannot be null.");
        }
    }
}
   
