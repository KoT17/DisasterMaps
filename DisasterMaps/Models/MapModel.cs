using System;
using System.ComponentModel.DataAnnotations;

namespace DisasterMaps.Models
{
    public class MapModel
    {
        //[RegularExpression("[0-9]{5}"), MinLength(5), MaxLength(5)]
        public string Zipcode { get; set; }

    }
}
