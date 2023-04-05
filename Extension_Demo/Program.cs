namespace Extension_Demo
{

    // Extension methods should be static

    sealed class Program
    {
        public void func1()
        {
            Console.WriteLine("This is first function......... ");
        }
        public void func2()
        {
            Console.WriteLine("This is second function......... ");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.func1();
            program.func2();
        }
    }
}