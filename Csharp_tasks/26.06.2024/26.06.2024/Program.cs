using System;

namespace _26._06._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //task 1
            int x = 4;
            int y = 2;
            if (x > y)
                Console.WriteLine("x=" + x + "the larger");
            else
                Console.WriteLine("y=" + y + "the larger");
            //task 2
            int input = int.Parse(Console.ReadLine());
            if (input < 0)
                Console.WriteLine("the sign is -");
            else
                Console.WriteLine("the sign is +");

            //task 3
            int num1 = 0;
            int num2 = -1;
            int num3 = 4;
            int temp;
            if (num1 < num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }
            else if (num1 < num3)
            {
                temp = num1;
                num1 = num3;
                num3 = temp;

            }
            else if (num2 < num3)
            {
                temp = num2;
                num2 = num3;
                num3 = temp;
            }
            Console.WriteLine($"Sorted numbers: {num1}, {num2}, {num3}");

            //task 4
            int[] arr2 = new int[5] { -5, -2, -6, 0, -1 };

            int max;
            max = arr2[0];
            foreach (int i in arr2)
            {
                if (i > max)
                    max = i;

            }
            Console.WriteLine(max);

            //task 5
            double input_kelo = 15;
            double meile = input_kelo * 0.621371;
            Console.WriteLine(meile);


            //task 6
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine(hour * 60 + min);

            //task 7
            int minutes = int.Parse(Console.ReadLine());
            Console.WriteLine($"{minutes / 60} hours and {minutes % 60} minutes");


            //task 8

            string[] arr_str = new string[5] { "bassam", "bany ali", "24", "computer engineer", "male" };

            Console.WriteLine($"{arr_str[0]} with the length is {arr_str[0].Length} \n {arr_str[1]} with the length is {arr_str[1].Length} \n {arr_str[2]} with the length is {arr_str[2].Length} \n {arr_str[3]} with the length is {arr_str[3].Length} \n {arr_str[4]} with the length is {arr_str[4].Length}");

        }
    }
}
