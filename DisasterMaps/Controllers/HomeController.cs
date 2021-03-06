﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
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
            //CleanHazardDatabase();
            //populateHazardDatabase();
            /*var optionsBuilder = new DbContextOptionsBuilder<AppContext>();

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
            }*/
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Hazards(MapModel theModel)
        {
            var localHazards = GetClosestHazards(theModel);

            var HazardViewModel = new HazardViewModel { userLatitude = theModel.Latitude, userLongitude = theModel.Longitude, Hazards = localHazards };
            return View(HazardViewModel); // The model for this will contain a list of hazards.
        }

        [HttpGet]
        public IActionResult Map(MapModel theModel)
        {
            if (theModel.Latitude == 0 && theModel.Longitude == 0)
            {
                if (theModel.Address == null || theModel.City == null || theModel.State == null)
                {
                    return RedirectToAction("Index", "Home");
                }

                if (theModel.Address.Length < 5 || theModel.City.Length < 2 || theModel.State.Length < 2)
                {
                    return RedirectToAction("Index", "Home");
                }


                HttpClient client = new HttpClient();

                string str = "https://maps.googleapis.com/maps/api/geocode/json?";

                string addressNoSpace = theModel.Address.Replace(' ', '+');

                string cityNoSpace = theModel.City.Replace(' ', '+');


                str += "address=" + addressNoSpace + "," + cityNoSpace + "," + theModel.State
                    + "&key=AIzaSyDW3iu6fobk-ymUoQHDTdaflFDyGofUfbQ";


                var res = client.GetAsync(str).Result.Content.ReadAsStringAsync().Result;

                string result1 = res.Substring(res.IndexOf("lat") + 7);

                result1 = result1.Substring(0, result1.IndexOf(','));

                string result2 = res.Substring(res.IndexOf("lng") + 7);

                result2 = result2.Substring(0, result2.IndexOf('\n'));

                var lat = result1;
                var lon = result2;


                theModel.Latitude = Double.Parse(lat);
                theModel.Longitude = Double.Parse(lon);
            }

            theModel.NearbyHazards = GetClosestHazards(theModel);

            return View(theModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Hazards(Hazard theModel)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppContext>();

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=disaster_database;Trusted_Connection=True;");
            using (var context = new AppContext(optionsBuilder.Options))
            {
                Hazard temp = new Hazard { Latitude = theModel.Latitude,
                    Longitude = theModel.Longitude,
                    PosReport = 0,
                    NegReport = 0,
                    Name = theModel.Name,
                    Description = theModel.Description };

                context.Hazards.Add(temp);
                context.SaveChanges();
            }

            return RedirectToAction("Hazards", "Home");
        }


        public void populateHazardDatabase()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppContext>();

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=disaster_database;Trusted_Connection=True;");
            using (var context = new AppContext(optionsBuilder.Options))
            {
                var temp = new Hazard { Longitude = 29.620001, Latitude = -82.30193, PosReport = 10, NegReport = 5, Description = "Street is flooded", Name = "Street Flood" };
                var temp1 = new Hazard { Longitude = 29.59111, Latitude = -82.32000, PosReport = 21, NegReport = 6, Description = "There is a broken streetlight on the side of the road.", Name = "Broken Streetlight" };
                var temp2 = new Hazard { Longitude = 29.541234, Latitude = -82.41222, PosReport = 9, NegReport = 40, Description = "The path to Sun Trail is blocked from a fallen tree", Name = "Sun Trail is closed" };
                var temp3 = new Hazard { Longitude = 29.748201, Latitude = -82.18765, PosReport = 500, NegReport = 0, Description = "Hackers on the loose!", Name = "Hackathon!" };
                var temp4 = new Hazard { Longitude = 29.648201, Latitude = -82.344745, PosReport = 1, NegReport = 50, Description = "Hey I'm just posting this for giggles", Name = "Dummy Hazard" };


                context.Hazards.Add(temp);
                context.Hazards.Add(temp1);
                context.Hazards.Add(temp2);
                context.Hazards.Add(temp3);
                context.Hazards.Add(temp4);

                context.SaveChanges();
            }
        }
        public void printHazardDatabaseIds()
        {
            foreach (Hazard h in _context.Hazards)
            {
                Console.WriteLine(h.Haz);
            }
        }
        public void CleanHazardDatabase()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppContext>();

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=disaster_database;Trusted_Connection=True;");
            using (var context = new AppContext(optionsBuilder.Options))
            {
                var list = context.Hazards.ToList<Hazard>();
                context.Hazards.RemoveRange(list);
                context.SaveChanges();
            }
        }
        public List<Hazard> GetClosestHazards(MapModel theModel)
        {
            var allHazards = _context.Hazards.ToList();
            double[] distances = new double[allHazards.Count];
            Tuple<double, Hazard>[] pair = new Tuple<double, Hazard>[10];
            List<Hazard> localHazards = new List<Hazard>();

            for (int i = 0; i < allHazards.Count; i++)
            {
                Hazard current = allHazards[i];
                distances[i] = Math.Pow((Math.Pow((current.Latitude - theModel.Latitude), 2) + (Math.Pow((current.Longitude - theModel.Longitude), 2))), .5);
                pair[i] = new Tuple<double, Hazard>(distances[i], current);
            }

            int count = 0;
            Array.Sort(distances);
            while (count < 10 && count < distances.Length)
            {
                for (int j = 0; j < pair.Length; j++)
                {
                    if (pair[j].Item1 == distances[count])
                    {
                        localHazards.Add(pair[j].Item2);
                        break;
                    }
                }
                count++;
            }
            return localHazards;
        }
    }
}
