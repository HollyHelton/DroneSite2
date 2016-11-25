using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DroneSite.Models
{
    public class Drone
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageLink { get; set; }
        public string ImageDescription { get; set; }
        public int Stock { get; set; }
        public string Dimensions { get; set; }
        public int Weight { get; set; }
        public int BatteryLife { get; set; }
        public int Range { get; set; }
        public float Price { get; set; }
    }
}