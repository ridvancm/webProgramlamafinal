using Microsoft.EntityFrameworkCore;
using webProgramlamafinal.Models;

namespace webProgramlamafinal.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Recipie> Recipies { get; set; } // Recipe tablosu
        public DbSet<Admin> Admins { get; set; }   // Admin tablosu
       //public DbSet<webProgramlamafinal.Models.Recipie> Recipie { get; set; } = default!;
    }
}
