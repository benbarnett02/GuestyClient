using System.Text.Json.Serialization;

namespace Guesty.Models;

public class Reservation
{
    [JsonPropertyName("_id")]
    public string? Id { get; set; }
    public string? ListingId { get; set; }
    public string? GuestId { get; set; }
    public string? ConfirmationCode { get; set; }
    public DateTimeOffset CheckIn { get; set; }
    public DateTimeOffset CheckOut { get; set; }
}