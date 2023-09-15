using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    //abstract /sealed
    //object creation is not allowed
    //sealed extension is not allowed
    abstract class Animal2
    {
        protected string name;

        // public Animal() { }
        public void SetName(string _name)
        {
            name = _name;
        }
        public void GetName()
        {

        }

        protected abstract void Eat();
       

    }
    class Dog : Animal
    {
        public Dog(string _name) : base(_name)
        {

        }
        public void Eat() 
        {
            string _message = "The Dog is Eating";
            Console.WriteLine(_message);

        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }
    }

    internal class AbstractNew
    {
        static void Main6(string[] args)
        {
           string nameDog = Console.ReadLine();
           Dog d = new Dog(nameDog);
            d.PrintName();
            d.Eat();
        }
    }
}