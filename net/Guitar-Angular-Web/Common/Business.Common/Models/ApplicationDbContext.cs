using DataModels.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Business.Common.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Guitars> Guitars { get; set; }

        // Otras entidades y configuraciones aquí
    }
}
