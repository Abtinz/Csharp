using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            int queueNumber;

            Console.WriteLine("Queue size: "+queue.Count);
            Console.WriteLine("Queue members:");
            queueNumber = queue.Dequeue();
            Console.Write(queueNumber+"  ");
            queueNumber = queue.Dequeue();
            Console.Write(queueNumber + "  ");
            queueNumber = queue.Dequeue();
            Console.Write(queueNumber + "  ");
            queueNumber = queue.Dequeue();
            Console.Write(queueNumber + "  ");
            queueNumber = queue.Dequeue();
            Console.Write(queueNumber + "\n\n");

            Stack<string> stack = new Stack<string>();
            stack.Push("project");
            stack.Push("queue");
            stack.Push("and");
            stack.Push("stack");
            stack.Push("Maktabkhooneh");
            stack.Push("#C");
            
            string stackNewValus;
            
            Console.WriteLine("stack size: "+stack.Count);
            Console.WriteLine("stack text:");
            stackNewValus = stack.Pop();
            Console.Write(stackNewValus+"-");
            stackNewValus = stack.Pop();
            Console.Write(stackNewValus + "-");
            stackNewValus = stack.Pop();
            Console.Write(stackNewValus + "-");
            stackNewValus = stack.Pop();
            Console.Write(stackNewValus + "-");
            stackNewValus = stack.Pop();
            Console.Write(stackNewValus + "-");
            stackNewValus = stack.Pop();
            Console.WriteLine(stackNewValus);

            Console.Write("\npress eny key to exit");
            Console.ReadLine();
        }
    }
}
