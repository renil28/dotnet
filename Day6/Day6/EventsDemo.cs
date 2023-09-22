using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    //Using Events in C#
    delegate void OrderEventHandler();
    class Order
    {
        public event OrderEventHandler OnOrderCreated;
        public void Create()
        {
            Console.WriteLine("Order Created");
            //SMS.send();
            //Email.send();
            if(OnOrderCreated != null)
            {
                OnOrderCreated();
            }
        }
    }

    class SMS
    {
        public static void send()
        {
            Console.WriteLine("SMS sent");
        }
    }

    class Email
    {
        public static void send()
        {
            Console.WriteLine("Email sent");
        }
    }
    internal class EventsDemo
    {
        public static void Main() 
        {
            var Order = new Order();
            Order.OnOrderCreated += Email.send;
            Order.OnOrderCreated += SMS.send;
            Order.Create();

        }
    }
}
