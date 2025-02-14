using System.Text.Json.Serialization;

namespace Guesty.Models;
public class Listing
{
    [JsonPropertyName("_id")]
    public string? Id { get; set; }
    public string? Nickname { get; set; }
    public string? Title { get; set; }
    
    public PublicDescription? PublicDescription { get; set; }
    public int Bedrooms { get; set; }
    public decimal Bathrooms { get; set; }
    public int Beds { get; set; }
    public int Accommodates { get; set; }
}