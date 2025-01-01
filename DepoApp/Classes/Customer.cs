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
    public class Customer
    {
        private static int _id;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }

        public Customer(string firstname, string lastname, string mail)
        {
            Id = ++_id;
            FirstName = firstname;
            LastName = lastname;
            Mail = mail;
        }
        public override string ToString()
        {
            return $"{Id},{FirstName},{LastName}";
        }
    }
}
