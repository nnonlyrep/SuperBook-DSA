using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SuperBookFinalProj.Models
{
    public class Equipments
    {
        public int Id { get; set; } = 0;

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
    }
}
