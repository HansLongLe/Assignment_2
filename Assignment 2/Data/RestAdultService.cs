using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Assignment_2.Data;
using Assignment_2.Models;

namespace Assignment_2.Data
{
    public class RestAdultService : IAdultsService
    {
        private string uri = "https://localhost:5001";
        private readonly HttpClient client;

        public RestAdultService()
        {
            client = new HttpClient();
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            HttpResponseMessage responseMessage = await client.GetAsync(uri + "/Adults");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception("Error");
            }

            string message = await responseMessage.Content.ReadAsStringAsync();
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }
        public async Task AddAdultAsync(Adult adult)
        {
            string adultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(
                adultAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage responseMessage = await client.PostAsync(uri + "/adults", content);
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
        }
}
}