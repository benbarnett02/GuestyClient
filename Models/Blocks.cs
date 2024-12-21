using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Guesty.Models
{
    public class Blocks
    {
        [JsonPropertyName("m")]
        public bool Manual { get; set; }
        [JsonPropertyName("r")]
        public bool Reserved { get; set; }
        [JsonPropertyName("b")]
        public bool Booked { get; set; }
        [JsonPropertyName("bd")]
        public bool Default { get; set; }
        [JsonPropertyName("sr")]
        public bool SmartRule { get; set; }
        [JsonPropertyName("abl")]
        public bool AnnualBookingLimit { get; set; }
        [JsonPropertyName("a")]
        public bool Allotment { get; set; }
        [JsonPropertyName("bw")]
        public bool BookingWindow { get; set; }
        [JsonPropertyName("o")]
        public bool Owner { get; set; }
        [JsonPropertyName("pt")]
        public bool PreparationTime { get; set; }
        [JsonPropertyName("ic")]
        public bool ICal { get; set; }
        [JsonPropertyName("an")]
        public bool AdvanceNotice { get; set; }

    }
}
