using System.Reflection;
using Refit;

namespace Guesty.Models.Requests;

public class ReservationsQuery : IUrlParameterFormatter
{
    public string? ViewId { get; set; }
    public List<string>? Fields { get; set; }
    public string? Sort { get; set; }
    public int Limit { get; set; } = 25;
    public int Offset { get; set; } = 0;
        
    public string? Format(object? value, ICustomAttributeProvider attributeProvider, Type type)
    {
        throw new NotImplementedException();
    }
}