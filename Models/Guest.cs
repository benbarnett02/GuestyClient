using System.Text.Json.Serialization;

namespace Guesty.Models;

public class Guest
{
    [JsonPropertyName("_id")] 
    public string? Id { get; set; }
    public GuestAddress Address { get; set; }
}