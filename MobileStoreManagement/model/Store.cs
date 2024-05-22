using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStoreManagement.model
{
    public class Store
    {
        public List<MobilePhone> MobilePhones { get; private set; } = new List<MobilePhone>();

        public void AddMobilePhone(MobilePhone phone)
        {
            MobilePhones.Add(phone);
        }

        public void RemoveMobilePhone(string productId)
        {
            var phone = MobilePhones.FirstOrDefault(p => p.ProductId == productId);
            if (phone != null)
            {
                MobilePhones.Remove(phone);
            }
        }

        public void DisplayAllMobilePhones()
        {
            foreach (var phone in MobilePhones)
            {
                Console.WriteLine(phone);
            }
        }

        public MobilePhone? SearchMobilePhoneById(string productId)
        {
            return MobilePhones.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
