using Guesty.Models;
using Guesty.Models.Requests;
using Guesty.Models.Responses;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guesty.Refit
{
    internal partial interface IOpenApiService
    {
        [Get("/availability-pricing/api/calendar/listings/{listingId}")]
        Task<CalendarResponse> GetCalendar(string listingId, [Query] string startDate, [Query] string endDate);
    }
}
