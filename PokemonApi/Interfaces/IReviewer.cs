using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewer
    {
        List<Reviewer> GetReviewers();
        Reviewer GetReviewer(int id);
        List<Review> GetReviewsByReviewer(int reviewerId);
        bool ReviewerExists(int Id);
        bool CreateReviewer(Reviewer reviewer);
        bool UpdateReviewer(Reviewer reviewer);
        bool DeleteReviewer(Reviewer reviewer);
        bool Save();
    }
}