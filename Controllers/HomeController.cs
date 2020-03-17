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
    public class HomeController : Controller
    {
        public IConfiguration Configuration;
        private AppDbContext _AppDbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext, IConfiguration configuration)
        {
            _AppDbContext = appDbContext;
            _logger = logger;
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string email = null, string password = null)
        {
            var admin = from a in _AppDbContext.Admins select a;
            var Account = from a in _AppDbContext.Accounts select a;
            var Guest = from a in _AppDbContext.Guests select a;
            foreach (var item in admin)
            {
                if (item.Email == email)
                {
                    if (email == item.Email && password == item.Password)
                    {
                        return RedirectToAction("ManageAccount", "Admin");
                    }
                }
            }
            foreach (var item in Account)
            {
                if (item.Email == email)
                {
                    if (email == item.Email && password == item.Password && item.Status == "Manager")
                    {
                        return RedirectToAction("Dashboard", "Manager");
                    }
                    else if (email == item.Email && password == item.Password && item.Status == "Officer")
                    {
                        return RedirectToAction("Dashboard", "Officer");
                    }
                }
            }
            // foreach (var item in Guest)
            // {
            //     if (item.Email == email)
            //     {
            //         if (email == item.Email && password == item.Password)
            //         {
            //             return RedirectToAction("Home", "Guest");
            //         }
            //     }
            // }
            return View("Index");
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