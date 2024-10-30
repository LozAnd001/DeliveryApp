using DeliveryApp.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryApp.Db
{
    public class DatabaseContext: DbContext
    {
        public DbSet<District> Districts { get; set; }
        public DbSet<Order> Orders { get; set; }
        //public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options) 
        //{
        //    Database.EnsureCreated();
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=;Trusted_Connection=True;");
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=products.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var id1 = Guid.NewGuid();
            var id2 = Guid.NewGuid();
            var id3 = Guid.NewGuid();
            var id4 = Guid.NewGuid();
            var random = new Random();
            modelBuilder.Entity<District>().HasData(
                new District { Id = id1, Name = "Moscow" },
                new District { Id = id2, Name = "Minsc" },
                new District { Id = id3, Name = "Vladivostok" },
                new District { Id = id4, Name = "Murmansk" });

            modelBuilder.Entity<Order>().HasData(
                new Order { Id = Guid.NewGuid(), DistrictId = id1, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now  },
                new Order { Id = Guid.NewGuid(), DistrictId = id1, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id1, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id1, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id1, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id1, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id1, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id1, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id1, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id1, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id2, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id2, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id2, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id2, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id2, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id2, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id2, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id2, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id2, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id2, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id3, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id3, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id3, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id4, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id4, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id4, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id4, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id4, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id4, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id4, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id4, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id4, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now },
                new Order { Id = Guid.NewGuid(), DistrictId = id4, Weight = random.Next() % 100 + 10, OrderDeliveryDate = DateTime.Now, OrderCreationDate = DateTime.Now });
        }

    }
}
