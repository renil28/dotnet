using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    //The following program demonstrates different collections available 
    //such as List, Queue, Dictionary, Stack, HashSet and LinkedList
    internal class CollectionsDemo
    {
        public static void Main()
        {
            //Using Dictionary
            Console.WriteLine("Dictionary:");
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1,"Renil");
            dict.Add(2, "Renil 1");
            dict.Add(3, "Renil 2");
            dict.Add(4, "Renil 3");
            dict.Remove(3);
            foreach (var item in dict)
            {
                Console.WriteLine(item.Value);
            }

            //Using List
            Console.WriteLine("--------------");
            Console.WriteLine("List:");
            List<string> list = new List<string>();
            list.Add("Renil");
            list.Add("Renil 1");
            list.Add("Renil 2");
            list.Add("Renil 3");
            list.RemoveAt(1);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
           
            //Using Stack
            Console.WriteLine("--------------");
            Console.WriteLine("Stack:");
            Stack<string> stack = new Stack<string>();
            stack.Push("Renil 1");
            stack.Push("Renil 2");
            stack.Push("Renil 3");
            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            //Using Queue
            Console.WriteLine("--------------");
            Console.WriteLine("Queue:");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Renil 1");
            queue.Enqueue("Renil 2");
            queue.Enqueue("Renil 3");
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            //Using Linked List
            Console.WriteLine("--------------");
            Console.WriteLine("Linked List:");
            LinkedList<string> values = new LinkedList<string>();
            values.AddFirst("Renil 1");
            values.AddLast(" Renil 2");
            values.Clear();
            values.AddLast("Renil 3");
            values.AddFirst("Renil 1");
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            //Using Hash Set
            Console.WriteLine("--------------");
            Console.WriteLine("Hash Set:");
            HashSet<string> set = new HashSet<string>();
            set.Add("Renil 1");
            set.Add("Renil 2");
            set.Clear();
            set.Add("Renil 3");
            set.Add("Renil 4");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }


        }
    }
}
