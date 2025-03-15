using ClsCommon.User;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace ClsCommon.Db_Context
{
    public class Iert_dbContext : IdentityDbContext<AppUser>
    {
        public Iert_dbContext(DbContextOptions<Iert_dbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }

}
