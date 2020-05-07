﻿using GoingTo_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoingTo_API.Resources
{
    public class UserResource
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        public WalletResource Wallet { get; set; }
    
    }
}
