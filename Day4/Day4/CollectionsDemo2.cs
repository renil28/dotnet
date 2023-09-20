using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    //This program demonstrates using only collections such as
    // ArrayList, Queue, Stack, Hashtable
    internal class CollectionsDemo2
    {
        public static void Main()
        {
            //Using ArrayList
            Console.WriteLine("ArrayList");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);   
            arrayList.Add("Hello!");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //Using Stack
            Console.WriteLine("------------");
            Console.WriteLine("Stack");
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push("Hello!");
            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            //Using Queue
            Console.WriteLine("------------");
            Console.WriteLine("Queue");
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            queue.Enqueue(4);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            //Using Hashtable
            Console.WriteLine("------------");
            Console.WriteLine("Hashtable");
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, 1);
            hashtable.Add(2, 2);
            hashtable.Add(3, 3);
            hashtable.Clear();
            hashtable.Add(4, 4);
            hashtable.Add(5, 5);
            foreach (DictionaryEntry de in hashtable)
            {
                Console.WriteLine("Key: {0}, Value: {1}", de.Key,de.Value);
            }


        }
    }
}
