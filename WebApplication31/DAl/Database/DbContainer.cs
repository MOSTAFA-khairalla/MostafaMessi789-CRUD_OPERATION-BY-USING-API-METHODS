using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication31.DAl.Entity;

namespace WebApplication31.DAl.Database
{
    public class DbContainer:DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<InvoiceLine> InvoiceLines { get; set; }
        public DbSet<Issuer> Issuers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Receiver> Receivers { get; set; }
        public DbSet<Root> Roots { get; set; }
        public DbSet<Signature> Signatures { get; set; }
        public DbSet<TaxTotal> TaxTotals { get; set; }
        public DbSet<UnitValue> UnitValues { get; set; }
        public DbSet<Employee> Employees { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;database=sharpservicedb; Integrated Security=true");
        }
    }
}
