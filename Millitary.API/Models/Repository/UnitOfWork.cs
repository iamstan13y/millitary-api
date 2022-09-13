using RudoRwedu.API.Models.Data;
using RudoRwedu.API.Models.Repository.IRepository;

namespace RudoRwedu.API.Models.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IRoleRepository Role { get; private set; }
        public ICompanyRepository Company { get; private set; }
        public ICategoryRepository Category { get; private set; }

        public UnitOfWork(AppDbContext context)
        {
            Role = new RoleRepository(context);
            Company = new CompanyRepository(context);
            Category = new CategoryRepository(context);
            _context = context;
        }

        public void SaveChanges() => _context.SaveChanges();
    }
}