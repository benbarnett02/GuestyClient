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
        Task<EnumerableResponse<Listing>> GetListings([Query] ListingsQuery? query = null);

        [Get("/listings/{id}")]
        Task<Listing> GetListing(string id);

        [Put("/listings/{id}")]
        Task<Listing> UpdateListing(string id, [Body] Listing listing);

        [Post("/listings.email")]
        Task EmailListings([Body] string to, [Query] ListingsQuery? query = null);

        [Get("/listings/tags")]
        Task<IEnumerable<string>> GetTags();

        [Get("/reservations")]
        Task<EnumerableResponse<Reservation>> GetReservations([Query] ReservationsQuery? query = null);

        [Get("/reservations/{id}")]
        Task<Reservation> GetReservation(string id);

        [Get("/guests-crud")]
        Task<EnumerableResponse<Guest>> GetGuests(); // TODO: Implement query

        [Get("/guests-crud/{id}")]
        Task<Guest> GetGuest(string id, List<string> fields); // TODO: Implement query??

        [Get("/owners")]
        Task<EnumerableResponse<Owner>> GetOwners(); // TODO: Implement query

        [Get("/owners/{id}")]
        Task<Owner> GetOwner(string id);
    }
}