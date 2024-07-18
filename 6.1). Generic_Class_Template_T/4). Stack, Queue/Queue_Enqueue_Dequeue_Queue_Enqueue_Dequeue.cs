using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queue_Enqueue_Dequeue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            // Enqueue Elements in Queue
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Console.WriteLine("Intial Queue is : ");
            foreach (Object obj in queue)
            {
                Console.WriteLine(obj);
            }
            // Dequeue Elements of Queue
            queue.Dequeue(); // First In First Out (FIFO)
            Console.WriteLine("Queue after Dequeue is : ");
            foreach (Object obj in queue)
            {
                Console.WriteLine(obj);
            }
        }
    }
}