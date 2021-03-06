﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisasterMaps.Models
{
    public class Store
    {
        [System.ComponentModel.DataAnnotations.Key]
        public String Name { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public DateTime ClosingTime { get; set; }

        public DateTime OpeningTime { get; set; }

        public bool IsOpen { get; set; }
    }
}
