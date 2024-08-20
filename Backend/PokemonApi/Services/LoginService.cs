using UserTableDb.Repository;
using User.DTORequestLogin;
using UsersApi.Models;

namespace Login.Serices
{
    public class LoginService
    {
        private readonly UserTable _context;
        public LoginService()
        {
            _context = new UserTable();
        }

        public Users? GetUser(UserDTORequestGet UserRequest)
        {
            var responseDb = _context.GetUser(UserRequest);
            return responseDb;
        }

        public UserDTOActive? AddUser(UserDTORequestPost UserRequest)
        {
            var newUser = new UserDTOActive
            {
                Password = UserRequest.Password,
                Email = UserRequest.Email,
                UserActive = 1,
                UserName = UserRequest.UserName
            };

            var responseDB = _context.AddUser(newUser);
            return newUser;
        }
    }
}
