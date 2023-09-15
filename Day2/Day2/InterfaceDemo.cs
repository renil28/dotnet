using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    interface IVehiculo
    {
        public void Drive();
        public bool Refuel(int gasoline);
    }
    class Car : IVehiculo
    {
        public Car(int _gas)
        {
            Gas = _gas;
        }
        int Gas;
        public void Drive()
        {
            if (Gas >= 1) {
                Console.WriteLine("The Car is Driving");
            }
            else
            {
                Console.WriteLine("Low Fuel");
            }
        }
        public bool Refuel(int gasoline)
        {
            Gas += gasoline;
            return true;
        }
    }
    internal class InterfaceDemo
    {
        static void Main4(string[] args)
        {
            Car c = new Car(0);
            c.Drive();
            c.Refuel(Convert.ToInt32(Console.ReadLine()));
            c.Drive();


        }
    }
}
