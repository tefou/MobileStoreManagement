using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStoreManagement.model
{
    public class Purchase
    {
        public string PurchaseId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Customer Customer { get; set; }
        public List<MobilePhone> PurchasedPhones { get; set; } = new List<MobilePhone>();

        public Purchase(string purchaseId, DateTime purchaseDate, Customer customer)
        {
            PurchaseId = purchaseId;
            PurchaseDate = purchaseDate;
            Customer = customer;
        }

        public void AddPhoneToPurchase(MobilePhone phone)
        {
            PurchasedPhones.Add(phone);
        }

        public override string ToString()
        {
            string phoneDetails = string.Join("\n", PurchasedPhones.Select(p => p.ToString()));
            return  $"\n Purchase Id: {PurchaseId}\n Purchase Date: {PurchaseDate}" +
                    $"\n " +
                    $"\n ---Customer--- \n{Customer} " +
                    $"\n " +
                    $"\n ---Purchased Phones--- \n{phoneDetails}";
        }
    }
}
