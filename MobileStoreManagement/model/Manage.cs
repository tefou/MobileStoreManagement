using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace MobileStoreManagement.model
{
    public class Manage
    {
        private Store store;
        private List<Purchase> purchases;

        public Manage()
        {
            store = new Store();
            purchases = new List<Purchase>();
        }

        public void AddMobilePhone()
        {
            Console.Write("Enter Phone Name: ");
            string phonename = Console.ReadLine();
            Console.Write("Enter Manufacturer: ");
            string manufacturer = Console.ReadLine();
            Console.Write("Enter Stock Quantity: ");
            int stockQuantity = int.Parse(Console.ReadLine());
            Console.Write("Enter Price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Product Id: ");
            string productId = Console.ReadLine();

            MobilePhone phone = new MobilePhone(phonename, manufacturer, stockQuantity, price, productId);
            store.AddMobilePhone(phone);
            Console.WriteLine("Mobile Phone Added Successfully.");
        }

        public void RemoveMobilePhone()
        {
            Console.Write("Enter Product Id to Remove: ");
            string productId = Console.ReadLine();
            store.RemoveMobilePhone(productId);
            Console.WriteLine("Mobile Phone Removed successfully.");
        }

        public void DisplayAllMobilePhones()
        {
            store.DisplayAllMobilePhones();
        }

        public void MakePurchase()
        {
            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Customer Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter Customer ID Card: ");
            string memberId = Console.ReadLine();

            Customer customer = new Customer(name, address, memberId);

            Console.Write("Enter Purchase Id: ");
            string purchaseId = Console.ReadLine();

            List<string> productIds = new List<string>();
            {
                Console.Write("Enter Product Id of Mobile Phone to Purchase (or enter'd' to Finish): ");
                string productId = Console.ReadLine();
                if (productId.ToLower() == "done")
                {
                    return;
                }
                productIds.Add(productId);
            }

            DateTime purchaseDate = DateTime.Now;
            Purchase purchase = new Purchase(purchaseId, purchaseDate, customer);

            foreach (var productId in productIds)
            {
                MobilePhone phone = store.SearchMobilePhoneById(productId);
                if (phone != null)
                {
                    purchase.AddPhoneToPurchase(phone);
                }
                else
                {
                    Console.WriteLine($"Mobile Phone with Product Id {productId} not found.");
                }
            }

            purchases.Add(purchase);
            Console.WriteLine("Purchase Completed Successfully.Thanks You :333");
        }

        public void DisplayAllPurchases()
        {
            foreach (var purchase in purchases)
            {
                Console.WriteLine(purchase);
            }
        }

        public void SearchMobilePhoneById()
        {
            Console.Write("Enter ProductId to Search: ");
            string productId = Console.ReadLine();
            MobilePhone phone = store.SearchMobilePhoneById(productId);
            if (phone != null)
            {
                Console.WriteLine(phone);
            }
            else
            {
                Console.WriteLine("Mobile Phone not found :<<<");
            }
        }
    }
}
