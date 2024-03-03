using PokemonReviewApp.Data;
using PokemonReviewApp.Models;

namespace PokemonReviewApp
{
    public class Seed
    {
        private readonly DatabaseContext _dataContext;
        public Seed(DatabaseContext context)
        {
            _dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!_dataContext.PokemonOwners.Any())
            {
                var pokemonOwners = new List<PokemonOwner>()
                {
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Pikachu",
                            Date = new DateOnly(1903,1,1),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Electric"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Pikachu",Text = "Pickahu is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Pikachu", Text = "Pickachu is the best a killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Pikachu",Text = "Pickchu, pickachu, pikachu", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Jack",
                            LastName = "London",
                            Gym = "Brocks Gym",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Squirtle",
                            Date = new DateOnly(1903,1,1),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Water"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title= "Squirtle", Text = "squirtle is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title= "Squirtle",Text = "Squirtle is the best a killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title= "Squirtle", Text = "squirtle, squirtle, squirtle", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Harry",
                            LastName = "Potter",
                            Gym = "Mistys Gym",
                            Country = new Country()
                            {
                                Name = "Saffron City"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Venasuar",
                            Date = new DateOnly(1903,1,1),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Leaf"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Venasaur",Text = "Venasuar is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Venasaur",Text = "Venasuar is the best a killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Venasaur",Text = "Venasuar, Venasuar, Venasuar", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },

                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Ash",
                            LastName = "Ketchum",
                            Gym = "Ashs Gym",
                            Country = new Country()
                            {
                                Name = "Millet Town"
                            }
                        }
                    },
                        new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Bulbasaur",
                            Date = new DateOnly(1996, 2, 27),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Grass" } }
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Bulbasaur",Text = "Bulbasaur is the best pokemon, because it is grass", Rating = 4,
                                    Reviewer = new Reviewer(){ FirstName = "Ash", LastName = "Ketchum" } },
                                new Review { Title="Bulbasaur", Text = "Bulbasaur is great at battling", Rating = 4,
                                    Reviewer = new Reviewer(){ FirstName = "Misty", LastName = "Waterflower" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Erika",
                            LastName = "Cerulean",
                            Gym = "Cerulean Gym",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Pidgey",
                            Date = new DateOnly(1996, 2, 27),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Flying" } }
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Pidgey",Text = "Pidgey is a cute bird Pokémon", Rating = 3,
                                    Reviewer = new Reviewer(){ FirstName = "Brock", LastName = "Pewter" } },
                                new Review { Title="Pidgey", Text = "Pidgey has a great sense of direction", Rating = 4,
                                    Reviewer = new Reviewer(){ FirstName = "Misty", LastName = "Cerulean" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Falkner",
                            LastName = "Violet",
                            Gym = "Violet Gym",
                            Country = new Country()
                            {
                                Name = "Johto"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Ekans",
                            Date = new DateOnly(1996, 2, 27),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Poison" } }
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Ekans",Text = "Ekans is a sneaky and cunning Pokémon", Rating = 3,
                                    Reviewer = new Reviewer(){ FirstName = "Jessie", LastName = "Team Rocket" } },
                                new Review { Title="Ekans", Text = "Ekans has a unique pattern on its back", Rating = 4,
                                    Reviewer = new Reviewer(){ FirstName = "James", LastName = "Team Rocket" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Janine",
                            LastName = "Fuchsia",
                            Gym = "Fuchsia Gym",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                        }
                    },
                    new PokemonOwner()
                    {
                        Pokemon = new Pokemon()
                        {
                            Name = "Sandshrew",
                            Date = new DateOnly(1996, 2, 27),
                            PokemonCategories = new List<PokemonCategory>()
                            {
                                new PokemonCategory { Category = new Category() { Name = "Ground" } }
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Sandshrew",Text = "Sandshrew is a ground type Pokémon", Rating = 3,
                                    Reviewer = new Reviewer(){ FirstName = "Brock", LastName = "Pewter" } },
                                new Review { Title="Sandshrew", Text = "Sandshrew has a great sense of direction", Rating = 4,

                                    Reviewer = new Reviewer(){ FirstName = "Misty", LastName = "Cerulean" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Clair",
                            LastName = "Blackthorn",
                            Gym = "Blackthorn Gym",
                            Country = new Country()
                            {
                                Name = "Pallet Town"
                            }
                        }
                    },
                };
                _dataContext.PokemonOwners.AddRange(pokemonOwners);
                _dataContext.SaveChanges();
            }
        }
    }
}