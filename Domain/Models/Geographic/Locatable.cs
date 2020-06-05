﻿using GoingTo_API.Domain.Models.Business;
using GoingTo_API.Domain.Models.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoingTo_API.Domain.Models
{
    public class Locatable
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<Tip> Tips { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Favourite> Favourites { get; set; }
        public City City { get; set; }
        public Country Country { get; set; }
        public Place Place { get; set; }
        public List<LocatablePromos> LocatablePromos { get; set; }
        public List<PartnerServices> PartnerServices { get; set; }

    }
}
