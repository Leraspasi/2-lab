using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress();
            adress.Index = 201900;
            adress.Country = "Украина";
            adress.City = "Киев";
            adress.Street = "Шумского";
            adress.House = 3;
            adress.Apartment = 120;
            adress.Method();
            Console.ReadKey();
        }
    }
    class Adress
    {
        private int index;
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        private string country;
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        private string city;
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        private string street;
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        private int house;
        public int House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        private int apartment;
        public int Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }

        public void Method()
        {
            Console.WriteLine($"Индекс - {index}, Страна {country}, Город {city}");
            Console.WriteLine($"Улица {street}, Дом {house}, Квартира {apartment}");
        }
    }
}
