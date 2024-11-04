using my_app.DTO.Request;
using my_app.DTO.Response;
using my_app.Entities;

namespace my_app.Converter
{
    public class UserConverter : IUserConverter
    {
        

        public GetUserResponseDTO ToGetLocationResponseDTO(User user)
        {
            GetUserResponseDTO getUserResponseDTO = new GetUserResponseDTO();
            getUserResponseDTO.Status = user.Status;
            getUserResponseDTO.Email = user.Email;
            getUserResponseDTO.Password = user.Password;
            getUserResponseDTO.Name = user.Name;
            return getUserResponseDTO;
        }

        public List<GetUsersResponseDTO> ToGetUsersResponseDTO(List<User> users)
        {
            List<GetUsersResponseDTO> getUsersResponseDTOs = new List<GetUsersResponseDTO>();


            foreach (User user in users)
            {
                GetUsersResponseDTO dto = new GetUsersResponseDTO
                {
                    Password = user.Password,
                    Name = user.Name,
                    Email = user.Email,
                    Status = user.Status
                };

                getUsersResponseDTOs.Add(dto);
            }
            return getUsersResponseDTOs;

        }

        public User ToUserConverter(AddUserRequestDTO addUserRequestDTO)
        {
            return new User
            {
                Name = addUserRequestDTO.Name,
                Email = addUserRequestDTO.Email,
                Password = addUserRequestDTO.Password,
                Status = addUserRequestDTO.Status
            };
        }

        public User ToUserUpdateConverter(UpdateRequestUserDto updateUserRequestDTO)
        {
            return new User
            {
                Email = updateUserRequestDTO.Email,
                Name = updateUserRequestDTO.Name,
                Password = updateUserRequestDTO.Password
            };
        }
    }
}
