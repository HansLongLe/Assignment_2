using System.Text.Json.Serialization;

namespace Assignment_2.Models {
public class Adult : Person {
    [JsonPropertyName("jobTitle")]
    public Job JobTitle { get; set; }
}
}