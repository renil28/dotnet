namespace Day5
{
    internal class Program
    {
        //This Program Demonstrates File Handling with the use of 
        //StreamReader and StreamWriter Class
        static void Main1(string[] args)
        {
            string FilePath = "C:\\Users\\Administrator\\Desktop\\Dot Net Lab\\Day5\\Day5\\files\\test.txt";
            StreamWriter s = new StreamWriter(FilePath);
            Console.WriteLine("Please Enter Some Value");
            string valueToWriteInFile = Console.ReadLine();
            s.WriteLine(valueToWriteInFile);
            s.Flush();
            s.Close();

            StreamReader sr = new StreamReader(FilePath);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string output = sr.ReadLine();
            Console.WriteLine("Value from file is " + output);
            Console.WriteLine("Hello, World!");
        }
    }
}