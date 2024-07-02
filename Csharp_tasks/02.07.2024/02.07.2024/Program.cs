using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 class Car
{
    string make;
    string year;
    string type;
    string price;
    string model;
    string pallet_no;
    string color;
    public Car( string make,string year, string type,string price,string model,string pallet_no,string color)
    {
        this.make = make;
        this.year = year;
        this.type = type;
        this.price = price;
        this.model = model;
        this.pallet_no = pallet_no;
        this.color = color;
        
    }
    public Car() { }
    public void DisplayInfo(string make,string year)
    {
        this.make = make;
        this.year = year;
        Console.WriteLine($"the make's car is {this.make} and the year is {this.year}");
    }
    public void DisplayInfo(string make)
    {
        this.make = make;
        Console.WriteLine($"the make's car is {this.make} ");
    }
    public void Display()
    {
        Console.WriteLine("Welcome Car");
    }



}


 class BMW:Car
{
     public BMW (string make, string year, string price, string model, string pallet_no, string color)
        :base(make,year,"BMW",price,model,pallet_no,color)
    {

    }
    public BMW() { }
    public void Display()
    {
        Console.WriteLine("Welcome BMW");
    }
}


namespace _02._07._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            BMW car2 = new BMW();
            car1.Display();
            car2.Display();
        }
    }
}
