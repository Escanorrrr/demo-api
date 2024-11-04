using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_app.DTO.Request;
using my_app.DTO.Response;
using my_app.Entities;
using my_app.Services;

namespace my_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("getUser")]
        public GetUserResponseDTO GetUser(int id)
        {
            return _userService.Get(id);
        }
        [HttpPost("AddUser")]
        public void Add(AddUserRequestDTO addUserRequestDTO)
        {
             _userService.Add(addUserRequestDTO);
        }
        [HttpPut]
        public void Update(int id , UpdateRequestUserDto updateUserRequestDTO)
        {
            _userService.Update(id, updateUserRequestDTO);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            _userService.Delete(id);
        }
    }
}
