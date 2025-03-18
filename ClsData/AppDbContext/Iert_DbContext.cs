using ClsData.Models;
using Microsoft.EntityFrameworkCore;
namespace ClsData.AppDbContext
{
    public class Iert_DbContext : DbContext
    {

        public Iert_DbContext(DbContextOptions<Iert_DbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Basic_details> basic_Details { get; set; }
        public DbSet<Address> address { get; set; }

    }

}
