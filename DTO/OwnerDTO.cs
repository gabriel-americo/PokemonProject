﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.DTO
{
    public class OwnerDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gym { get; set; }
        public Country Country { get; set; }
    }
}
