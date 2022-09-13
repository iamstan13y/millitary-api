using Millitary.API.Models.Data;
using RudoRwedu.API.Models.Repository.IRepository;

namespace RudoRwedu.API.Models.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context) : base(context) => _context = context;
    }
}