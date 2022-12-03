using System.ComponentModel.DataAnnotations;

namespace Code_Patterns_Api.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Imag { get; set; } = null!;
    }
}
