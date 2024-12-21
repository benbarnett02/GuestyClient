using System.Runtime.Versioning;
using Guesty.Models;
using Guesty.Models.Requests;
using Guesty.Models.Responses;
using Refit;

namespace Guesty.Refit
{
    [Headers("Authorization")]
    internal partial interface IOpenApiService
    {
        [Get("/listings")]
        Task<ListingResponse<Listing>> GetListings([Query] ListingsQuery? query);

        [Get("/listings/{id}")]
        Task<Listing> GetListing(string id);

        [Put("/listings/{id}")]
        Task<Listing> UpdateListing(string id, [Body] Listing listing);

        [Post("/listings.email")]
        Task EmailListings([Body] string to, [Query] ListingsQuery? query = null);

        [Get("/listings/tags")]
        Task<IEnumerable<string>> GetTags();

        [Get("/reservations")]
        Task<ListingResponse<Reservation>> GetReservations([Query] ReservationsQuery? query = null);

        [Get("/reservations/{id}")]
        Task<Reservation> GetReservation(string id);

        [Get("/guests-crud")]
        Task<ListingResponse<Guest>> GetGuests(); // TODO: Implement query

        [Get("/guests-crud/{id}")]
        Task<Guest> GetGuest(string id, List<string> fields); // TODO: Implement query??

        [Get("/owners")]
        Task<ListingResponse<Owner>> GetOwners(); // TODO: Implement query

        [Get("/owners/{id}")]
        Task<Owner> GetOwner(string id);

        
        
        // This endpoint is NOT Documented. I don't recommend using it. 
        // Guesty may remove it at any time.
        [Get("/accounts/me/stats")]
        Task<AccountStatistics> GetAccountStatistics([Query] string? listingId);
        
    }
}