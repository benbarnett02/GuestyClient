namespace Guesty.Models.Requests;

public class AvailabilityRange
{
    public DateOnly Start { get; set; }
    public DateOnly End { get; set; }
    public int MinOccupancy { get; set; }
}