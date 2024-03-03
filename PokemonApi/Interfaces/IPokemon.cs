namespace PokemonReviewApp.Interfaces
{
    using PokemonReviewApp.Models;
    public interface IPokemonRepository
    {
        List<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        decimal GetPokemonRating(int pokeid);
        bool PokemonExists(int pokeid);
        bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon);
        bool UpdatePokemon(Pokemon pokemon);
        bool DeletePokemon(Pokemon pokemon);
        bool Save();
    }
}