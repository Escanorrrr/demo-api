using my_app.Context;
using my_app.Converter;
using my_app.DTO.Request;
using my_app.DTO.Response;
using my_app.Entities;

namespace my_app.Services
{
    public class UserService : IUserService
    {
        private readonly LocationContext _locationContext;
        private readonly IUserConverter _userConverter;
        public UserService(LocationContext locationContext,IUserConverter userConverter)
        {
            _locationContext = locationContext;
            _userConverter = userConverter;
        }

        public void Add(AddUserRequestDTO addUserRequestDTO)
        {
            User user = _userConverter.ToUserConverter(addUserRequestDTO);
            _locationContext.Add(user);
            _locationContext.SaveChanges();

            

            
        }

        public void Delete(int id)
        {
            User user = _locationContext.Users.FirstOrDefault(u => u.Id == id);
            _locationContext.Remove(user);
            _locationContext.SaveChanges();
        }

        public GetUserResponseDTO Get(int id)
        {
            User user = _locationContext.Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
               Console.WriteLine("Böyle bir kullanıcı yok");
                return null;

            }
            else
            {
                GetUserResponseDTO getUserResponseDTO = _userConverter.ToGetLocationResponseDTO(user);   
                return getUserResponseDTO;
            }

                
        }

        public List<GetUsersResponseDTO> GetUsers()
        {
            List<User> users = _locationContext.Users.ToList();
            List<GetUsersResponseDTO> getUsersResponseDTOs = new List<GetUsersResponseDTO>();
            foreach (User user in users)
            {
                List<GetUsersResponseDTO> getUsersResponsesDTOs = _userConverter.ToGetUsersResponseDTOs(user);
            }
                

        }

        public void Update(int id, UpdateRequestUserDto updateRequestUserDto)
        {
            if(id == null)
            {
                Console.WriteLine("Kullanıcı Yok");
                
            }
            else
            {
                User user = _locationContext.Users.FirstOrDefault(x => x.Id == id);
                user.Name = updateRequestUserDto.Name;
                user.Email = updateRequestUserDto.Email;
                user.Password = updateRequestUserDto.Password;
                _locationContext.Update(user);
                _locationContext.SaveChanges();
            }
            
        }
    }


}
