using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using webProgramlamafinal.Models;
=======
>>>>>>> 8f551b7e3f831ba531a1ab7651b3d6515c475515

namespace webProgramlamafinal.Models
{
    public class AppDbContext : DbContext
    {
<<<<<<< HEAD
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Recipie> Recipies { get; set; } // Recipe tablosu
        public DbSet<Admin> Admins { get; set; }   // Admin tablosu
       //public DbSet<webProgramlamafinal.Models.Recipie> Recipie { get; set; } = default!;
=======
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Recipes tablosu için DbSet
        public DbSet<Recipe> Recipes { get; set; }  // Recipe modelini DbSet olarak ekliyoruz

        // Diğer DbSet'ler
        public DbSet<UserModel> Users { get; set; }
>>>>>>> 8f551b7e3f831ba531a1ab7651b3d6515c475515
    }
}
