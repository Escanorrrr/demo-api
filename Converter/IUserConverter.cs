using my_app.DTO.Request;
using my_app.DTO.Response;
using my_app.Entities;

namespace my_app.Converter
{
    public interface IUserConverter
    {
        public GetUserResponseDTO ToGetLocationResponseDTO(User user);
        public User ToUserConverter(AddUserRequestDTO addUserRequestDTO);
        public User ToUserUpdateConverter(UpdateRequestUserDto updateUserRequestDTO);
        public List<GetUsersResponseDTO> ToGetUsersResponseDTO(User user);
    }
}
