// See https://aka.ms/new-console-template for more information
using Delegate;
using System;
try
{
    Class1 c1 = new Class1();

    delegate1 d1 = new delegate1(c1.add);
    d1 += c1.sub;
    d1 += c1.multiply;
    //d1(2, 3);                                             // In mulicast delegate, if my methods are returning something , if i invoke the method using delegate, then my last method return value will be printed.


    //Delegate[] il = d1.GetInvocationList();

    //System.Delegate[] InvocationList = d1.GetInvocationList();    // Invocation list is used to get a total count of the methods assigned to the delegate.

    foreach (delegate1 item in d1.GetInvocationList())  //======================================
    {
        //Console.WriteLine(item);                      // In multicast delegate, if all my methods are returning something, then to get ( return ) values from each method, we invoke the method using Invocation list and not invoke using delegate.
        int abc = item.Invoke(2, 3);
        Console.WriteLine(abc);//=====================================================================================
    }
}


catch(Exception ex)                   // When an exception occurs during the invocation of one of the methods a delegate refers to, the delegate does not continue invoking methods in its invocation list.
{
    Console.WriteLine(ex.Message);    // in a multicast delegate, if firt method throws exception, then other method will not get executed.
}                                     // But, if 2nd method will throw exception, only 1st method will get executed and any method below that ( 3rd method onwards ) will not br executed.

