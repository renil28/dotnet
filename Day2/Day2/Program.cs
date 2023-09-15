namespace Day2
{
    internal class Program
    {
        class Employee
        {
            private int id;
            private string name;
            private double salary;

            //Making a function to GetInput
            public void Getinput()
            {
                Console.WriteLine("Enter Employee Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary: ");
                salary = Convert.ToDouble(Console.ReadLine());
            }
            public void PrintEmployee()
            {
                Console.WriteLine("Employee Name: " +name);
                Console.WriteLine("Employee Salary: " + (salary));
            }
            public Employee()
            {
                Console.WriteLine("Employee Database");
            }
        }
        static void Main2(string[] args)
        {
           Employee emp = new Employee();
            emp.Getinput();
            emp.PrintEmployee();
        }
    }
}
