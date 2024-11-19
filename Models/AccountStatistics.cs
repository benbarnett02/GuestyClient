using System.Text.Json.Serialization;

namespace Guesty.Models;

public class AccountStatistics
{
    [JsonPropertyName("confirmed")]
    public StatisticWrapper? ConfirmedBookings { get; set; }
    
    public StatisticWrapper? CheckIns { get; set; }
    
    [JsonPropertyName("avgPayout")]
    public StatisticWrapper? AveragePayout { get; set; }
    
    [JsonPropertyName("avgNights")]
    public StatisticWrapper? AverageNumberOfNights { get; set; }
    
    [JsonPropertyName("avgGuests")]
    public StatisticWrapper? AverageNumberOfGuests { get; set; }
    
    [JsonPropertyName("avgDaysInAdvance")]
    public StatisticWrapper? AverageBookingWindow { get; set; }
    
    [JsonPropertyName("listingsCount")]
    public ListingsCount? NumberOfListings { get; set; }
        
}