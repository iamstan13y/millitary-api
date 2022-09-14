using Millitary.API.Models.Data;

namespace Millitary.API.Services
{
    public interface IJwtService
    {
        Task<string> GenerateToken(Account account);
    }
}