using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Assignment_2_Server.Data.Models;

namespace Assignment_2_Server.Data.Persistence
{
    public class AdultRepository : IAdultRepository
    {
        private readonly IList<Adult> _adults;
        private readonly string _adultsFile = Directory.GetCurrentDirectory() + "\\data\\adults.json";
        
        public AdultRepository()
        {
            _adults = File.Exists(_adultsFile) ? ReadData<Adult>() : new List<Adult>();
        }
        private IList<T> ReadData<T>()
        {
            using (var jsonReader = File.OpenText(_adultsFile))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }

        public IList<Adult> GetAdults()
        {
            return  _adults;
        }

        public async Task AddAdult(Adult adult)
        {
            _adults.Add(adult);
            var jsonAdults = JsonSerializer.Serialize(_adults, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            
            using (var outputFile = new StreamWriter(_adultsFile, false))
            {
                await outputFile.WriteAsync(jsonAdults);
            }
        }
    }
}