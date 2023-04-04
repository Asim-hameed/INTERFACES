namespace Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First number: ");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            int num2 = int.Parse(Console.ReadLine());

            try
            {
                int result = num1 / num2;
                Console.WriteLine("Division result is: {0}", result);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divid a number by zero");
                Console.WriteLine(ex.Message);
            }




            Console.WriteLine("Remaining statement 1");
            Console.WriteLine("Remaining statement 2");
            Console.WriteLine("Remaining statement 3");
        }
    }
}