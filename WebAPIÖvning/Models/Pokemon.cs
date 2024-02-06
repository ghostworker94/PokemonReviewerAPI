namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly Date { get; set; }
        public List<Review> Reviews { get; set; }
        public List<PokemonCategory> PokemonCategories { get; set; }
        public List<PokemonOwner> PokemonOwners { get; set; }
    }
}