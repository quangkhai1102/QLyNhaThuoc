using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicine_store.model
{
    internal class Invoice
    {
        public string customerID {  get; set; }
        public string adminID { get; set; }
        public string date {  get; set; }
        public double totalAmount { get; set; }

        public Invoice() { }
        public Invoice(string customerID, string adminID, string date, double totalAmount)
        {
            this.adminID = adminID;
            this.customerID = customerID;
            this.date = date;
            this.totalAmount = totalAmount;
        }
    }
}
