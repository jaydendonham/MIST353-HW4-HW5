﻿using TravelPortalAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using TravelPortalAPI.Entities;

//Jayden Donham
namespace TravelPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : Controller
    {
        private readonly ILocationService locationservice;
        public LocationController(ILocationService location)
        {
            this.locationservice = location;
        }
        [HttpGet("{locationId}")]
        public async Task<List<Location>> GetLocationDetails(int locationid, string state, string city, string zipcode)
        {
            var LocationDetails = await locationservice.GetLocationDetails(locationid, state, city, zipcode);
            return LocationDetails;
        }
    }
}
