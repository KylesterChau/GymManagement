using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementApplication.Classes
{
    class Member : Membership
    {
        int membershipID { get; set; }
        string memberName { get; set; }
        DateTime startDate { get; set; }
        double membershipFee { get; set; }

        protected override double CalculateMembershipFee()
        {
            // Implementation for calculating membership fee
            return 0.0; // Placeholder return value
        }
    }
}
