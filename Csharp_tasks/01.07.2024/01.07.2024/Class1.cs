using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._2024
{
    public class Car
    {
        int year;
        string type;
        double price;
        string model;
        string pallet_no;
        string color;
        bool isRunning = false;
        public Car(int year, string type, double price, string model, string pallet_no, string color)
        {
            this.year = year;
            this.type = type;
            this.price = price;
            this.model = model;
            this.pallet_no = pallet_no;
            this.color = color;
        }
        public bool start_engine()
        {
            if (!isRunning)
            {
                isRunning = true;
                return isRunning;
            }
            else {
                isRunning=false;
                return isRunning;}
           
        }
        public void display()
        {
            Console.WriteLine($" the year is {year}, the type is{type},the price is {price},\n the model is {model},the pallet is{pallet_no},the color is{color}");
        }
    }
}

