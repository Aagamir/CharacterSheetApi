using CharacterSheetApi.Models;
using CharacterSheetApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CharacterSheetApi.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUsersService _service;
        private readonly ICharacterSheetService _characterSheetService;

        public UserController(IUsersService service, ICharacterSheetService characterSheetService)
        {
            _service = service;
            _characterSheetService = characterSheetService;
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public ActionResult RegisterUser([FromBody] RegisterUserDto userDto)
        {
            _service.UserPutterInDatabase(userDto);
            return Ok();
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public ActionResult LoginUser([FromBody] LoginDto userDto)
        {
            string token = _service.GenerateLoginToken(userDto);
            return Ok(token);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUser([FromRoute] int id)
        {
            return Ok();

        }
    }
}
