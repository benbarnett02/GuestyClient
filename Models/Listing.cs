using System.Text.Json.Serialization;

namespace Guesty.Models;
public class Listing
{
    [JsonPropertyName("_id")]
    public string? Id { get; set; }
    public string? Nickname { get; set; }
    public string? Title { get; set; }
    
}