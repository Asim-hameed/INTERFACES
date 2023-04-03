namespace GENERICS
{

    // We can create our own interfaces, classes, methods, events and delegates with Generics
    // Purformance will be optimzed
    // Generics are type safe
    
    class Example
    {
        //public static void showArray<T>(T[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}
        //public static void showArray(string[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}
        
        //.................

        public static bool check<T>(T a , T b)
        {
            bool c =a.Equals(b);
            return c;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ////int[] arr = { 1, 2, 3 };
            //int[] arr = new int[3];
            //arr[0] = 10;
            //arr[1] = 20;
            //arr[2] = 30;
            //string[] name = { "asim", "hameed", "Ghouri" };
            //double[] doubles = { 0.2, 0.761, 4.98 };

            //Example.showArray(arr);

            //Example.showArray(name);

            //Example.showArray(doubles);

            Console.WriteLine(Example.check(2, 2));
            Console.WriteLine(Example.check("hameed", "asim"));

        }
    }
}