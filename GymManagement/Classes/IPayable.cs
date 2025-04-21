using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementApplication.Classes
{
    interface IPayable
    {
        public void processPayment(double amount);
    }
}
