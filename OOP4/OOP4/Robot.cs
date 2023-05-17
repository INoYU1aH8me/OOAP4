using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class Robot
    {
        static string[] ModelNames = new string[] { "Apple", "Samsung", "Yandex", "Xiaomi", "Microsoft" };      
        static Random random = new Random();
        public string modelName;
        public string ID;

        public Robot()
        {
            modelName = ModelNames[random.Next(0, ModelNames.Length)];    
            ID = random.Next(1, 100).ToString()+"R";
        }
    }
}
