using System.Reflection;
using Refit;

namespace Guesty.Models.Requests;

public class ListingsQuery : IUrlParameterFormatter
{
    [AliasAs("tags")] public List<string>? Tags { get; set; }

    public List<string>? IncludeIds { get; set; }
    public List<string>? ExcludeIds { get; set; }
    public string? ViewId { get; set; }
    public string? QueryString { get; set; }
    public string? City { get; set; }
    public bool? Active { get; set; }

    public bool? PmsActive { get; set; }
    public string? IntegrationId { get; set; }
    public bool? Listed { get; set; }
    public AvailabilityRange? AvailabilityRange { get; set; }
    public bool IgnoreFlexibleBlocks { get; set; } = false;
    public List<string> Fields { get; set; } = new List<string>();
    public string? Sort { get; set; }
    public int Limit { get; set; } = 25;
    public int Offset { get; set; } = 0;
    


    public string? Format(object? value, ICustomAttributeProvider attributeProvider, Type type)
    {
        throw new NotImplementedException();
    }
}