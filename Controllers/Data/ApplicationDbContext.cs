using Microsoft.EntityFrameworkCore;
using MiPrimerAPI.Controllers.Models;

namespace MiPrimerAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
