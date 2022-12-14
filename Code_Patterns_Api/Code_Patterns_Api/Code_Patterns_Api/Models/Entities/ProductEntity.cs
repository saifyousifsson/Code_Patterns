using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code_Patterns_Api.Models.Entities
{
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        [Column(TypeName ="money")]
        public decimal Price { get; set; }
        public string Imag { get; set; } = null!;
        public int CategoryId { get; set; }
        public virtual CategoryEntity Category { get; set; }
    }
}
