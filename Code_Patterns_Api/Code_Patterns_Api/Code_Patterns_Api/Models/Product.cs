using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code_Patterns_Api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Imag { get; set; } = null!;
        public string CategoryName { get; set; } = null!;

        public int CategoryId { get; set; }
    }
}
