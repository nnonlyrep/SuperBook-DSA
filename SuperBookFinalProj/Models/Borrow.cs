using System;
using System.Text.Json.Serialization;

namespace SuperBookFinalProj.Models
{
    public class Borrow
    {
        public int Id { get; set; } = 0;

        [JsonPropertyName("consumer_id")]
        public int ConsumerId { get; set; } // FK to Consumer Table

        [JsonPropertyName("equipment_id")]
        public int EquipmentId { get; set; } // FK to Equipments Table

        [JsonPropertyName("equipment_name")]
        public string EquipmentName { get; set; }

        [JsonPropertyName("borrow_date")]
        public DateTime BorrowDate { get; set; }

        
        [JsonPropertyName("time")]
        public string time { get; set; }

        [JsonPropertyName("purpose")]
        public string Purpose { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; } = "Borrowed"; // Default status
    }
}
