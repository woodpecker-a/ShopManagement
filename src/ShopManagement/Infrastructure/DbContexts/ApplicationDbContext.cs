using Infrastructure.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DbContexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid,
        ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin, ApplicationRoleClaim, ApplicationUserToken>, IApplicationDbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public ApplicationDbContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString,
                    b => b.MigrationsAssembly(_migrationAssemblyName)
                );
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductDetail>().ToTable("ProductDetails");
            modelBuilder.Entity<Brand>().ToTable("Brands");
            modelBuilder.Entity<Catagory>().ToTable("Catagories");
            modelBuilder.Entity<Color>().ToTable("Colors");
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Model>().ToTable("Models");
            modelBuilder.Entity<Pricing>().ToTable("Pricings");
            modelBuilder.Entity<ProductDetail>().ToTable("ProductDetails");
            modelBuilder.Entity<PurchaseHistory>().ToTable("PurchaseHistories");
            modelBuilder.Entity<Shopkeeper>().ToTable("Shopkeepers");
            modelBuilder.Entity<Size>().ToTable("Size");
            modelBuilder.Entity<Unit>().ToTable("Unit");
            modelBuilder.Entity<Varient>().ToTable("Varient");
            modelBuilder.Entity<WareHouse>().ToTable("WareHouses");
            modelBuilder.Entity<ProductWarehouse>().ToTable("ProductWarehouses");

            modelBuilder.Entity<ProductWarehouse>()
                .HasOne(w => w.Product)
                .WithMany(w => w.WarehouseList)
                .HasForeignKey(k => k.ProductId);

            modelBuilder.Entity<ProductWarehouse>()
                .HasOne(w => w.Warehouse)
                .WithMany(w => w.Products)
                .HasForeignKey(k => k.WarehouseId);

            modelBuilder.Entity<Pricing>()
                .HasOne(p => p.Product)
                .WithOne(pp => pp.Price)
                .HasForeignKey<Product>(k => k.PriceId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductDetail)
                .WithOne(q => q.Product)
                .HasForeignKey<ProductDetail>(k => k.ProductId);

            modelBuilder.Entity<ProductDetail>()
                .HasOne(p => p.PurchaseHistory)
                .WithOne(p => p.Product)
                .HasForeignKey<PurchaseHistory>(k => k.Id);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
    }
}
