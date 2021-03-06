using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DisasterMaps.Models
{
    public class MapModel
    {
        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }
        public List<Hazard> NearbyHazards { get; set; }

    }
}
