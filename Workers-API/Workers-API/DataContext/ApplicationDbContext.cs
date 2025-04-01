using Microsoft.EntityFrameworkCore;
using Workers_API.Models;

namespace Workers_API.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }

        public DbSet<WorkerModel> Workers { get; set; }
    }
}
