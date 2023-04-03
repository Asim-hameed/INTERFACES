using System.Collections;

namespace Collections
{
    // Collection is dynamic: it can change at run time
    // AUTO-RESIZING

    internal class Program
    {
        static void Main(string[] args)
        {
            //With Default constructor
            ArrayList arrayList = new ArrayList();

            // With paramterized constructor
            //ArrayList arrayList = new ArrayList(10);
            //

            //.............
            Console.WriteLine(arrayList.Capacity);
            arrayList.Add(1);
            arrayList.Add("Asim");
            arrayList.Add('Z');
            arrayList.Add(10);
            arrayList.Add("Hameed");
            Console.WriteLine(arrayList.Capacity);

            foreach (object i in arrayList)
            {
                Console.WriteLine(i);
            }

            arrayList.Insert(2, 100);

            foreach (object i in arrayList)
            {
                Console.WriteLine(i);
            }

            arrayList.Remove(100);


            foreach (object i in arrayList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Hello, World!");

            //int[] arr = new int[3];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //Array.Resize(ref arr, 5);
            //arr[3] = 10;
            //arr[4] = 5;
            ////Array.Sort(arr);
 
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
        }
    }
}