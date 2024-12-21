using System.Text.Json.Serialization;

namespace Guesty.Models.Responses;

// ReSharper disable once ClassNeverInstantiated.Global
public class CalendarResponse
{
    [JsonPropertyName("data")]
    public required CalendarDaysArrayWrapper Data { get; set; }
}

public class CalendarDaysArrayWrapper
{
    [JsonPropertyName("days")]
    public required IEnumerable<Day> Days { get; set; }
}