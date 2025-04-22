using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementApplication.Classes
{
    class Member : Membership
    {
        public int MembershipID { get; set; }
        public string MemberName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double MembershipFee { get; set; }

        public Member(int membershipID, string memberName, DateTime startDate, DateTime endDate, double membershipFee)
        {
            MembershipID = membershipID;
            MemberName = memberName;
            StartDate = startDate;
            EndDate = endDate;
            MembershipFee = membershipFee;
        }

        protected override double CalculateMembershipFee()
        {
            // Implementation for calculating membership fee  
            return 0.0; // Placeholder return value  
        }
    }
}
