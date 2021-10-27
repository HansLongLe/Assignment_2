using System.Collections.Generic;
using Assignment_2_Server.Data.Models;

namespace Assignment_2_Server.Data.Persistence
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetUsers();
    }
}