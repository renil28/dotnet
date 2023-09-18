using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Class1
    {
        //Optional Parameter
        public static void print(int a, int b =2)
        {
            Console.WriteLine(a + ", " + b);
        }

        //Named Parameter
        public static void printNamed(int a, int b, int c)
        {
            Console.WriteLine(a + ", " + b + ", " + c);
        }

        static void Main7(string[] args)
        {
            //Parse, TryParse and Class Convert
            //TryParse raises True or False
            //Parse and Class Convert Raise Exception
            int sample;
            Console.WriteLine("Please Enter a Value!");
            string value = Console.ReadLine();
            bool result = int.TryParse(value, out sample);
            if (result == true)
            {
                Console.WriteLine("Given Value: " + sample);
                Console.WriteLine("It is an integer!");

            }
            else
            {
                Console.WriteLine("It is not an integer");
                Console.WriteLine("Converted Value: " +sample);
            }

            //Console.WriteLine(result);
            //Console.WriteLine(sample);
            
            //Using is keyword
            string s = "Renil";
            int a = 1;
            string s1 = "Justin";
            if(a is string)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Not a String!");
            }

            //Using as keyword
            Object[] objects = new object[4];
            objects[0] = 1;
            objects[1] = "Renil";
            objects[2] = 2;
            objects[3] = "Justin";
            for(int i = 0; i < objects.Length; i++)
            {
                if(objects[i] is string)
                {
                    Console.WriteLine(objects[i]);
                }
                else
                {
                    var x = objects[i] as string;
                    Console.WriteLine(x);
                }
            }

            //Using StringBuilder
            string x1 = "1";
            x1 = "2";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(x1);   
            stringBuilder.Append("Renil");
            Console.WriteLine(stringBuilder);

            //Using Optional Parameters
            print(1, 2);

            //Using Named Parameter
            printNamed(1,2,4);
        }
    }
}
