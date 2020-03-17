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
    public class AdminController : Controller {
        public IConfiguration Configuration;
        private AppDbContext _AppDbContext;
        private readonly ILogger<AdminController> _logger;

        public AdminController (ILogger<AdminController> logger, AppDbContext appDbContext, IConfiguration configuration) {
            _AppDbContext = appDbContext;
            _logger = logger;
            Configuration = configuration;
        }

        public IActionResult ManageAccount (string status = "Manager") {
            var page = _AppDbContext.AccountPages.Find (1);
            page.StatusPage = status;
            _AppDbContext.SaveChanges ();
            if (status == "Manager") {
                var Manager = from a in _AppDbContext.Accounts where a.Status == "Manager"
                select a;
                ViewBag.page = page;
                ViewBag.Manager = Manager;
                return View ();
            } else {
                var Officer = from a in _AppDbContext.Accounts where a.Status == "Officer"
                select a;
                ViewBag.page = page;
                ViewBag.Officer = Officer;
                return View ();
            }
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