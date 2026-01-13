using System;
using BankingApp.Services;

class Program
{
    static void Main()
    {
        TransactionHandler handler = new TransactionHandler();

        Console.Write("Enter transfer amount: ");
        decimal amount = Convert.ToDecimal(Console.ReadLine());

        handler.Transfer(amount);
    }
}
