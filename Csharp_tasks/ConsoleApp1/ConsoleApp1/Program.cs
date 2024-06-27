using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //// task 1
            //string name=Console.ReadLine();
            //Console.WriteLine("the string is "+name);



            ////task 2
            //double x = 22.5;
            //string str="bassam";
            //char c = 'r';
            //bool t= false;
            //int y = 22;
            //const int z= 22;
            //Console.WriteLine(" double x=" + x);
            //Console.WriteLine("string str=" + str);
            //Console.WriteLine(" char c=" + c);
            //Console.WriteLine(" bool t=" + t);
            //Console.WriteLine(" int y =" + y);
            //Console.WriteLine(" const int z =" + z);

            //task 3

            string[] car = { "lanser", "nissan", "ferrari", "hondai" };
            Console.WriteLine("the first car is " + car[0] + " \n the second car is " + car[1] + "\n the third car is " + car[2] + "\n the fourth car is " + car[3]);
            // task 4

            string first_name = Console.ReadLine();
            string last_name = Console.ReadLine();
            string year = Console.ReadLine();
            Console.WriteLine(first_name + " " + last_name + " " + year);

            //task 5

            int[] testData = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(testData[0] + "," + testData[1]+"," + testData[2]+"," + testData[3]+"," + testData[4] + "," + testData[5]+"," + testData[6] + "," + testData[7] + "," + testData[8] + "," + testData[9]);

            //task 6

            int[] arr2 = { 2, 5, 8 };
            int sum = 0;
            foreach (int i in arr2)
            {
                sum += i;
            }
            Console.WriteLine("the sum is " + sum);
        }
    }
}
