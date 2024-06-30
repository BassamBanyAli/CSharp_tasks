using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._06._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1-	Correct the syntax error:

            int[] ARR = { 1, 7, 9, 45 };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };


            //2-	What the index of "Banana","Tomato"?


            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            int index = 0;
            foreach (string i in fruits)
            {
                if (i == "Banana")
                    Console.WriteLine($"the index of Banana is {index}");
                else if (i == "Tomato")
                    Console.WriteLine($"the index of Tomato is {index}");
                index++;

            }

            //3-	Create an multiple arrays that represents your:


            string[] food = { "shawerma", "burger", "makmora", "mansef", "magloba" };
            string[] sports = { "footbal", "tennis", "basketball" };
            string[] Movies = { "Game of Throns", "The House of Targerian", "Harry Poter", "Lacasa De Pabel" };
            Console.WriteLine("my favourite Foods is");
            foreach (string i in food)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("my favourite Sports is");
            foreach (string i in sports)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("my favourite Movies is");
            foreach (string i in Movies)
            {
                Console.WriteLine(i);
            }


            /*4-	Write a program in C# to calculate the sum
             * of three numbers with getting input in one line separated by a comma*/

            Console.WriteLine("please input three numbers");
            string input = Console.ReadLine();
            string[] numbers = input.Split(',');

            if (numbers.Length == 3 &&
            double.TryParse(numbers[0], out double num1) &&
            double.TryParse(numbers[1], out double num2) &&
            double.TryParse(numbers[2], out double num3))
            {
                double sum = num1 + num2 + num3;
                Console.WriteLine(sum);


            }
            else
            {

                Console.WriteLine("Invalid input. Please enter exactly three numbers separated by commas.");

            }
            //5-	Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]. 

            int summation = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    summation += i;

                }

            }
            Console.WriteLine($"the summation for odd numbers is {summation}");


            //6-	Write a program in C## to display the pattern like right angle triangle using an asterisk. Go to the editor

            string str = "";
            for (int i = 0; i <4; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write(" ");
                }
                str += " *";
                Console.WriteLine(str);
            }

            //7- Write a program in C# to make such a pattern like right angle triangle with number increased by 1. Go to the editor
            int str_num = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= str_num; k++) { 
                Console.Write($" {k}");
                }
                Console.WriteLine("");
                str_num++;



            }

        }

    }
}

