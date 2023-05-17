using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class Human
    {
        static string[] FirstNames = new string[]{ "Ivan", "Nikolay", "Igor", "Oleg", "Mikhail", "Sergey", "Roman" };
        static string[] LastNames = new string[] { "Messi", "Petrov", "Ivanov", "Olegov", "Mikhailov", "Ronaldo", "Pele" };

        static Random random = new Random();
        public string firstName;
        public string lastName;
        public int age;

        public Human()
        {
            firstName = FirstNames[random.Next(0, FirstNames.Length)];
            lastName = LastNames[random.Next(0, LastNames.Length)];
            age = random.Next(21, 35);
        }        
    }
}
