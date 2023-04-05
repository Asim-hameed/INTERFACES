using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Demo
{
    class TextExtensionMethod
    {
        static void Main()
        {
            Program program = new Program();
            int i = 20;
            bool result = i.IsGreaterthan(i);

            Console.WriteLine(result);
            //program.func3();
        }
    }
}
