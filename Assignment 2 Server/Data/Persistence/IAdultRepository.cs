using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment_2_Server.Data.Models;

namespace Assignment_2_Server.Data.Persistence
{
    public interface IAdultRepository
    {
        public IList<Adult> GetAdults();
        public Task AddAdult(Adult adult);
    }
}