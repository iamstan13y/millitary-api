namespace RudoRwedu.API.Models.Local
{
    public class ResetPasswordRequest
    {
        public string? UserEmail { get; set; }
        public string? VerificationCode { get; set; }
        public string? NewPassword { get; set; }
    }
}