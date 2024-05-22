using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStoreManagement.model
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string IDcard { get; set; }

        public Customer(string name, string address, string idcard)
        {
            Name = name;
            Address = address;
            IDcard = idcard;
        }

        public override string ToString()
        {
            return $"\n Name: {Name}\n Address: {Address}\n Customer ID Card: {IDcard}";
        }
    }
}
