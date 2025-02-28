using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace SuperBookFinalProj.Models
{
    public class Room
    {
        public int id { get; set; } = 0;

        [JsonPropertyName("room_number")]
        public string room_number { get; set; }

        [JsonPropertyName("room_type")]
        public string room_type { get; set; }

        [JsonPropertyName("capacity")]
        public int capacity { get; set; }

        [JsonPropertyName("location")]
        public string location { get; set; }
    }
}
