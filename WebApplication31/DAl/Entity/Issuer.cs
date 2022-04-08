using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication31.DAl.Entity
{
    public class Issuer
    {
        public int id { get; set; }
        public Address address { get; set; }
        public string type { get; set; }
     
        public string name { get; set; }
    }
}
