using Code_Patterns_Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Code_Patterns_Api.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<CategoryEntity> categories { get; set; }
        public DbSet<ProductEntity> products { get; set; }
    }
}
