namespace Null_Coalesce
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            string result = name ?? "Anonymous";
            Console.WriteLine(result);

            //if(name !=null)
            //{
            //    result = name;
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Value not matched");
            //}
        }
    }
}