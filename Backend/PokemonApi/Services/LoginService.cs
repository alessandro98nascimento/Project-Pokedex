using UserTableDb.Repository;
using User.DTORequest;


namespace Login.Serices
{
    public class LoginService
    {
        private readonly UserTable _context;
        public LoginService()
        {
            _context = new UserTable();
        }

        public bool GetUser(UserDTORequest UserRequest)
        {
            var responseDb = _context.GetUser(UserRequest);
            if (responseDb == null) return false;
            return true;
        }
    }
}
