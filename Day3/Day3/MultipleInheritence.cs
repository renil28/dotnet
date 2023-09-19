using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    //Demonstrating Multiple Inheritence in C#
    interface IA
    {
        public void show();
    }

    interface IB { 

        public void print();
        public void show();
    }    

    //Create a class C refering the interfaces
    class C : IA, IB
    {
        void IA.show()
        {
            Console.WriteLine("I am in the show of IA");
        }
        public void print()
        {
            Console.WriteLine("I am in the print of IB");
        }

        //Using interface.method() incase of same methods
        //in multiple interfaces
        void IB.show()
        {
            Console.WriteLine("I am in the show of IB");
        }
    }
    internal class MultipleInheritence
    {
        static void Main(string[] args)
        {
            //Show the print method
            C c = new C();
            c.print();

            //Since there are two methods called show in interface 
            //IA and IB, we declare it this way
            IA a = new C();
            a.show();
            IB b = new C();
            b.show();
        }
    }
}
