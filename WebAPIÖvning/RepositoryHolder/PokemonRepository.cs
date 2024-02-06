using PokemonReviewApp.Data;
using PokemonReviewApp.Models;
using PokemonReviewApp.Interfaces;

namespace PokemonReviewApp.RepositoryHolder
{
    public class PokemonRepostiroty : IPokemonRepository
    {
        private readonly DatabaseContext _context;

        public PokemonRepostiroty(DatabaseContext context)
        {
            _context = context;
        }

        public bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon)
        {
            var pokemonOwnerEntity = _context.Owners.Where(o => o.Id == ownerId).FirstOrDefault();
            var pokemonCategoryEntity = _context.Categories.Where(c => c.Id == categoryId).FirstOrDefault();
            var pokemonOwner = new PokemonOwner()
            {
                Owner = pokemonOwnerEntity,
                Pokemon = pokemon,
            };
            _context.Add(pokemonOwner);
            var pokemonCategory = new PokemonCategory()
            {
                Category = pokemonCategoryEntity,
                Pokemon = pokemon,
            };
            _context.Add(pokemonCategory);

            _context.Add(pokemon);
            return Save();
        }

        public bool DeletePokemon(Pokemon pokemon)
        {
            _context.Remove(pokemon);
            return Save();
        }

        public Pokemon GetPokemon(int id)
        {
            return _context.Pokemon.Where(p => p.Id == id).FirstOrDefault();
        }

        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemon.Where(p => p.Name == name).FirstOrDefault();
        }

        public decimal GetPokemonRating(int pokeid)
        {
            var review = _context.Reviews.Where(p => p.Pokemon.Id == pokeid);
            if (review.Count() <= 0)
            {
                return 0;
            }
            return (decimal)review.Sum(p => p.Rating) / review.Count();
        }

        public List<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }

        public bool PokemonExists(int pokeid)
        {
            return _context.Pokemon.Any(p => p.Id == pokeid);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdatePokemon(Pokemon pokemon)
        {
            _context.Update(pokemon);
            return Save();
        }
    }
}