using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Initialize a list of numbers
        var numbers = new[] { 1, 2, 3, 4, 5 };

        // Perform addition
        var sum = numbers.Sum();
        Console.WriteLine("Sum: " + sum);

        // Perform subtraction
        var difference = numbers.First() - numbers.Last();
        Console.WriteLine("Difference: " + difference);

        // Perform multiplication
        var product = numbers.Aggregate((x, y) => x * y);
        Console.WriteLine("Product: " + product);

        // Perform division
        var quotient = numbers.First() / (double)numbers.Last();
        Console.WriteLine("Quotient: " + quotient);

        Console.ReadLine();
    }
}