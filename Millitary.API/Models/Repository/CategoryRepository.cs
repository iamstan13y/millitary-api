using Millitary.API.Models.Data;
using Millitary.API.Models.Repository.IRepository;

namespace Millitary.API.Models.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context) : base(context) => _context = context;
    }
}