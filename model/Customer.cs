using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicine_store.model
{
    internal class Customer
    {
        public string fullName {  get; set; }
        public int age { get; set; }
        public string phone { get; set; }

        public Customer() { }
        public Customer(string fullName, int age, string phone)
        {
            this.fullName = fullName;
            this.age = age;
            this.phone = phone;
        }
    }
}
