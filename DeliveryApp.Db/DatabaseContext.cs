using DeliveryApp.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryApp.Db
{
    public class DatabaseContext: DbContext
    {
        public DbSet<District> Districts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options) 
        { 
            Database.EnsureCreated();
        }
    }
}
