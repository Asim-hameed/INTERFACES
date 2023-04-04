namespace ParamsDemo
{
    // Every ohter variable rather than param will be assigned the values coming first
    // It should be at defined at last
    // No additional param is allowed at last after param
    internal class Program
    {
        public static int add(int a,params int[]num)
        {
            int sum = 0;
            foreach (int i in num)
            {
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Program.add(10, 5, 19, 74));
        }
    }
}