using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication31.DAl.Entity;

namespace WebApplication31.Models
{
    public class CustomeResponse
    {

        public IEnumerable<EmployeeVM> Records { get; set; }
        public Employee RecordsCustome { get; set; }

        public string Code { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
    }
}
