using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supabase.Postgrest.Models;

namespace SuperBookFinalProj.Models
{

    public class Reservation
    {
        public Guid Id { get; set; } // Unique Reservation ID
        public Guid UserId { get; set; } // Consumer who made the reservation
        public Guid RoomId { get; set; } // Reserved room ID
        public string ConsumerName { get; set; } // Consumer's full name
        public string ReservationPurpose { get; set; } // Purpose of reservation
        public DateTime ReservationDate { get; set; } // Date of reservation
        public ReservationTimeSlot TimeReserved { get; set; } // Fixed time slot (Enum)
    }

        public enum ReservationTimeSlot
        {
            SevenAM_NineAM,   // 7:00AM - 9:00AM
            TenAM_TwelvePM,   // 10:00AM - 12:00PM
            OnePM_ThreePM,    // 1:00PM - 3:00PM
            FourPM_SixPM      // 4:00PM - 6:00PM
        }
  


}
