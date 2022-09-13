using RudoRwedu.API.Models.Data;
using RudoRwedu.API.Models.Local;

namespace RudoRwedu.API.Services
{
    public interface IEmailService
    {
        Task<Result<string>> SendEmailAsync(EmailRequest email);
    }
}