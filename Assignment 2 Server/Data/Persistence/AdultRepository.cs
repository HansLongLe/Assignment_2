using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Assignment_2_Server.Data.Models;

namespace Assignment_2_Server.Data.Persistence
{
    public class AdultRepository : IAdultRepository
    {
        private IList<Adult> Adults;
        private readonly string adultsFile = System.IO.Directory.GetCurrentDirectory() + "\\data\\adults.json";
        
        public AdultRepository()
        {
            Adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
        }
        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(adultsFile))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }

        public IList<Adult> GetAdults()
        {
            return Adults;
        }

        public void AddAdult(Adult adult)
        {
            Adults.Add(adult);
            // storing persons
            string jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (StreamWriter outputFile = new StreamWriter(adultsFile, false))
            {
                outputFile.Write(jsonAdults);
            }
        }
    }
}