using System.Text.Json.Serialization;

namespace Guesty.Models.Responses;

// ReSharper disable once ClassNeverInstantiated.Global
public class ListingResponse<T>
{
    [JsonPropertyName("results")]
    public required IEnumerable<T> Data { get; set; }
    public int count { get; set; }
}