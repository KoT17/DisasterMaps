using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisasterMaps.Models
{
    public class HazardViewModel
    {
        public double userLatitude { get; set; }

        public double userLongitude { get; set; }

        public List<Hazard> Hazards { get; set; }
    }
}
