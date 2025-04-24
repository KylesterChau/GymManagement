namespace GymManagementApplication.Classes
{
    public abstract class Membership
    {
        public int MembershipID { get; set; }
        public string MemberName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double MembershipFee { get; set; }
        public int MembershipType { get; set; }

        public abstract double CalculateMembershipFee();
    }
}
