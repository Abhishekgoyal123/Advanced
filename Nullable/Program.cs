// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Nullable<int> abc = null;                                             // Nullable is a structure
abc = 3;
int? b = null;                                                       // shorthand of nullable types

Console.WriteLine(abc.GetValueOrDefault());                           // if variable is assigned null, then default value of variable is 0
                                                                      // otherwise it will display value assigned to the variable

Console.WriteLine(abc.HasValue);                                      // if value is not assigned ( NUll is assigned ) to variable, it will display FALSE otherwise TRUE

Console.WriteLine(abc.Value);                                         // if no value is assigned other than NULL, then it will generate  Invalid Operation execption ( nullable object must be assigned a value ), otherwise it will display the value assigned to it.

// to print the value of a nullable type variable, always get GetValueOrDefault method, because it wi;l not throw exception if value is not assigned to the variable.


int? p = 10;
int? q = p;

Console.WriteLine(p);

int? x = null;

int y = x ?? 99999;                                                    // Non coalescing operaator

Console.WriteLine(y);