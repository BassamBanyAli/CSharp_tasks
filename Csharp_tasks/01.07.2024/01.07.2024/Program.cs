using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1=new Car(2024,"Marcedes", 30000, "Benz", "2323232", "white");
            car1.display();
            bool engine = car1.start_engine();
            Console.WriteLine(engine);
            bool engine2 = car1.start_engine();
            Console.WriteLine(engine2);
            BMW car2 = new BMW(2022, 50000, "X5", "ABC123", "Black");
            car2.display();
        }
    }
}
