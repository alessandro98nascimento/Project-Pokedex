using Login.Serices;
using Microsoft.AspNetCore.Mvc;
using User.DTORequestLogin;


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
        [Route("/Login")]

        public ActionResult PostUser([FromBody] UserDTORequestGet UserRequest)
        {
            var response = _context.GetUser(UserRequest);

            if (response == null) return BadRequest(new { message = "email ou senha invalida" });

            return Ok(new { token = "Login feito com sucesso!"});
        }

        [HttpPut]
        [Route("/Login")]
        public ActionResult PutUser([FromBody] UserDTORequestPost UserRequest)
        {
            var infoUser = new UserDTORequestGet { Email = UserRequest.Email, Password = UserRequest.Password }; 
            var response = _context.GetUser(infoUser);
            if (response != null) return BadRequest(new { message = "email já cadastrado" });

            var newUser = _context.AddUser(UserRequest);
            return Created("Conta criada com sucesso", newUser);
        }
        
    }
}
