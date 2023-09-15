using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Person
    {
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }

        public int SetAge(int age)
        {
            return age;
        }

    }

    public class Student:Person
    {
        public void Study()
        {
           Console.WriteLine("I am Studying!");

        }
        public void ShowAge()
        {
            int age = 21;
            SetAge(age);
            Console.WriteLine("My age is " + age + " years old!");
        }
    }
    class Teacher:Person
    {
       public void Explain()
        {
            Console.WriteLine("I am Explaining!");

        }
    }
    internal class InheritenceDemo
    {
        public static void Main3(string[] args )
        {
            Person person = new Person();
            person.Greet();
            Student student = new Student();
            student.Greet();
            student.ShowAge();
            student.Study();
            Teacher teacher = new Teacher();
            teacher.Greet();
            teacher.Explain();

        }
    }
}
