using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementApplication.Classes
{
    public class Member : Membership
    {
        public int MembershipID { get; set; }
        public string MemberName { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Today;
        public DateTime EndDate { get; set; } = DateTime.Today.AddMonths(1);
        public double MembershipFee { get; set; }
        public string FeedBack { get; set; }

        public override double CalculateMembershipFee()
        {
            // Implementation for calculating membership fee
            switch (MembershipType)
            {
                case 1:
                    MembershipFee = 10.0;
                    break;
                case 2:
                    MembershipFee = 20.0;
                    break;
                case 3:
                    MembershipFee = 40.0;
                    break;
                default:
                    MembershipFee = 0.0; // Default value for unknown membership types
                    break;
            }
            return MembershipFee * (EndDate - StartDate).TotalDays;
        }
    }
}
