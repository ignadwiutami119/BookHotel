using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BookingHotel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BookingHotel.Controllers
{
    public class OfficerController : Controller
    {
        public IConfiguration Configuration;
        private AppDbContext _AppDbContext;
        private readonly ILogger<OfficerController> _logger;

        public OfficerController(ILogger<OfficerController> logger, AppDbContext appDbContext, IConfiguration configuration)
        {
            _AppDbContext = appDbContext;
            _logger = logger;
            Configuration = configuration;
        }

        public IActionResult Remove(int Id)
        {
            var get = _AppDbContext.Accounts.Find(Id);
            get.Status = "0";
            _AppDbContext.SaveChanges();
            return View();
        }
        public IActionResult GuestList()
        {
            var get = from a in _AppDbContext.Transactions select a;
            ViewBag.Transaction = get;
            return View();
        }
        public IActionResult Detail(int Id)
        {
            var get = _AppDbContext.Transactions.Find(Id);
            var room = (from a in _AppDbContext.Rooms where a.Number == get.RoomNumber select a).First();
            ViewBag.Transaction = get;
            ViewBag.Room = room;
            return View();
        }

        public IActionResult Clear(int Id)
        {
            var get = _AppDbContext.Transactions.Find(Id);
            _AppDbContext.Transactions.Remove(get);
            _AppDbContext.SaveChanges();
            return RedirectToAction("GuestList");
        }
        public IActionResult AvailableRoom()
        {
            var getRoom = from a in _AppDbContext.Rooms select a;
            var booked = from a in _AppDbContext.Transactions select a;
            ViewBag.Room = getRoom;
            ViewBag.Booked = booked;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}