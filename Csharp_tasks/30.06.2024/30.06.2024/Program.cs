using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._06._2024
{
    internal class Program
    {

        //1-	 Write a function in C# that accept 10 numbers and return sum and average.

        static void sum_and_average(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];



            }
            double average = sum / arr.Length;
            Console.WriteLine($"the summation is {sum} and the average is{average}");
        }

        //2-	Write a program in C to display the cube of the number up to given an integer.

        static void cupe(int[] arr2)
        {
            foreach (int i in arr2)
            {
                Console.WriteLine($" the cupe of number{i} is {i * i * i}");
            }
        }

        //3-	Write a program in C# return only numbers in the years array greater than 1950.

        static void print_arr(int[] arr)
        {
            foreach (int i in arr)
            {
                if (i > 1950)
                    Console.WriteLine(i);
            }
        }

        //4-	Create a function that takes the age in years and returns the age in days.

        static int years_in_days(int years)
        {
            return years * 365;
        }

        //5-	Create class that contain the following field:

        public class person
        {
             int Id;
             string Name;
             int Age;
            string Gender;
            string Email;
            string Phone;

             public person(int id,string name,int age,string gender,string email,string phone)
            {
                Id=id;
                Name=name;
                if (age > 18 && age < 60)
                    Age = age;
                else
                    throw new Exception("error input age");
                Gender=gender;
                Email=email;
                if (phone.Substring(0, 3) == "079" || phone.Substring(0, 3) == "078" ||phone.Substring(0, 3) == "077")
                    Phone = phone;
                else
                    throw new Exception("error in phone number");
            }
            public void displayInformation()
            {
                Console.WriteLine($"the id is {Id} and the name is {Name} \n and the age is {Age} and gender is {Gender} \n and the email is {Email} and the phone is {Phone}");
            }

        }
        static void Main(string[] args)
        {

            //task 1
            double[] arr = new double[10];
            for (int i = 0; i < arr.Length; i++)

            {
                arr[i] = double.Parse(Console.ReadLine());
            }
            sum_and_average(arr);

            //task 2

            int[] arr2 = new int[5];
            for (int i = 0; i < arr2.Length; i++)

            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            cupe(arr2);

            //task 3
            int[] years = new int[] { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            print_arr(years);

            //task 4
            int years_days = int.Parse(Console.ReadLine());
            Console.WriteLine(years_in_days(years_days));

            //task 5
            person p1 = new person(10101, "Bassam Bany Ali", 24, "male", "bassambanyali@gmail.com", "0798869218");
            p1.displayInformation();

        }
    }
}

