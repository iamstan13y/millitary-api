using RudoRwedu.API.Models.Data;
using RudoRwedu.API.Models.Local;

namespace RudoRwedu.API.Models.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        Task<Result<Company>> GetByAccountId(int accountId);
        Task<Result<IEnumerable<Company>>> GetByCategoryIdAsync(int categoryId);
    }
}