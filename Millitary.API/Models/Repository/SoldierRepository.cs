using Millitary.API.Models.Data;
using Millitary.API.Models.Local;
using Millitary.API.Models.Repository.IRepository;

namespace Millitary.API.Models.Repository
{
    public class SoldierRepository : Repository<Soldier>, ISoldierRepository
    {
        private readonly AppDbContext _context;

        public SoldierRepository(AppDbContext context) : base(context) => _context = context;

        public async Task<Result<Soldier>> GetByAccountId(int accountId)
        {
            var company = await _context.Soldiers!.Where(x => x.AccountId == accountId).FirstOrDefaultAsync();
            if (company == null) return new Result<Soldier>(false, "Company not found.");

            return new Result<Soldier>(company);
        }
    }
}