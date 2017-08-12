namespace Vpms.Data
{
    using Microsoft.EntityFrameworkCore;
    using Vpms.Model.Entities;
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<User> User { get; set; }
    }
}
