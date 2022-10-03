// See https://aka.ms/new-console-template for more information
using Delegate_Extension;
Console.WriteLine("Hello, World!");


Class1 c1 = new Class1();
delegate1 d1 = new delegate1(c1.Add);

Class2 c2 = new Class2();

c2.execute(d1);





//random(c1);

static void random (Class1 c2)
{
    c2.id = 10;
    Console.WriteLine($"id = {c2.id}");

}