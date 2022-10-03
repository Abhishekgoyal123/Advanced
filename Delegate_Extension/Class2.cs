using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Extension
{
    public class Class2
    {
        Class1 c1 = new Class1();
        public void execute(delegate1 d1)
        {
            Console.WriteLine("extute method class 2");
        }
    }
}
