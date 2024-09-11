using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicine_store.model
{
    internal class InvoiceDetail
    {
        public string invoiceID {  get; set; }
        public string medicineID { get; set; }
        public int quantity { get; set; }
        public decimal unitPrice { get; set; }
        public double subtotal { get; set; }

        public InvoiceDetail() { }
        public InvoiceDetail(string invoiceID, string medicineID, int quantity, decimal unitPrice, double subtotal)
        {
            this.invoiceID = invoiceID;
            this.medicineID = medicineID;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
            this.subtotal = subtotal;
        }
    }
}
