// See https://aka.ms/new-console-template for more information
using MobileStoreManagement.model;

class Program
{
    static void Main(string[] args)
    {
        Manage manage = new Manage();

        while (true)
        {
            Console.WriteLine("================================================================================================================");
            Console.WriteLine("---Mobile Store Management System---");
            Console.WriteLine("1. Add Mobile Phone");
            Console.WriteLine("2. Remove Mobile Phone");
            Console.WriteLine("3. Display All Mobile Phones");
            Console.WriteLine("4. Customer Purchase");
            Console.WriteLine("5. Display All Purchases");
            Console.WriteLine("6. Search Mobile Phone By ProductId");
            Console.WriteLine("0. Exit");
            Console.Write("Select an option: ");

            int option;
            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid option. Please try again.");
                continue;
            }

            switch (option)
            {
                case 1:
                    manage.AddMobilePhone();
                    break;
                case 2:
                    manage.RemoveMobilePhone();
                    break;
                case 3:
                    manage.DisplayAllMobilePhones();
                    break;
                case 4:
                    manage.MakePurchase();
                    break;
                case 5:
                    manage.DisplayAllPurchases();
                    break;
                case 6:
                    manage.SearchMobilePhoneById();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
