using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DroneSite.Models
{
    public class Article
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string ImageLink { get; set; }
        public string ImageDescription { get; set; }
        public DateTime Date { get; set; }
        public int AuthorID { get; set; }
    }
}