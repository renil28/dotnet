namespace Day6
{
    //This program demonstrates the use of extension methods
    class Test
    {
        public void Print()
        {
            Console.WriteLine("Print Method");
        }
    }

    static class TestExtension
    {
        static public void PrintNew(this Test test)
        {
            Console.WriteLine("Print New Definition");
        }
    }
    internal class Program
    {
     
        static void Main1(string[] args)
        {
            Test test = new Test();
            test.Print();
            test.PrintNew();
            //Test test1 = new Test();
            //test1.PrintNew();
        }
    }
}