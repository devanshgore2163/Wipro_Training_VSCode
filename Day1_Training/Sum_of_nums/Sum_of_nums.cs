// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the first number
        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter the second number
        Console.WriteLine("Enter the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Add the two numbers
        int sum = num1+num2;

        // Print the sum
        Console.WriteLine("The sum of the number is: "+" "+sum);
    }
}