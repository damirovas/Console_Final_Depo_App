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
    public class Company
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }

        //static List<Depo> Depos {  get; set; }=new List<Depo>();
        //static List<Rent> Rents { get; set; } = new List<Rent>();
        public static List<Depo> Depos = new List<Depo>();
        public static List<Rent> Rents = new List<Rent>();

        public Company(string name)
        {
            Id=++_id;
            Name=name;
        }
        public void AddDepo(Depo depo)
        {
            Depos.Add(depo);
        }
        public void GetAllDepos()
        {
            foreach(Depo depo in Depos)
            {
                Console.WriteLine(depo);
            }
        }
        public override string ToString()
        {
            return $"{Id} {Name}";
        }
        public Depo GetDepoById(int id)
        {
            Depo depo = Depos.SingleOrDefault(d=>d.Id==id);
            if(depo == null)
            {
                Console.WriteLine("Tapilmadi");
            }
            return depo;
        }
        public static Rent GetRent(int depoid, int customerid, double rentarea)
        {
            Depo depo = Depos.SingleOrDefault(d => d.Id == depoid);
            if (depo is null)
            {
                Console.WriteLine("Depo Tapilmadi");
                return null;
            }
            if (depo.RemainingArea >= rentarea)
            {
                Rent rent = new Rent(depoid, customerid, rentarea);
                Rents.Add(rent);
                depo.RemainingArea -= rentarea;
                Console.WriteLine($"Qalan yer {depo.RemainingArea}");
                return rent;

            }
            else
            {
                throw new DepoApp.Exceptions.NotEnoughField("Kifayet geder yer yoxdu");
                return null;

            }


        }


    }

}

