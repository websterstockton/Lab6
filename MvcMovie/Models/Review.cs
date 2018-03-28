using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Review
    {
        public int ID { get; set; }
        public string Reviewer { get; set; }
        public string Comment { get; set; }
        public int MovieID { get; set; } // changed from string
    }
}
