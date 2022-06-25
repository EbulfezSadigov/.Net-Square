using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Square.DAL;
using Square.Models;
using Square.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Square.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;
        public HomeController(AppDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            HomeViewModel hvm = new HomeViewModel() {
                teams = db.Teams.ToList()
            };
            return View(hvm);
        }
    }
}
