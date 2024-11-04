using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_app.DTO.Response;
using my_app.Entities;
using my_app.Services;

namespace my_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;
        
        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
            
        }

        [HttpPost("post")]
        public void Add(Location location)
        {
            _locationService.Add(location);
        }

        [HttpGet("getLocation")]
        public Get_Location_ResponseDTO GetLocation()
        {
            return _locationService.Get();
        }
        [HttpGet("getLocations")]
        public List<Get_Location_ResponseDTO> GetLocations()
        {
            return _locationService.GetAll();
        }
        
       
    }
}
