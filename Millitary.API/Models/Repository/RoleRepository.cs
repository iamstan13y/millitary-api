using RudoRwedu.API.Models.Data;
using RudoRwedu.API.Models.Repository.IRepository;

namespace RudoRwedu.API.Models.Repository
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        private readonly AppDbContext _context;

        public RoleRepository(AppDbContext context) : base(context) => _context = context;
    }
}