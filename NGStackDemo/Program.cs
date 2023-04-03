using System.Collections;
namespace NGStackDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack =new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push("Asim");
            stack.Push('O');
            stack.Push(25.75);
            stack.Push(null);
            stack.Push(true);

            foreach (Object item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stack.Count);
            stack.Pop();
            foreach (Object item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Peek();
            Console.WriteLine(stack.Count);
        }
    }
} 