using RudoRwedu.API.Models.Data;

namespace RudoRwedu.API.Services
{
    public interface IJwtService
    {
        Task<string> GenerateToken(Account account);
    }
}