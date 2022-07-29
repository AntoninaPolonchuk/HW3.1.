using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adress myAdres = new Adress(78499, "Украина", "Киев", "Вильямса", 10, 56);
            myAdres.Wr();

            Console.ReadKey();
         
        }
    }

    class Adress
    {
        int index;
        string country;
        string city;
        string street;
        int house;
        int apartment;

        int Index
        {
            get { return index; }
            set { index = value; }
        }
        string Country
        {
            get { return country; }
            set { country = value; }
        }

        string City
        { get { return city; }
            set { city = value; }
        }
        string Street
        {
            get { return street; }
            set { street = value; }
        }

        int House
        {
            get { return house; }
            set { house = value; }
        }
        int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

        public Adress(int index, string country, string city, string street, int house, int apartment)
        {
            this.index = index;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartment = apartment;
        }

        public void Wr()
        {
            Console.WriteLine($"Адрес: { index}, страна { country}, город { city}, улица { street}, дом { house}, квартира { apartment}");
        }
    }
}
