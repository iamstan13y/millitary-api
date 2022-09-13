namespace RudoRwedu.API.Models.Local
{
    public class AccountRequest
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CompanyName { get; set; }
        public int CategoryId { get; set; }
        public string? Location { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public int RoleId { get; set; }
    }
}