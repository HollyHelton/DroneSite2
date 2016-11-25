using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DroneSite.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int Person_ID { get; set; }
        public DateTime OrderDate { get; set; }
        public int Duration { get; set; }
        public DateTime DateReturned { get; set; }
    }
}