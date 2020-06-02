﻿using GoingTo_API.Domain.Models;
using GoingTo_API.Resources;

namespace GoingTo_API.Mapping
{
    public class ModelToResourceProfile : AutoMapper.Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Locatable, LocatableResource>();
            CreateMap<User, UserResource>();
            CreateMap<Profile, ProfileResource>();
            CreateMap<Wallet, WalletResource>();
            CreateMap<Reviewable, ReviewableResource>();
            CreateMap<Achievement, AchievementResource>();
            CreateMap<Country, CountryResource>();
            CreateMap<City, CityResource>();
            CreateMap<Place, PlaceResource>();
        }
    }
}
