namespace UserDetails.Models
{
    public class User
    {
        public int UserId { get;set; }
        public string FirstName { get;set; }
        public string LastName { get;set; }
        public string EmailId { get;set; }
        public string Address { get;set; }
        public DateOnly DateOfBirth { get;set; }

    }
}
