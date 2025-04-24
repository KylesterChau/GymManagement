using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Exceptions
{
   public class InputIsNullException : Exception
    {
        public InputIsNullException(string message) : base(message)
        {
        }

        public static InputIsNullException FieldsCannotBeNull()
        {
            return new InputIsNullException("Fields cannot be null.");
        }
    }
}
   
