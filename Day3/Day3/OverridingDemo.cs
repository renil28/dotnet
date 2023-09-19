using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This program demonstrates overriding
namespace Day3
{
    class Animal
    {
        //Use virtual keyword before override 
        public virtual void show()
        {
            Console.WriteLine("I am base class");
        }
        public string name;
    }
    class Dog : Animal
    {
        //shadowing
        new int name;
        public override void show()
        {
            Console.WriteLine("I am Derived Class");
        }
    }
    internal class OverridingDemo
    {
        static void Main(string[] args) { 
        Dog dogdemo = new Dog();
        dogdemo.show();
        Console.WriteLine("----------");
        Animal animal = new Dog();
        animal.show();
        }
    }
}
