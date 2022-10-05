// See https://aka.ms/new-console-template for more information
using Events;
Console.WriteLine("Hello, World!");

Banking bank = new Banking(70000);

Notification noti = new Notification(bank);


Console.WriteLine($"Initial NetBalance = Rs.{bank.GetNetBalance()}");
bank.Deposit(80000);
Console.WriteLine($"Deposite NetBalance = Rs.{bank.GetNetBalance()}");

bank.Withdraw(145001);
Console.WriteLine($"Withdrawal NetBalance = Rs.{bank.GetNetBalance()}");

Console.ReadLine();