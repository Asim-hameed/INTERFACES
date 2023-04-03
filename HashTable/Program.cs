using System.Collections;
namespace HashTableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            //{
            //    { "Id",1123 },
            //    { "Name", "Asim" },
            //    { "Age", 25 }
            //};
            ht.Add("Id", 1123);
            ht.Add("Name", "Asim");
            ht.Add("Salary", 300000);
            ht.Add("Designation", "PSE");
            ht.Add("isMarried", false);

            Console.WriteLine(ht.ContainsValue("Asim"));

            //Console.WriteLine("Salary".GetHashCode());

            Console.WriteLine(ht.Count);
            //Console.WriteLine(ht["Id"]);

            //foreach (object key in ht.Keys)
            //{
            //    Console.WriteLine(key + " : " + ht[key]);
            //}
            //Console.WriteLine("\n");

            //ht.Remove("Id");
            //ht.Clear();
            //foreach (object key in ht.Keys)
            //{
            //    Console.WriteLine(key + " : " + ht[key]);
            //}


        }
    }
}