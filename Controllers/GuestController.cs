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

        public IActionResult Available (DateTime datein, DateTime dateout) {
            var bookedlist = from a in _AppDbContext.Bookings where ((a.In.Date <= datein.Date && dateout.Date <= a.Out.Date) || (a.In.Date <= datein.Date && datein.Date <= a.Out.Date) || (a.In.Date <= dateout.Date && dateout.Date <= a.Out.Date) || (datein.Date <= a.In.Date && a.In.Date <= dateout.Date) || (datein.Date <= a.Out.Date && a.Out.Date <= dateout.Date)) select a;
            var roombooked = new List<string> ();
            foreach (var item in bookedlist) {
                roombooked.Add (item.RoomId);
            }
            var room = from a in _AppDbContext.Rooms select a;
            ViewBag.RoomFilter = room;
            ViewBag.RoomBooked = roombooked;
            ViewBag.Status = "filter";
            ViewBag.Date = datein;
            ViewBag.Dateout = dateout;
            return View ("Home");
        }
        public IActionResult BookRoom (string number, DateTime checkin, DateTime checkout, string name, string phone, string req, string price) {
            var getuser = _AppDbContext.Statuslogin.Find (1);
            var getsaldo = (from a in _AppDbContext.Guests where a.Email == getuser.Email select a).First ();
            if (Convert.ToInt32 (getsaldo.Deposit) >= Convert.ToInt32 (price)) {
                var newsaldo = Convert.ToInt32(getsaldo.Deposit) - Convert.ToInt32(price);
                getsaldo.Deposit = newsaldo.ToString();
                var obj = new Transaction () {
                checkin = checkin,
                checkout = checkout,
                Notes = req,
                Name = name,
                Phone = phone,
                RoomNumber = number,
                BookPrice = price
                };
                var book = new Booking () {
                    In = checkin,
                    Out = checkout,
                    RoomId = number
                };
                _AppDbContext.Bookings.Add (book);
                _AppDbContext.Transactions.Add (obj);
                _AppDbContext.SaveChanges ();
                return RedirectToAction ("Home", "Guest");
            }
            else {
                return View("CannotBook");
            }
            return View ();
        }

        public IActionResult BookingSummary (string number, DateTime checkin, DateTime checkout, string name, string phone, string req, string facilities, string cls, string price) {
            ViewBag.Number = number;
            ViewBag.Checkin = checkin;
            ViewBag.Checkout = checkout;
            ViewBag.Name = name;
            ViewBag.Req = req;
            ViewBag.Phone = phone;
            ViewBag.Class = cls;
            ViewBag.Price = price;
            ViewBag.Facilities = facilities;
            return View ();
        }
        public IActionResult Home () {
            Console.WriteLine ("ini cookie");
            var roombooked = new List<string> ();
            ViewBag.RoomBooked = roombooked;
            var room = from a in _AppDbContext.Rooms select a;
            var whoslogin = _AppDbContext.Statuslogin.Find (1);
            var guest = (from a in _AppDbContext.Guests where a.Email == whoslogin.Email select a).First ();
            ViewBag.Guest = guest;
            ViewBag.Room = room;
            ViewBag.Status = "";
            return View ();
        }
        public IActionResult CannotBook () {
            return View ();
        }
        public IActionResult Topup () {
            return View ();
        }
        public IActionResult TopupAmount (int amount) {
            var user = _AppDbContext.Guests.Find (1);
            var total = Convert.ToInt32 (user.Deposit) + amount;
            user.Deposit = total.ToString ();
            _AppDbContext.SaveChanges ();
            return RedirectToAction ("Home");
        }
        public IActionResult BookingForm (int Id) {
            var hotel = _AppDbContext.Rooms.Find (Id);
            ViewBag.Room = hotel;
            return View ();
        }
        // public IActionResult Saldo () {
        //     var get = 
        //     ViewBag.Room = hotel;
        //     return View ();
        // }

        public IActionResult Privacy () {
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}