using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BookingHotel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BookingHotel.Controllers {
    public class GuestController : Controller {
        public IConfiguration Configuration;
        private AppDbContext _AppDbContext;
        private readonly ILogger<GuestController> _logger;

        public GuestController (ILogger<GuestController> logger, AppDbContext appDbContext, IConfiguration configuration) {
            _AppDbContext = appDbContext;
            _logger = logger;
            Configuration = configuration;
        }

        public IActionResult Available (DateTime date) {
            var avail = from a in _AppDbContext.Bookings where (a.In<= date && date <= a.Out) select a;
            var roombooked = new List<string>();
            foreach (var item in avail)
            {
                roombooked.Add(item.RoomId);
            }
            var room = from a in _AppDbContext.Rooms select a;
            ViewBag.RoomFilter = room;
            ViewBag.RoomBooked = roombooked;
            ViewBag.Status = "filter";
            ViewBag.Date = date;
            return View ("Home");
        }
        public IActionResult BookRoom (string number, DateTime checkin, DateTime checkout, string name, string phone, string req, string deposit ) {
            var obj = new Transaction(){
                BookPrice = deposit,
                checkin = checkin,
                checkout = checkout,
                Notes = req,
                Name = name,
                Phone = phone,
                RoomNumber = number
            };
            _AppDbContext.Transactions.Add(obj);
            _AppDbContext.SaveChanges();
            return RedirectToAction ("Home","Guest");
        }
        public IActionResult Home () {
            var roombooked = new List<string>();
            ViewBag.RoomBooked = roombooked;
            var room = from a in _AppDbContext.Rooms select a;
            ViewBag.Room =  room;
            ViewBag.Status = "";
            return View ();
        }
        public IActionResult BookingForm (int Id) {
            var hotel = _AppDbContext.Rooms.Find(Id);
            ViewBag.Room = hotel;
            return View ();
        }
        public IActionResult Privacy () {
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}