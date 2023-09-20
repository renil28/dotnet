namespace Day4
{
    //Example of using struct in the program
    struct Employee
    {
        public int EmployeeId;
        String EmployeeName;

        public void GetEmployeeDetails()
        {
            Console.WriteLine("Please Enter Employee ID");
            EmployeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Employee Name");
            EmployeeName = Console.ReadLine();
        }

        public void PrintEmployeeDetails()
        {
            Console.WriteLine("Employee ID: " + EmployeeId);
            Console.WriteLine("Employee Name: " + EmployeeName);
        }
    };

    /* Destructor Example
    class Sample { 

        public int MyProperty { get; set; }
        public Sample()
        {
            
        }

        //This is a destructor
        ~Sample() { }
       //Destructor releases the memory
    }
    */
    internal class StructProgram
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.GetEmployeeDetails();
            emp.PrintEmployeeDetails();
        }
    }
}