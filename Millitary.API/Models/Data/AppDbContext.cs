using Microsoft.EntityFrameworkCore;

namespace RudoRwedu.API.Models.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Role>? Roles { get; set; }
        public DbSet<Account>? Accounts { get; set; }
        public DbSet<GeneratedCode>? GeneratedCodes { get; set; }
        public DbSet<Category>? Category { get; set; }
        public DbSet<Company>? Companies { get; set; }
    }
}