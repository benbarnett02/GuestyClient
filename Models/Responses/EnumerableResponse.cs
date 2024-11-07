using System.Text.Json.Serialization;

namespace Guesty.Models.Responses;

public abstract class EnumerableResponse<T>
{
    [JsonPropertyName("results")]
    public required IEnumerable<T> Data { get; set; }
}