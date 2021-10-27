using System.Text.Json.Serialization;

namespace Assignment_2.Models
{
    public class Job
    {
        [JsonPropertyName("jobTitle")]
        public string JobTitle { get; init; }
        
        [JsonPropertyName("salary")]
        public int Salary { get; init; }
    }
}