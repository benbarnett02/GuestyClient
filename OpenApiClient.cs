using System.Runtime.Versioning;
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

    public async Task EmailListings(string to, ListingsQuery? query = null)
    {
        await _api.EmailListings(to, query);
    }

    public async Task<IEnumerable<string>> GetTags()
    {
        return await _api.GetTags();
    }

    public async Task<IEnumerable<Reservation>> GetReservations(ReservationsQuery? query = null)
    {
        var reservations = await _api.GetReservations(query);
        return reservations.Data;
    }

    public async Task<Reservation> GetReservation(string id)
    {
        return await _api.GetReservation(id);
    }

    public async Task<IEnumerable<Guest>> GetGuests()
    {
        var guests = await _api.GetGuests();
        return guests.Data;
    }

    public async Task<Guest> GetGuest(string id, List<string> fields)
    {
        return await _api.GetGuest(id, fields);
    }

    public async Task<IEnumerable<Owner>> GetOwners()
    {
        var owners = await _api.GetOwners();
        return owners.Data;
    }

    public async Task<Owner> GetOwner(string id)
    {
        return await _api.GetOwner(id);
    }

    public async Task<AccountStatistics> GetAccountStatistics(string? listingId = null)
    {
        return await _api.GetAccountStatistics(listingId);
    }

    public async Task<IEnumerable<Day>> GetCalendar(string listingId, DateOnly startDate, DateOnly endDate)
    {
        var calendar = await _api.GetCalendar(listingId, startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));
        return calendar.Data.Days;
    }



}