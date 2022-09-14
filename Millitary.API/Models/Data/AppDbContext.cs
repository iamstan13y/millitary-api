using Microsoft.EntityFrameworkCore;

namespace Millitary.API.Models.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Role>? Roles { get; set; }
        public DbSet<Account>? Accounts { get; set; }
        public DbSet<GeneratedCode>? GeneratedCodes { get; set; }
        public DbSet<AmmoDispatch>? AmmoDispatches { get; set; }
        public DbSet<Ammunition>? Ammunitions { get; set; }
        public DbSet<Soldier>? Soldiers { get; set; }
    }
}