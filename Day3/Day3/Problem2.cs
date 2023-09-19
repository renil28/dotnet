using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects. 
To do this, first create a Person class that has a Name property of type string, a constructor that receives the name as a parameter,
a destructor that assigns the name to empty and overwrites the ToString () method.

End the program by reading the people and executing the ToString () method on screen.

Input
Juan
Sara
Carlos
Output
Hello! My name is Juan
Hello! My name is Sara
Hello! My name is Carlos
*/

namespace Day3
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
        ~Person()
        {
            Name = String.Empty;
        }
    }
    internal class Problem2
    {
        public static void Main9()
        {
            Person[] p = new Person[3];
            for(int i = 0; i < p.Length; i++)
            {
                p[i] = new Person(Console.ReadLine());
            }

            for(int i = 0;i < p.Length; i++)
            {
                Console.WriteLine(p[i].ToString());
            }

            
        }
    }
}
