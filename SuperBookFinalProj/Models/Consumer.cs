using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace SuperBookFinalProj.Models
{
    public class Consumer
    {
        public int id { get; set; } = 0;

        [JsonPropertyName("created_at")]
        public DateTime? created_at { get; set; }

        [JsonPropertyName("school_id")]
        public int school_id { get; set; } // ✅ Changed from string to int

        [JsonPropertyName("full_name")]
        public string full_name { get; set; }

        [JsonPropertyName("user_name")]
        public string user_name { get; set; }

        [JsonPropertyName("password")]
        public string password { get; set; }

        [JsonPropertyName("contact_num")]
        public string contact_num { get; set; }

        [JsonPropertyName("email_add")]
        public string email_add { get; set; }
    }

}
