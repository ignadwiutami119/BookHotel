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
    public class HomeController : Controller {
        public IConfiguration Configuration;
        private AppDbContext _AppDbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController (ILogger<HomeController> logger, AppDbContext appDbContext, IConfiguration configuration) {
            _AppDbContext = appDbContext;
            _logger = logger;
            Configuration = configuration;
        }

        public IActionResult Index () {
            return View ();
        }

        public IActionResult Login (string email = null, string password = null) {
            var Account = from a in _AppDbContext.Accounts select a;
            var Guest = from a in _AppDbContext.Guests select a;
            foreach (var item in Account) {
                if (item.Email == email) {
                    if (email == item.Email && password == item.Password && item.Status == "Admin") {
                        return RedirectToAction ("ManageAccount", "Admin");
                    } else if (email == item.Email && password == item.Password && item.Status == "Manager") {
                        return RedirectToAction ("Room", "Manager");
                    } else if (email == item.Email && password == item.Password && item.Status == "Officer") {
                        return RedirectToAction ("GuestList", "Officer");
                    }
                }
            }
            var checker = 0;
            foreach (var item in Guest) {
                if (item.Email == email) {
                    if (email == item.Email && password == item.Password) {
                        checker = 1;
                    }
                }
            }
            if (!_AppDbContext.Statuslogin.Any () && checker == 1) {
                var obj = new Statuslogin () {
                    Email = email,
                    Status = "Guest"
                };
                _AppDbContext.Statuslogin.Add (obj);
                _AppDbContext.SaveChanges ();
            }
            else if(_AppDbContext.Statuslogin.Any () && checker == 1){
            var get = _AppDbContext.Statuslogin.Find (1);
            get.Email = email;
            get.Status = "Guest";
            _AppDbContext.SaveChanges ();
            return RedirectToAction ("Home", "Guest"); }
            return View ("Index");
        }

        public IActionResult Logout () {
            return View ("Index");
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