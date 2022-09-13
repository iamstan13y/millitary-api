using Microsoft.EntityFrameworkCore;
using RudoRwedu.API.Models.Data;
using RudoRwedu.API.Models.Local;
using RudoRwedu.API.Models.Repository.IRepository;

namespace RudoRwedu.API.Models.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly AppDbContext _context;

        public CompanyRepository(AppDbContext context) : base(context) => _context = context;

        public async Task<Result<Company>> GetByAccountId(int accountId)
        {
            var company = await _context.Companies!.Where(x => x.AccountId == accountId).FirstOrDefaultAsync();
            if (company == null) return new Result<Company>(false, "Company not found.");

            return new Result<Company>(company);
        }

        public async Task<Result<IEnumerable<Company>>> GetByCategoryIdAsync(int categoryId)
        {
            var companies = await _context.Companies!.ToListAsync();
            return new Result<IEnumerable<Company>>(companies);
        }
    }
}