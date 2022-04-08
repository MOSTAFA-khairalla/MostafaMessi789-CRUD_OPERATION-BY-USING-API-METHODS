using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication31.DAl.Entity
{
    public class Delivery
    {
        public int Id { get; set; }

        public string approach { get; set; }
        public string packaging { get; set; }
        public string dateValidity { get; set; }
        public string exportPort { get; set; }
        public string countryOfOrigin { get; set; }
        public double grossWeight { get; set; }
        public double netWeight { get; set; }
        public string terms { get; set; }
    }
}
