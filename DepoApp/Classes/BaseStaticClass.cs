using DepoApp;
using DepoApp.Classes;
using DepoApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoApp.Classes
{
    public class BaseStaticClass
    {
        public static int EnterChoosens()
        {
            Console.WriteLine("Programdan cixis etemek ucun 0 secim edin");
            Console.WriteLine("Company Depo elave etemek ucun 1 secim edin");
            Console.WriteLine("Depoya customer elave etmek ucun 2 secim edin");
            Console.WriteLine("Depo Rent etemek ucun 3 secim edin");
            Console.WriteLine("Elave olunmus depolari gormek ucun 4 secim edin");
            int result = int.Parse(Console.ReadLine());
            return result;
        }
        public static int EnterDepoId()
        {
            Console.WriteLine("Depo id daxil edin");
            int depoId = int.Parse(Console.ReadLine());
            return depoId;
        }

        public static Depo EnterDepoDetails()
        {
            Console.WriteLine("Depo adi daxil edin");
            string depoName = Console.ReadLine();
            Console.WriteLine("Umumi area daxil edin");
            double depoArea= double.Parse(Console.ReadLine());
            Depo depo = new Depo(depoName,depoArea);
            return depo;
        }
        public static Customer EnterCustomerDetails()
        {
            Console.WriteLine("Customer FirstName daxil edin");
            string customerFirstName = Console.ReadLine();
            Console.WriteLine("Customer LastName daxil edin");
            string customerLastName = Console.ReadLine();
            Console.WriteLine("Customer mail daxil edin");
            string customerMail = Console.ReadLine();
            Customer customer = new Customer(customerFirstName,customerLastName,customerMail);
            return customer;
        }
    }
}
