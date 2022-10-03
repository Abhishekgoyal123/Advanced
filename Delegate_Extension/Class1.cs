using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Extension
{
   public delegate bool delegate1(Class1 c1);

    public delegate int delegate2(int a);
    public class Class1
    {
        public int Salary=0;
        public void Add(Class1 c, delegate1 d1)
        {

            if (d1(c))
            {
                Console.WriteLine("add from class method");
            }
            
           // return id;
           
        }

        public void Sub(delegate2 d2)
        {
            int b = 0;
            if(d2(b) ==100)
                Console.WriteLine("sub");


        }


    }
}
