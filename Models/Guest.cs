using System;

namespace BookingHotel.Models
{
    public class Guest
    {
          public int Id {get; set;}
          public string Name {get; set;}
          public string Phone {get; set;}
          public DateTime CheckIn {get; set;}
          public DateTime CheckOut {get; set;}
          public string Deposit {get; set;}
          public string Class {get; set;}
          public string SpecialRequest {get; set;}
          public string RoomNumber {get; set;}
    }
}