using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_method
{
    public static class Class2
    {
        public static void sub(this Class1 c1)
        {
            Console.WriteLine("sub");
        }
    }
}
