using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IOwner
    {
        Owner GetOwner(int id);
        List<Owner> GetOwners();
        List<Owner> GetOwnerOfAPokemon(int pokeId);
        List<Pokemon> GetPokemonByOwner(int ownerId);
        bool OwnerExists(int Id);
        bool CreateOwner(Owner owner);
        bool UpdateOwner(Owner owner);
        bool DeleteOwner(Owner owner);
        bool Save();
    }
}