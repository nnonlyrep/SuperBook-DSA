using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SuperBookFinalProj.Models
{
    public class Reservation
    {
        public int id { get; set; } = 0;

        [JsonPropertyName("consumer_id")]
        public int consumer_id { get; set; }  // Foreign key from Consumers

        [JsonPropertyName("room_id")]
        public int room_id { get; set; }  // Foreign key from Rooms

        [JsonPropertyName("date")]
        public DateTime date { get; set; }

        [JsonPropertyName("time")]
        public string time { get; set; }

        [JsonPropertyName("purpose")]
        public string purpose { get; set; }

        [JsonPropertyName("occupants")]
        public int occupants { get; set; }
    }
}
