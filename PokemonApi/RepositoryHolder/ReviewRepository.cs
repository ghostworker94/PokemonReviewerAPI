using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.RepositoryHolder
{
    public class ReviewRepository : IReview
    {
        private readonly DatabaseContext _context;
        public ReviewRepository(DatabaseContext context)
        {
            _context = context;
        }
        public List<Review> GetReviews()
        {
            return _context.Reviews.ToList();
        }
        public Review GetReview(int reviewId)
        {
            return _context.Reviews.Where(r => r.Id == reviewId).FirstOrDefault();
        }
        public List<Review> GetReviewsOfAPokemon(int pokeId)
        {
            return _context.Reviews.Where(p => p.Pokemon.Id == pokeId).ToList();
        }

        public List<Pokemon> GetPokemonByReview(int reviewId)
        {
            return _context.Reviews.Where(p => p.Id == reviewId).Select(p => p.Pokemon).ToList();
        }

        public bool ReviewExists(int reviewId)
        {
            return _context.Reviews.Any(r => r.Id == reviewId);
        }

        public bool CreateReview(Review review)
        {
            _context.Add(review);
            return Save();

        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateReview(Review review)
        {
            _context.Update(review);
            return Save();
        }

        public bool DeleteReview(Review review)
        {
            _context.Remove(review);
            return Save();
        }

        public bool DeleteReviews(List<Review> review)
        {
            _context.RemoveRange(review);
            return Save();
        }
    }
}