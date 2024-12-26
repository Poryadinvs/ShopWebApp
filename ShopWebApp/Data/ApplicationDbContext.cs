using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopWebApp.Data.Identity;

namespace ShopWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().Property(z => z.Id).UseIdentityColumn();
            builder.Entity<Product>().Property(z => z.Title).HasMaxLength(50);

            base.OnModelCreating(builder);
        }

        public DbSet<Product> Products { get; set; }
    }
}
