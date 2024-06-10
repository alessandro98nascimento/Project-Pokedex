using Login.Serices;
using Microsoft.AspNetCore.Mvc;
using User.DTORequest;


namespace LoginController.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginService _context;
        public LoginController()
        {
            _context = new LoginService();
        }

        [HttpPost]
        [Route("Login")]

        public ActionResult PostUser([FromBody] UserDTORequest UserRequest) 
        {

            var response = _context.GetUser(UserRequest);

            if (response == false) return BadRequest("fudeu legal dog");

            return Ok(response);
        }
    }
}
