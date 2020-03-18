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
    public class ManagerController : Controller {
        public IConfiguration Configuration;
        private AppDbContext _AppDbContext;
        private readonly ILogger<ManagerController> _logger;

        public ManagerController (ILogger<ManagerController> logger, AppDbContext appDbContext, IConfiguration configuration) {
            _AppDbContext = appDbContext;
            _logger = logger;
            Configuration = configuration;
        }

        public IActionResult Room () {
            var room = from a in _AppDbContext.Rooms select a;
            ViewBag.Room = room;
            return View ();
        }
        public IActionResult AddRoom () {
            return View ();
        }
        public IActionResult AddRoomData (string cls, string price, string number, string description, string fac1, string fac2, string fac3, string fac4, string fac5, string fac6, string fac7, string fac8) {
            var room = new Room () {
                Number = number,
                Class = cls,
                Facilities = fac1 + " " + fac2 + " " + fac3 + " " + fac4 + "\n" + fac5 + " " + fac6 + " " + fac7 + " " + fac8,
                Description = description,
                Status = "Available",
                Price = price
            };
            Console.WriteLine(description);
            Console.WriteLine("ini desc");
            _AppDbContext.Rooms.Add (room);
            _AppDbContext.SaveChanges ();
            return RedirectToAction ("Room", "Manager");
        }
        public IActionResult EditRoomData (int Id, string price, string cls, string status, string number, string description, string fac1, string fac2, string fac3, string fac4, string fac5, string fac6, string fac7, string fac8) {
            var room = _AppDbContext.Rooms.Find(Id);
            room.Number = number;
            room.Status = status;
            room.Class = cls;
            room.Description = description;
            room.Facilities = fac1 + " " + fac2 + " " + fac3 + " " + fac4 + "\n" + fac5 + " " + fac6 + " " + fac7 + " " + fac8;
            room.Price = price;
            _AppDbContext.SaveChanges ();
            return RedirectToAction ("Room", "Manager");
        }

        public IActionResult Remove (int Id) {
            var room = _AppDbContext.Rooms.Find (Id);
            _AppDbContext.Rooms.Remove (room);
            _AppDbContext.SaveChanges ();
            return RedirectToAction ("Room", "Manager");

        }
        public IActionResult EditRoom (int Id) {
            var room = _AppDbContext.Rooms.Find(Id);
            ViewBag.Room = room;
            return View ();
        }
        public IActionResult Dashboard () {
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