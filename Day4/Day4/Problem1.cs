using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class StudentException : Exception
    {
        public StudentException()
        {

        }

        public StudentException(string message) : base(message)
        {

        }

    }
    
        struct Student
        {
            public int StudentID;
            public string StudentName;
        

        public void GetStudentDetails()
        {
            try { 
            Console.WriteLine("Please Enter Student ID");
            StudentID = Convert.ToInt32(Console.ReadLine());
            if (StudentID <= 0)
            {
                throw new StudentException();
            }
            else
            {
                Console.WriteLine("Please Enter Student Name");
                StudentName = Console.ReadLine();
            }
            }
            catch (StudentException em){
                Console.WriteLine("Hello!" + em.ToString());
            }
        }

        public void PrintStudentDetails()
        {
            Console.WriteLine("Student ID: " + StudentID);
            Console.WriteLine("Student Name: " + StudentName);
        }
    }
    internal class Problem1
    {
        static void Main4(string[] args)
        {
            Student s = new Student();
            s.GetStudentDetails();
            s.PrintStudentDetails();
        }

    }
}
