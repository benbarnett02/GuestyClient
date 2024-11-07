using Guesty.Models;
using Guesty.Models.Requests;
using Guesty.Refit;
using Refit;

namespace Guesty;

public class OpenApiClient
{
    private readonly IOpenApiService _api;
    
    public OpenApiClient(HttpClient httpClient)
    {
        _api = RestService.For<IOpenApiService>(httpClient, new RefitSettings
        {
            UrlParameterFormatter = new UrlParameterFormatter()
        });
    }

    public async Task<IEnumerable<Listing>> GetListings(ListingsQuery? query = null)
    {
         
            var listings = await _api.GetListings(query);
            return listings.Data; // Return just the list of listings - not 
    }
    
    public async Task<Listing> GetListing(string id)
    {
        return await _api.GetListing(id);
    }

    public async Task<Listing> UpdateListing(string id, Listing listing)
    {
        return await _api.UpdateListing(id, listing);
    }
}