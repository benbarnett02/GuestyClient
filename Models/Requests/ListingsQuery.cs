using Refit;

namespace Guesty.Models.Requests;

public class ListingsQuery
{
    
    [AliasAs("tags")]
    List<string>? Tags { get; set; }
    
}