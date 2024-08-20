using User.DTORequestLogin;
using UserApi.Context;
using UsersApi.Models;

namespace UserTableDb.Repository
{
    public class UserTable
    {
        private readonly AppDbContext _context;
        public UserTable()
        {
            _context = new AppDbContext();
        }

        public Users? GetUser(UserDTORequestGet UserRequest)
        {
            var user = _context.Users.FirstOrDefault(user => user.Email == UserRequest.Email && user.UserPassword == UserRequest.Password);
            return user;
        }

        public Users? AddUser(UserDTOActive newUser) {
            var user = new Users
            {
                UserPassword = newUser.Password,
                Email = newUser.Email,
                UserActive = 1,
                UserName = newUser.UserName
            };
            
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
}