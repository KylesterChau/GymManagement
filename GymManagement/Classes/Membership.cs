using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementApplication.Classes
{
    abstract class Membership
    {
        int membershipID { get; set; }
        string memberName { get; set; }
        DateTime startDate { get; set; }
        DateTime endDate { get; set; }
        double membershipFee { get; set; }

 
        protected abstract double CalculateMembershipFee();
        protected virtual string GetMembershipDetails()
        {
            return $"Membership ID: {membershipID}\n" +
                   $"Member Name: {memberName}\n" +
                   $"Start Date: {startDate.ToShortDateString()}\n" +
                   $"Membership Fee: {membershipFee:C}";
        }
}
}
