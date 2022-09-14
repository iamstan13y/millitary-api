using Millitary.API.Models.Data;
using Millitary.API.Models.Local;

namespace Millitary.API.Models.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Soldier>
    {
        Task<Result<Soldier>> GetByAccountId(int accountId);
    }
}