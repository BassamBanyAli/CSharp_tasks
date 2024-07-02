using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ISound
{
    void MakeSound();
}

public abstract class Animal
{

    public Animal(string name)
    {
        Name = name;
    }
    public string Name { get; set; }

   public abstract void Eat();
    public abstract void Sleep();
}
public class Dog:Animal,ISound {
    public Dog(string name) : base(name)
    {
        Name=name;
    }
    public override void Eat()
    {
        Console.WriteLine($"the animals {Name} eating tomatto ");
    }
    public override void Sleep()
    {
        Console.WriteLine($"the animals is {Name} is sleeping");
    }
     public void MakeSound()
    {
        Console.WriteLine($" the animal is {Name} the sound is Woof!");
    }
    

    
}

public class Cat : Animal, ISound
{
    public Cat(string name) : base(name)
    {
        Name = name;
    }
    public override void Eat()
    {
        Console.WriteLine($"the animals {Name} eating tomatto ");
    }
    public override void Sleep()
    {
        Console.WriteLine($"the animals is {Name} is sleeping");
    }
    public void MakeSound()
    {
        Console.WriteLine($" the animal is {Name} the sound is Meow!");
    }



}




namespace _02._07._2024__task_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("cat");
            Dog dog = new Dog("dog");
            cat.Eat();
            cat.Sleep();
            cat.MakeSound();
            dog.Eat();
            dog.Sleep();
            dog.MakeSound();
        }
    }
}
