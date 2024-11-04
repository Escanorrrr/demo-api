using my_app.DTO.Request;
using my_app.DTO.Response;
using my_app.Entities;

namespace my_app.Services
{
    public interface IUserService
    {
        void Add(AddUserRequestDTO addUserRequestDTO);
        void Update(int id,UpdateRequestUserDto updateRequestUserDto);
        void Delete(int id);
        public GetUserResponseDTO Get(int id);
        public List<GetUsersResponseDTO> GetUsers();

    }
}
