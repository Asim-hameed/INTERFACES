namespace MultiThreading_Demo
{
    internal class Program
    {
        public static void fun1()
        {
            for (int j = 0; j <= 50; j++)
            {
                Console.WriteLine("Fun1= "+j);
            }
        }
        public static void fun2()
        {
            for (int j = 0; j <= 50; j++)
            {
                Console.WriteLine("Fun2= " + j);
            }
        }
        public static void fun3()
        {
            for (int j = 0; j <= 50; j++)
            {
                Console.WriteLine("Fun3= " + j);
            }
        }
        static void Main(string[] args)
        {
            Program.fun1();
            Program.fun2();
            Program.fun3();

            //Thread t = Thread.CurrentThread;
            //t.Name = "Main Thread";
            //Console.WriteLine("Current excecuting thread is "+Thread.CurrentThread.Name);
        }
    }
}