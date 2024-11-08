using System.Text.Json.Serialization;

namespace Guesty.Models;

public class Owner
{
    [JsonPropertyName("_id")]
    public string? Id { get; set; }
    public string? AccountId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public IEnumerable<string>? Listings { get; set; }
    public string? Locale { get; set; }
    public bool? Active { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Notes { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    
}