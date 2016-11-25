using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DroneSite.Models
{
    public class Order_Address
    {
        public int Order_ID { get; set; }
        public int Drone_ID { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}