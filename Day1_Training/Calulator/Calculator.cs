// See https://aka.ms/new-console-template for more information
using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        int num1 ;
        while(!int.TryParse(Console.ReadLine(), out num1));
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for the first number: ");
        }

        Console.WriteLine("Enter the second number: ");
        int num2;
        while(!int.TryParse(Console.ReadLine(), out num2));
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for the second number: ");
        }

        int sum, difference, product;
        double quotient=0;
        bool divisionByZero = false;

        sum = num1 + num2;
        difference = num1 - num2;   
        product = num1 * num2;
        if(num2 != 0)
        {
            quotient = (double)num1 / num2;
        }
        else
        {
            divisionByZero = true;
        }
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + difference);
        Console.WriteLine("Product: " + product);
        if(!divisionByZero)
        {
            Console.WriteLine("Quotient: " + quotient);
        }
        else
        {
            Console.WriteLine("Quotient: Division by zero is not allowed.");
        }   


    }
}
