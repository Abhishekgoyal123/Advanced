
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate int delegate1(int a, int b);
    public class Class1
    {
       // public delegate void delegate1 (int a, int b);

        public int add(int a, int b)
        {
            //throw new Exception("add exceptionn");
            Console.WriteLine("add");
            return a + b;

        }

        public int sub(int a, int b)
        {
            Console.WriteLine("sub");
            //throw new Exception("sub exceptionn");
            return a - b;
        }

        public int multiply(int a, int b)
        {
            Console.WriteLine("multiply");
            //throw new Exception("add exceptionn");
            return a * b;
        }
    }
}
