using Code_Patterns_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Code_Patterns_Api.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
