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
    public class Rent
    {
        private static int _id;
        public int Id { get; set; }
        public int DepoId {  get; set; }
        public int CustomerId {  get; set; }
        public double RentArea {  get; set; }
        public Rent(int depoid,int customerid,double rentarea)
        {
            Id =++_id;
            DepoId = depoid;
            CustomerId = customerid;
            RentArea = rentarea;
        }
    }
}
