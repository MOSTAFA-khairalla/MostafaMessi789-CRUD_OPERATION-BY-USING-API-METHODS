using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication31.DAl.Entity
{
    public class Document
    {
        public int Id { get; set; }

        public Issuer issuer { get; set; }
        public Receiver receiver { get; set; }
        public string documentType { get; set; }
        public string documentTypeVersion { get; set; }
        public DateTime dateTimeIssued { get; set; }
        public string taxpayerActivityCode { get; set; }
        public string internalID { get; set; }
        public string purchaseOrderReference { get; set; }
        public string purchaseOrderDescription { get; set; }
        public string salesOrderReference { get; set; }
        public string salesOrderDescription { get; set; }
        public string proformaInvoiceNumber { get; set; }
        public Payment payment { get; set; }
        public Delivery delivery { get; set; }
        public List<InvoiceLine> invoiceLines { get; set; }
        public double totalDiscountAmount { get; set; }
        public double totalSalesAmount { get; set; }
        public double netAmount { get; set; }
        public List<TaxTotal> taxTotals { get; set; }
        public double totalAmount { get; set; }
        public double extraDiscountAmount { get; set; }
        public double totalItemsDiscountAmount { get; set; }
        public List<Signature> signatures { get; set; }
    }
}
