using my_app.DTO.Response;
using my_app.Entities;

namespace my_app.Converter
{
    public class abcLocationConverter : ILocationConverter
    {
        public Get_Location_ResponseDTO ToGetLocationResponseDTO(Location location)
        {

            Get_Location_ResponseDTO get_Location_ResponseDTO = new Get_Location_ResponseDTO();
            get_Location_ResponseDTO.boylam = location.boylam;
            get_Location_ResponseDTO.enlem = location.enlem;
            return get_Location_ResponseDTO;
        }
    }
}
