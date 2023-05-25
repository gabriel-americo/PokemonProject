using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviwers();
        Reviewer GetReviwer(int reviewerId);
        ICollection<Review> GetReviwesByReviers(int reviewerId);
        bool ReviwerExists(int reviewerId);
    }
}
