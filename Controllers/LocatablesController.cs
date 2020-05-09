﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using GoingTo_API.Domain.Models;
using GoingTo_API.Domain.Services;
using GoingTo_API.Resources;
using GoingTo_API.Extensions;

namespace GoingTo_API.Controllers
{
    [Route("/api/[controller]")]
    [Produces("application/json")]
    public class LocatablesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ILocatableService _locatableService;
       
        public LocatablesController(ILocatableService locatableService,IMapper mapper)
        {
            _mapper = mapper;
            _locatableService = locatableService;
        }
        /// <summary>
        /// Returns all the locatables in the system
        /// </summary>
        /// <response code="200">Returns all the locatables in the system</response>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<LocatableResource>> GetAllAsync()
        {
            var locatables = await _locatableService.ListAsync();
            var resources = _mapper
                .Map<IEnumerable<Locatable>, IEnumerable<LocatableResource>>(locatables);
            return resources;
        }
    }
}
