using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBookFinalProj.Models
{
        public class ReservationView
        {
            public int id { get; set; }
            public string full_name { get; set; } // Consumer's Name
            public string room_number { get; set; } // Room Number
            public DateTime date { get; set; }
            public string time_slot { get; set; } // Updated property name

            public string purpose { get; set; }
            public int occupants { get; set; }
        }
}
