namespace Millitary.API.Models.Local
{
    public class AccountRequest
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? NationalId { get; set; }
        public string? ForceId { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public int RoleId { get; set; }
    }
}