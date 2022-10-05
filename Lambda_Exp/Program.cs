// See https://aka.ms/new-console-template for more information
using Lambda_Exp;
Console.WriteLine("Hello, World!");

delegate1 d1 = delegate (int x) { return x * x; };                          // Anonymous method 
                                                                            // (int x)  this is the input parameter data type and  not the return type.


int abc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(d1(abc) );

int z = 2;
Func<int, int> square = n => n * z;                                         // Lambda expression, in which we dont have to specify the input parameter data type.

Console.WriteLine(square(5));

static void add(delegate1 d11)
{
    Console.WriteLine(d11(10));
}

add((a) => { return a +a; });


List<int> list = new List<int>();

static bool random(int a)
{
    return true;
}
var zz = list.FindAll((a) => { return true; });
