namespace PokemonReviewApp.Interfaces
{
    using PokemonReviewApp.Models;
    using System.Collections.Generic;
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
        Category GetCategory(int id);
        List<Pokemon> GetPokemonByCategory(int categoryId);
        bool CategoryExists(int Id);
        bool CreateCategory(Category category);
        bool UpdateCategory(Category category);
        bool DeleteCategory(Category category);
        bool Save();
    }
}