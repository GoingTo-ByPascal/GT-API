﻿using System.Collections.Generic;

namespace GoingTo_API.Domain.Models
{
    public class User
    {
        // atributes
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Wallet Wallet { get; set; }

        // relational
        public int WalletId { get; set; }
        public Profile Profile { get; set; }


        public List<Review> Reviews { get; set; } = new List<Review>();
        public List<Favourite> Favourites { get; set; } = new List<Favourite>();
        public List<UserAchievement> UserAchievements { get; set; } = new List<UserAchievement>();

    
    }
}
