using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_constructor
{
     public class Parent 
    {
        static string name;

        Parent p = new Parent();
        static Parent()
        {
            name = "abhishek";
            
        }
    }

    public class child : Parent
    {
        nam
    }
}
