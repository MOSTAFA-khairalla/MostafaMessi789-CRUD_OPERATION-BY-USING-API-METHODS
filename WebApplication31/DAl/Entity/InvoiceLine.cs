﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication31.DAl.Entity
{
    public class InvoiceLine
    {

        public int Id { get; set; }

        public string description { get; set; }
        public string itemType { get; set; }
        public string itemCode { get; set; }
        public string unitType { get; set; }
        public double quantity { get; set; }
        public string internalCode { get; set; }
        public double salesTotal { get; set; }
        public double total { get; set; }
        public double valueDifference { get; set; }
        public double totalTaxableFees { get; set; }
        public double netTotal { get; set; }
        public double itemsDiscount { get; set; }
        public UnitValue unitValue { get; set; }
        public Discount discount { get; set; }
        public List<TaxableItem> taxableItems { get; set; }
    }
}
