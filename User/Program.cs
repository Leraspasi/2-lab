using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Login = "user387";
            user.Name = "Alex";
            user.LastName = "Ivanov";
            user.Age = 25;
            user.Info();
            Console.ReadKey();
        }
    }
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public readonly DateTime dateTime = new DateTime(2020, 12, 03);

        public void Info()
        {
            Console.WriteLine($"Login --- {Login}");
            Console.WriteLine($"Name --- {Name}");
            Console.WriteLine($"LastName --- {LastName}");
            Console.WriteLine($"Age --- {Age}");
            Console.WriteLine($"DateTime --- {dateTime}");
        }

    }
}
