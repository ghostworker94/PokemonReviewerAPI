using System.Collections.Generic;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;
using System.Linq;
using PokemonReviewApp.Data;

namespace PokemonReviewApp.RepositoryHolder;


public class CategoryRepository : ICategoryRepository
{
    private readonly DatabaseContext _context;
    public CategoryRepository(DatabaseContext context)
    {
        _context = context;
    }
    public List<Category> GetCategories()
    {
        return _context.Categories.OrderBy(c => c.PokemonCategories).ToList();
    }
    public Category GetCategory(int id)
    {
        return _context.Categories.Where(p => p.Id == id).FirstOrDefault();
    }
    public bool CategoryExists(int Id)
    {
        return _context.Categories.Any(c => c.Id == Id);
    }

    public List<Pokemon> GetPokemonByCategory(int categoryId)
    {
        return _context.PokemonCategories.Where(p => p.CategoryId == categoryId).Select(p => p.Pokemon).ToList();
    }
    public bool CreateCategory(Category category)
    {
        _context.Add(category);
        return Save();
    }
    public bool UpdateCategory(Category category)
    {
        _context.Update(category);
        return Save();
    }
    public bool DeleteCategory(Category category)
    {
        _context.Remove(category);
        return Save();
    }
    public bool Save()
    {
        return _context.SaveChanges() > 0;
    }
}
