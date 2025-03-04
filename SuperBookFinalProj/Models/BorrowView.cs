using System;

namespace SuperBookFinalProj.Models
{
    public class BorrowView
    {
        public int Id { get; set; } // Borrow ID

        public string BorrowedBy { get; set; } // Consumer's Full Name

        public string EquipmentName { get; set; } // Equipment Name

        public int EquipmentId { get; set; }

        public DateTime BorrowDate { get; set; } // Borrow Date

        public string TimeSlot { get; set; } // Selected time slot for borrowing

        public string Purpose { get; set; } // Reason for borrowing

        public int Quantity { get; set; } // Number of items borrowed

        public string Status { get; set; } // Borrowing status (Borrowed, Returned, Canceled)
    }
}
