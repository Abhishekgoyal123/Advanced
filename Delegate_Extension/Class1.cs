using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Extension
{
   public delegate void delegate1(Class1 c1);
    public class Class1
    {
        public int id;
        public void Add(Class1 c1)
        {

            Console.WriteLine("add");
            //return c1.id;
           
        }

        private void Sub(Class1 c1)
        {
            Console.WriteLine("sub");
            //return c1.id;

        }


    }
}
