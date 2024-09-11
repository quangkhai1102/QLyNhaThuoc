using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicine_store.model
{
    internal class Medicine
    {
        private string medicineName {  get; set; }
        private string description { get; set; }
        private string manufacturer { get; set; }
        private double price { get; set; }
        private string packaging{ get; set;}

        public Medicine () { }

        public Medicine (string medicineName, string description, string manufacturer, double price, string packaging)
        {
            this.medicineName = medicineName;
            this.description = description;
            this.manufacturer = manufacturer;
            this.price = price;
            this.packaging = packaging;
        }
    }
}
