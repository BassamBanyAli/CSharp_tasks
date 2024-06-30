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
            int smaller = Math.Min(x, y);
            Console.WriteLine("The smaller number is: " + smaller);
            //task 2
            int input = int.Parse(Console.ReadLine());
            string[] signs = { "negative","zero" ,"positive"};
            int signIndex = Math.Sign(input)+1;
            Console.WriteLine("The sign of the number is: " + signIndex);



            //task 3
            int num1 = 0;
            int num2 = -1;
            int num3 = 4;
            int temp;
            int minimum = Math.Min(num1, Math.Min(num2, num3));
            int maximum = Math.Max(num1, Math.Max(num2, num3));
            int mid = (num1 + num2 + num3) - minimum - maximum;
            Console.WriteLine($"Sorted numbers: {maximum}, {mid}, {minimum}");

            //task 4
            int[] arr2 = new int[5] { -5, -2, -6, 0, -1 };
            Array.Sort(arr2);
            int max = arr2[arr2.Length - 1];
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

            string[] arr_str = new string[5] { "bassam", "bany ali", "2000/11/4", "computer engineer", "dddddddfdf" };

            Console.WriteLine($"{arr_str[0].Substring(0,6)} with the length is {arr_str[0].Substring(0, 6).Length} \n {arr_str[1].Substring(0, 6)} with the length is {arr_str[1].Substring(0, 6).Length} \n {arr_str[2].Substring(0, 6)} with the length is {arr_str[2].Substring(0, 6).Length} \n {arr_str[3].Substring(0, 6)} with the length is {arr_str[3].Substring(0, 6).Length} \n {arr_str[4].Substring(0, 6)} with the length is {arr_str[4].Substring(0, 6).Length}");

        }
    }
}
