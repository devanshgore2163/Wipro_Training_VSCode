using System;
using Banking.Services;

class Program
{
    static void Main(string[] args)
    {
        TransctionHandler handler = new TransctionHandler();
        Console.WriteLine("Give the transaction amount:");
        decimal amount = Convert.ToDecimal(Console.ReadLine());
        handler.transfer(amount);
    }
}

