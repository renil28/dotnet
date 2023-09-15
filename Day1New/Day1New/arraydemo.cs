using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Day1New
{
    internal class arraydemo
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            int sum = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Number " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine("Sum: "+ sum);

            /*
            string name = "Renil";
            foreach(var item in name)
            {
                Console.WriteLine(item);
            }*/
            

            //Displaying Multi Dimensional Array
            int[,] demos = { { 1,2 }, { 3, 4 } };
            int[,] arr1 = { { 1, 2 }, { 3, 4 } };
            int[,] arr2 = { { 3, 1 }, { 4, 5 } };
            for (int row = 0; row <2; row++)
            {

                for (int col = 0; col < 2; col ++)
                {
                    Console.WriteLine("" + demos[row, col]);
                }
                Console.WriteLine();
                
            }

            //Adding two multidemsional arrays
            for (int r = 0; r < 2; r++)
            {

                for (int c = 0; c < 2; c++)
                {
                    Console.WriteLine(arr1[r, c] + arr2[r, c]);
                }
                Console.WriteLine();

            }

            //Jagged Arrays
            int[][] jaggedArrays = new int[2][];

            jaggedArrays[0] = new int[] { 1, 2, 3};
            jaggedArrays[1] = new int[] { 5, 7, 8, 0 };
            foreach(var item in jaggedArrays)
            {
                foreach(var item1 in item)
                {
                    Console.WriteLine(item1);
                }
                Console.WriteLine() ;
            }


        }
    }
}
