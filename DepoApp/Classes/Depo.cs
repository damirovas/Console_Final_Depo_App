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
    public class Depo
    {
        private  static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Area {  get; set; }
        public double RemainingArea {  get; set; }
        static List<Customer> Custumers = new List<Customer>();

        public Depo(string name,double area)
        {
            Id = ++_id;
            Name = name;
            Area = area;
            RemainingArea = area;
        }
        public override string ToString()
        {
            return $"{Id} {Name}";
        }
        public void GetCustomers()
        {
            foreach(Customer customer in Custumers)
            {
                Console.WriteLine(customer.ToString());
            }
        }
        public void AddCustomer(Customer customer)
        {
            if(RemainingArea==0)
            {
                throw new Exceptions.NotEnoughField("Bu depoda kifayet geder yer yocdur");
            }
            else
            {
                Custumers.Add(customer);
            }
        }
        

    }
    
}
