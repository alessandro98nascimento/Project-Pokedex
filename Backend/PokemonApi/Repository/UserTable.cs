using User.DTORequest;
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

        public Users? GetUser(UserDTORequest UserRequest)
        {
            var user = _context.Users.FirstOrDefault(user => user.Email == UserRequest.UserName && user.UserPassword == UserRequest.Password);
            return user;
        }
    }
}