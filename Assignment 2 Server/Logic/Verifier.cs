using System.Linq;
using Assignment_2_Server.Data.Persistence;

namespace Assignment_2_Server.Logic
{
    public class Verifier : IVerifier
    {
        private readonly IUserRepository _userRepository;

        public Verifier(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool Authorize(string username, string password)
        {
            return _userRepository.GetUsers().Any(user => user.Username.Equals(username) && user.Password.Equals(password));
        }
    }
}