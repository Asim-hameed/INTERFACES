namespace IsVsAs
{
    class Program
    {
        static void Main(string[] args)
        {

            // Is used to check type of object


            //object a = "Asim";
            //bool check = a is string;
            //Console.WriteLine(check);


            // As used to check and cast type of object by assigning value or null to any variable


            object a = "Asim";
            string str=a as string;
            Console.WriteLine(str);

        }
    }
}