using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DisasterMaps.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterMaps.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppContext _context;

        public HomeController(ILogger<HomeController> logger, AppContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppContext>();

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=disaster_database;Trusted_Connection=True;");
            using (var context = new AppContext(optionsBuilder.Options))
            {
                double testCoor = 10.1;
                DateTime time = DateTime.Now;
                Store temp = new Store { Name = "TestDBEntry", OpeningTime = time, ClosingTime = time, XCoordinates = testCoor, YCoordinates=11.2, IsOpen = true };

                context.Stores.Add(temp);

                Debug.WriteLine("Inserting test store");
                context.SaveChanges();

                var exists = context.Stores.OrderBy(b => b.Name).Last();
                Debug.WriteLine(exists.Name);

                context.Stores.Remove(temp);
                context.SaveChanges();
            }
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
