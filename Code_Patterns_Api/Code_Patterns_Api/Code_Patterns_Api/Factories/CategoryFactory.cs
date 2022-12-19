using Code_Patterns_Api.Interfaces;
using Code_Patterns_Api.Models;
using Code_Patterns_Api.Models.Entities;

namespace Code_Patterns_Api.Factories;

// INTERFACE SEGGREGATION
/// CategoryFactory används för att skapa en instans av Category modellen när man skapar en Category till databas. Detta för att undvika att skapa en instans . En del av "Dependency Inversion Principle"
// Jag har  SRP i det här fallet och delar upp Factory Och ha det lite renare i kontrollern
public interface ICategoryFactory : IFactory
{
    CategoryEntity categoryEntity();
    
    Category category(CategoryEntity categoryEntity);
    List<Category> CategoryList();
}
public class CategoryFactory :ICategoryFactory
{
    public CategoryEntity categoryEntity()
    {
        return new CategoryEntity();
    }
     public Category category(CategoryEntity categoryEntity)
    {
        return new Category
        {
            Name = categoryEntity.Name,
            Imag = categoryEntity.Imag
        };
    }
 
    public List<Category> CategoryList()
    {
        return new List<Category>();
    }
}
