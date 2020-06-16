﻿using GoingTo_API.Domain.Models.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoingTo_API.Domain.Models
{
    public class Tip
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int LocatableId { get; set; }
        public Locatable Locatable { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
