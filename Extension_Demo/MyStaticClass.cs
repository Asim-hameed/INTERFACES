using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Demo
{
    static class MyStaticClass
    {
        // Binding Parameter in function signature
        public static void func3(this Program program)
        {
            Console.WriteLine("This third function..........");
        }

        public static bool IsGreaterthan(this int i,int value)
        {
            return i > value;
        }
    }
}
