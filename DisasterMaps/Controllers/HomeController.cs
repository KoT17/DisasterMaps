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
                Store temp = new Store { Name = "TestVersion3bby", OpeningTime = time, ClosingTime = time, Coordinates = testCoor, IsOpen = true };

                context.Stores.Add(temp);

                Debug.WriteLine("Inserting test store");
                context.SaveChanges();

                var exists = context.Stores.OrderBy(b => b.Name).Last();
                Debug.WriteLine(exists.Name);
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
