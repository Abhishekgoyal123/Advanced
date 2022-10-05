using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class abcd : IAdd
    {
       void IAdd.Add(int id)
        {
            Console.WriteLine("add method");
        }
    }
}
