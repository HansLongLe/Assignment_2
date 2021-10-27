using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment_2.Models;

namespace Assignment_2.Data {
public interface IAdultsService {
    Task<IList<Adult>> GetAdultsAsync();
    Task AddAdultAsync(Adult adult);
}
}