using System;

namespace BookingHotel.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string RoomNumber { get; set; }
        public string Price { get; set; }
        public string BookPrice { get; set; }
        public string Notes { get; set; }
        public DateTime checkin { get; set; }
        public DateTime checkout { get; set; }
    }
}