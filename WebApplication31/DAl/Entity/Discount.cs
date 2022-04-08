using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication31.DAl.Entity
{
    public class Discount
    {
        public int Id { get; set; }

        public double rate { get; set; }
        public double amount { get; set; }
    }
}
