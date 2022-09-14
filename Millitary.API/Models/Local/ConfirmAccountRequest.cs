namespace Millitary.API.Models.Local
{
    public class ConfirmAccountRequest
    {
        public string? Email { get; set; }
        public string? ConfirmationCode { get; set; }
    }
}