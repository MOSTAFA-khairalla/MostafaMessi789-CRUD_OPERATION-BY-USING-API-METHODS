using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication31.DAl.Entity
{
    public class Payment
    {
        public int id { get; set; }
        public string bankName { get; set; }
        public string bankAddress { get; set; }
        public string bankAccountNo { get; set; }
        public string bankAccountIBAN { get; set; }
        public string swiftCode { get; set; }
        public string terms { get; set; }
    }
}
