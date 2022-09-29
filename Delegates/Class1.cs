using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpCasting
{
    public abstract class Class1
    {
        public int add(int a, int b) 
        {
            return a + b;
        }
    }

    public class derived : Class1 
    {
        public new string add(int a, int b) 
        {
            return "Abhishek";   
        }
    }
}
