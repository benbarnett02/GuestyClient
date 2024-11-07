using Guesty.Models;
using Guesty.Models.Requests;
using Guesty.Models.Responses;
using Refit;

namespace Guesty.Refit
{
    [Headers("Authorization")]
    internal interface IOpenApiService
    {
        [Get("/listings")]
        Task<EnumerableResponse<Listing>> GetListings([Query]ListingsQuery? query = null);

        [Get("/listings/{id}")]
        Task<Listing> GetListing(string id);
        
        [Put("/listings/{id}")]
        Task<Listing> UpdateListing(string id, [Body]Listing listing);
        
        [Post("/listings.email")]
        Task EmailListings([Body] string to, [Query] ListingsQuery? query = null);
        
        [Get("/listings/tags")]
        Task<IEnumerable<string>> GetTags();
        
        
    }
}
