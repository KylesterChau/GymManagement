namespace GymManagementApplication.Classes
{
    public abstract class Membership
    {
        protected Membership(int membershipID, string memberName, DateTime startDate, DateTime endDate, double membershipFee)
        {
            MembershipID = membershipID;
            MemberName = memberName;
            StartDate = startDate;
            EndDate = endDate;
            MembershipFee = membershipFee;
        }

        protected int MembershipID { get; set; }
        protected string MemberName { get; set; }
        protected DateTime StartDate { get; set; }
        protected DateTime EndDate { get; set; }
        protected double MembershipFee { get; set; }

        protected abstract double CalculateMembershipFee();

        protected virtual string GetMembershipDetails()
        {
            return $"Membership ID: {MembershipID}\n" +
                   $"Member Name: {MemberName}\n" +
                   $"Start Date: {StartDate.ToShortDateString()}\n" +
                   $"Membership Fee: {MembershipFee:C}";
        }
    }
}
