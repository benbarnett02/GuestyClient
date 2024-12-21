using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guesty.Models
{
    public class Day
    {
        public DateTime Date { get; set; }
        public string ListingId { get; set; }
        public string Currency { get; set; }
        public decimal Price { get; set; }
        public int MinNights { get; set; }
        public bool IsBasePrice { get; set; }
        public Blocks Blocks { get; set; }
        public string Status { get; set; }
        public string? ReservationId { get; set; }
        public bool Cta { get; set; }
        public bool Ctd { get; set; }
        public bool NotDefaultAvailability { get; set; }
        public bool RequestToBook { get; set; }
    }
}
