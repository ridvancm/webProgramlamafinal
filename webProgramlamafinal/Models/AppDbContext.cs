using Microsoft.EntityFrameworkCore;

namespace webProgramlamafinal.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Recipes tablosu için DbSet
        public DbSet<Recipe> Recipes { get; set; }  // Recipe modelini DbSet olarak ekliyoruz

        // Diğer DbSet'ler
        public DbSet<UserModel> Users { get; set; }
    }
}
