﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoingTo_API.Domain.Models
{
    public class CountryLanguages
    {
        public int Id { get; set; }

        public Country Country { get; set; }
        public int CountryId { get; set; }s

        public Language Language { get; set; }
        public int LanguageId { get; set; }
    }
}
