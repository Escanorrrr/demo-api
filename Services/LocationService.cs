using my_app.Context;
using my_app.Converter;
using my_app.DTO.Response;
using my_app.Entities;

namespace my_app.Services
{
    public class LocationService : ILocationService
    {
        private readonly LocationContext _locationContext;
        private readonly ILocationConverter _locationConverter;
        public LocationService(LocationContext context,ILocationConverter locationConverter)
        {
            _locationContext = context;
            _locationConverter = locationConverter;
        }
        public void Add(Location location)
        {
           _locationContext.Locations.Add(location);
            _locationContext.SaveChanges();
        }

        public List<Get_Location_ResponseDTO> GetAll()
        {
            List<Location> locations = _locationContext.Locations.ToList();
            List<Get_Location_ResponseDTO> responseDTOs = new List<Get_Location_ResponseDTO>();
            foreach(Location TempLocation in locations)
            {
                Get_Location_ResponseDTO response  =  _locationConverter.ToGetLocationResponseDTO(TempLocation);
                responseDTOs.Add(response);
            }


            return responseDTOs;
            
        }

        public Get_Location_ResponseDTO Get()
        {
            Location location = _locationContext.Locations.FirstOrDefault(l => l.Id == 1);


            return _locationConverter.ToGetLocationResponseDTO(location);
        }
    }
}
