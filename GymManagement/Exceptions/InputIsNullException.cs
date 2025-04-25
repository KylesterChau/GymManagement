using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Exceptions
{
   public class InputIsNullException : Exception
    {
        public InputIsNullException() : base("Fields cannot be null.")
        {
        }
    }
}
   
