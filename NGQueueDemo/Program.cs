using System.Collections;
namespace NGQueueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("Asim");
            queue.Enqueue("Asim");
            queue.Enqueue('L');
            queue.Enqueue(null);
            queue.Enqueue(4.35);
            queue.Enqueue(true);

            foreach (object item in queue) 
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Total Count is "+queue.Count+"..........................");


            queue.Dequeue();
            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Total Count is " + queue.Count+"......................");
            Console.WriteLine("\n Peek Element is: "+queue.Peek());
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            Console.WriteLine("Total Count is " + queue.Count + "......................");

        }
    }
}