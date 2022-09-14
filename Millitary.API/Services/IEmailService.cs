using Millitary.API.Models.Local;

namespace Millitary.API.Services
{
    public interface IEmailService
    {
        Task<Result<string>> SendEmailAsync(EmailRequest email);
    }
}