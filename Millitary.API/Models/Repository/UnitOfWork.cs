using Millitary.API.Models.Data;
using Millitary.API.Models.Repository.IRepository;

namespace Millitary.API.Models.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IRoleRepository Role { get; private set; }
        public ISoldierRepository Soldier { get; private set; }
        public ICategoryRepository Category { get; private set; }

        public UnitOfWork(AppDbContext context)
        {
            Role = new RoleRepository(context);
            Soldier = new SoldierRepository(context);
            Category = new CategoryRepository(context);
            _context = context;
        }

        public void SaveChanges() => _context.SaveChanges();
    }
}