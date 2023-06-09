﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviwers();
        Reviewer GetReviwer(int reviewerId);
        ICollection<Review> GetReviwesByReviers(int reviewerId);
        bool ReviewerExists(int reviewerId);
        bool CreateReviwer(Reviewer reviewer);
        bool UpdateReviwer(Reviewer reviewer);
        bool DeleteReviwer(Reviewer reviewer);
        bool Save();
    }
}
