using Hostit.Models;
using Microsoft.EntityFrameworkCore;

namespace Hostit.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
    }
}
