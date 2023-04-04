using System.Text;
using System.Diagnostics;

namespace StringAndStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Asim ";
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            for(int i=0; i<100000; i++)
            {
                s1=s1+i;
            }
            sw.Stop();
            Console.WriteLine("Time taken by String: "+sw.ElapsedMilliseconds);


            sw.Restart();
            StringBuilder sb = new StringBuilder("Hameed ");
            for(int i=0; i<100000; i++)
            {
                sb.Append(i);
            }
            sw.Stop();
            Console.WriteLine("Time taken by String: " + sw.ElapsedMilliseconds);

        }
    }
}