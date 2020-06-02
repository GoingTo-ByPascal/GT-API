﻿using AutoMapper;
using GoingTo_API.Domain.Models;
using GoingTo_API.Domain.Models.Geographic;
using GoingTo_API.Domain.Services;
using GoingTo_API.Domain.Services.Geographic;
using GoingTo_API.Resources;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoingTo_API.Controllers
{
    [Route("/api/places/{placeId}/categories")]
    public class PlaceCategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IPlaceService _placeService;
        private readonly IPlaceCategoryService _placeCategoryService;
        private readonly IMapper _mapper;

        public PlaceCategoriesController(ICategoryService categoryService, IPlaceCategoryService placeCategoryService, IMapper mapper,IPlaceService placeService)
        {
            _categoryService = categoryService;
            _placeCategoryService = placeCategoryService;
            _mapper = mapper;
            _placeService = placeService;
        }
        /// <summary>
        /// returns all the place's categories
        /// </summary>
        /// <param name="placeId" example="1"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<CategoryResource>> GetAllByPlaceIdAsync(int placeId)
        {
            var categories = await _categoryService.ListByPlaceIdAsync(placeId);
            var resources = _mapper
                .Map<IEnumerable<Category>, IEnumerable<CategoryResource>>(categories);
            return resources;
        }
        /// <summary>
        /// assign a category to one place
        /// </summary>
        /// <param name="placeId" example="1"></param>
        /// <param name="categoryId" example="1"></param>
        /// <returns></returns>
        [HttpPost("{categoryId}")]
        public async Task<IActionResult> AssignPlaceCategory(int placeId, int categoryId)
        {

            var result = await _placeCategoryService.AssignPlaceCategoryAsync(placeId, categoryId);
            if (!result.Success)
                return BadRequest(result.Message);

            var categoryResource = _mapper.Map<Category, CategoryResource>(result.Resource.Category);
            return Ok(categoryResource);

        }
        
    }
}
