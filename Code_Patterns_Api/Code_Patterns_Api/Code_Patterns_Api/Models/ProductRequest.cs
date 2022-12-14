using System.ComponentModel.DataAnnotations;

namespace Code_Patterns_Api.Models
{
    public class ProductRequest
    {
 
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Imag { get; set; } = null!;
        public int  CategoryId  {get; set;}
    }
}
