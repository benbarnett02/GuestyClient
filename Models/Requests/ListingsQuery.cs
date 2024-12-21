using System.Reflection;
using Refit;

namespace Guesty.Models.Requests;

public class ListingsQuery
{
    [AliasAs("tags")] public List<string>? Tags { get; set; }

    public List<string>? IncludeIds { get; set; }
    public List<string>? ExcludeIds { get; set; }
    public string? ViewId { get; set; }
    public string? QueryString { get; set; }
    public string? City { get; set; }
    
    [AliasAs("active")]
    public string? Active { get; set; }

    public bool? PmsActive { get; set; }
    public string? IntegrationId { get; set; }

    [AliasAs("listed")]
    public bool? Listed { get; set; }
    public AvailabilityRange? AvailabilityRange { get; set; }
    public bool IgnoreFlexibleBlocks { get; set; } = false;
    public List<string> Fields { get; set; } = new List<string>();
    public string? Sort { get; set; }

    [AliasAs("limit")]
    public int Limit { get; set; } = 25;

    [AliasAs("skip")]
    public int Skip { get; set; } = 0;
   
   }