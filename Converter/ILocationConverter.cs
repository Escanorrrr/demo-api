using my_app.DTO.Response;
using my_app.Entities;

namespace my_app.Converter
{
    public interface ILocationConverter
    {
        public Get_Location_ResponseDTO ToGetLocationResponseDTO(Location location);
    }
}
