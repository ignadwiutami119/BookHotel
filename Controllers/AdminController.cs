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
            if (!_AppDbContext.AccountPages.Any ()) {
            var obj = new AccountPage () {
            StatusPage = "Manager",
            CurentPage = 1,
            ShowItem = 6
                };
                _AppDbContext.AccountPages.Add (obj);
                _AppDbContext.SaveChanges ();
            }
            var page = _AppDbContext.AccountPages.Find (1);
            page.StatusPage = status;
            _AppDbContext.SaveChanges ();
            if (status == "Manager") {
                var Manager = from a in _AppDbContext.Accounts
                where a.Status == "Manager"
                select a;
                ViewBag.page = page;
                ViewBag.Manager = Manager;
                return View ();
            } else if (status == "Officer") {
                var Officer = from a in _AppDbContext.Accounts
                where a.Status == "Officer"
                select a;
                ViewBag.page = page;
                ViewBag.Officer = Officer;
                return View ();
            } else {
                var Admin = from a in _AppDbContext.Accounts
                where a.Status == "Admin"
                select a;
                ViewBag.page = page;
                ViewBag.Admin = Admin;
                return View ();
            }
        }

        public IActionResult ChangeAsAdmin (int Id) {
            var get = _AppDbContext.Accounts.Find (Id);
            get.Status = "Admin";
            _AppDbContext.SaveChanges ();
            return RedirectToAction ("ManageAccount");
        }
        public IActionResult ChangeAsOfficer (int Id) {
            var get = _AppDbContext.Accounts.Find (Id);
            get.Status = "Officer";
            _AppDbContext.SaveChanges ();
            return RedirectToAction ("ManageAccount");

        }
        public IActionResult ChangeAsManager (int Id) {
            var get = _AppDbContext.Accounts.Find (Id);
            get.Status = "Manager";
            _AppDbContext.SaveChanges ();
            return RedirectToAction ("ManageAccount");

        }
        public IActionResult Remove (int Id) {
            var get = _AppDbContext.Accounts.Find (Id);
            get.Status = "0";
            _AppDbContext.SaveChanges ();
            return RedirectToAction ("ManageAccount","Admin");
        }

        public IActionResult Detail (int Id) {
            var account = _AppDbContext.Accounts.Find (Id);
            ViewBag.Account = account;
            return View ();
        }

        public IActionResult AddAccount () {
            return View ();
        }
        public IActionResult AddDataAccount (string name, string address, string phone, string nip, string status, string email, string password) {
            var obj = new Account () {
                FullName = name,
                Address = address,
                Phone = phone,
                NIP = nip,
                Status = status,
                Email = email,
                Password = password
            };
            _AppDbContext.Accounts.Add (obj);
            _AppDbContext.SaveChanges ();
            return RedirectToAction ("ManageAccount");
        }
        public IActionResult UpdateDataAccount (int Id, string name, string address, string phone, string nip, string status) {
            var get = _AppDbContext.Accounts.Find(Id);
            get.FullName = name;
            get.Address =  address;
            get.Phone = phone;
            get.NIP = nip;
            get.Status = status;
            _AppDbContext.SaveChanges ();
            return RedirectToAction ("ManageAccount");
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