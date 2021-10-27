using System.Threading.Tasks;
using Assignment_2.Models;

namespace Assignment_2.Data
{
    public interface IUserService
    {
        public Task<bool> GetResult(User user);
    }
}