﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisasterMaps.Models
{
    public class Hazard
    {
        [System.ComponentModel.DataAnnotations.Key]
        public long Id { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        //public Image Photo { get; set; }

        public int PosReport { get; set; }

        public int NegReport { get; set; }
    }
}
