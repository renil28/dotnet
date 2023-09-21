namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter s = new StreamWriter("C:\\Users\\Administrator\\Desktop\\Dot Net Lab\\Day5\\Day5\\files\\test.txt");
            s.Write("Hello Renil");
            s.Flush();
            s.Close();
            Console.WriteLine("Hello, World!");
        }
    }
}