namespace Enums
{
    class Program
    {
        enum Days
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            friday,
            thursday,
            saturday
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("My name is asim");

            Console.WriteLine(Days.saturday);

            Days days = (Days)1;

            Console.WriteLine(days);
        }
    }
}