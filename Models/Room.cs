using System;
using System.Collections.Generic;

namespace BookingHotel.Models
{
    public class Room
    {
        public int Id {get; set;}
        public string Number {get; set;}
        public string Price {get; set;}
        public string Class {get; set;}
        public string Description {get; set;}
        public string Status {get; set;}
        public string Facilities {get; set;}
        public string Availability {get; set;}
        public DateTime Booking {get; set;}
    }
}