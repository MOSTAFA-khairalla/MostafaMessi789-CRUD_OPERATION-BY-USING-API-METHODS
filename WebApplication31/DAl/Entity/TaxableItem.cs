using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication31.DAl.Entity
{
    public class TaxableItem
    {
        public int id { get; set; }

        public string taxType { get; set; }
        public double amount { get; set; }
        public string subType { get; set; }
        public double rate { get; set; }
    }
}
