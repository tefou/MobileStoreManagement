using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStoreManagement.model
{
    public class MobilePhone
    {
        public string phoneName { get; set; }
        public string Manufacturer { get; set; }
        public int StockQuantity { get; set; }
        public decimal Price { get; set; }
        public string ProductId { get; set; }

        public MobilePhone(string phonename, string manufacturer, int stockQuantity, decimal price, string productId)
        {
            phoneName = phonename;
            Manufacturer = manufacturer;
            StockQuantity = stockQuantity;
            Price = price;
            ProductId = productId;
        }

        public override string ToString()
        {
            Console.WriteLine("================================================================================================================");
            return $"\n Product Id: {ProductId}\n Name Phone: {phoneName}\n Manufacturer: {Manufacturer}\n Stock Quantity: {StockQuantity}\n Price: {Price}";
        }
    }

}
