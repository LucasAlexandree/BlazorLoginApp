using BlazorLoginApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorLoginApp.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
