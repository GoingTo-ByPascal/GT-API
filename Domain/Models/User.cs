﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoingTo_API.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int Password { get; set; }
        public Wallet Wallet { get; set; }
        
        public Review Review { get; set; }
        public Profile Profile { get; set; }
        public List<Favourite> Favourites { get; set; } = new List<Favourite>();

    }
}
