﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoingTo_API.Domain.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public int Locatable { get; set; }
    }
}
