using System.Text.Json.Serialization;

namespace Guesty.Models;
public class Listing
{
    [JsonPropertyName("_id")]
    public required string Id { get; set; }
    public string? Nickname { get; set; }
    
}