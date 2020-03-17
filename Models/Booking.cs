using System;

namespace BookingHotel.Models
{
    public class Booking
    {
        public int Id {get; set;}
        public string RoomId {get; set;}
        public DateTime In {get; set;}
        public DateTime Out {get; set;}
    }
}