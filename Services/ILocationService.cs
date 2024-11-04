using my_app.DTO.Response;
using my_app.Entities;

namespace my_app.Services
{
    public interface ILocationService
    {
        void Add(Location location);
        List<Get_Location_ResponseDTO> GetAll();
        public Get_Location_ResponseDTO Get();
    }
}
