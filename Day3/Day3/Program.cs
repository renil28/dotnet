namespace Day3
{
    //This program will demonstrate Overloading
    public class OverloadingDemo
    {
        public void sum(int a, int b)
        {
            Console.WriteLine("Sum: "+ (a + b));
        }
        public void sum(int a, int b, int c)
        {
            Console.WriteLine("Sum: "+( a + b + c));
        }
        public void sum()
        {
            Console.WriteLine("I am Empty");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OverloadingDemo demo = new OverloadingDemo();
            demo.sum();
            demo.sum(1,2);
            demo.sum(1,2, 3);
        }
    }
}