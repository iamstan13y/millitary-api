using Millitary.API.Models.Data;
using Millitary.API.Models.Repository.IRepository;

namespace Millitary.API.Models.Repository
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        private readonly AppDbContext _context;

        public RoleRepository(AppDbContext context) : base(context) => _context = context;
    }
}