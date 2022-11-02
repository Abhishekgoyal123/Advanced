// See https://aka.ms/new-console-template for more information
using Delegate_Extension;
Console.WriteLine("Hello, World!");


Class1 c1 = new Class1();

delegate1 d1 = new delegate1(add123);

c1.Add(c1,d1);


static bool add123(Class1 c)
{
     bool b = true;
    return b;
   // Console.WriteLine("add from main");

}


delegate2 d2 = new delegate2(abcd);

c1.Sub(abcd);

static int abcd(int a)
{
    int a1 = 100;
    return 10;
}
