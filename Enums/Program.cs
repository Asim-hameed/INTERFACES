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
            //Console.BackgroundColor = ConsoleColor.Yellow;
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("My name is asim");

            //Console.WriteLine(Days.saturday);

            //Days days = (Days)1;

            //Console.WriteLine(days);

            //.............


            Console.WriteLine("Enter your Name:");
            string name=Console.ReadLine();

            Console.WriteLine("Enter you Day sunday=1");
            int value = int.Parse(Console.ReadLine());

            Days days = (Days)value;

            switch (days)
            {
                case Days.sunday:
                    break;
                case Days.monday:
                    break; 
                case Days.tuesday:
                    break;
                case Days.wednesday:
                    break;
                case Days.friday:
                    break;
                case Days.thursday:
                    break;
                case Days.saturday:
                    break;
                default:
                    break;
            }

            Console.WriteLine("My name is "+name+" And my birthday is "+days);
        }
    }
}