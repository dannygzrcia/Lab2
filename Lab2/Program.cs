//Daniel Garcia
//CPS 3330*01
//Lab2
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many numbers do you want to provide? (2 or 3)");
        int count = int.Parse(Console.ReadLine());

        if (count == 2)
        {
            Console.WriteLine("Enter the first number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = double.Parse(Console.ReadLine());

            double min = MyRootLibrary.Minimum(num1, num2);
            Console.WriteLine($"The minimum of {num1} and {num2} is: {min}");
        }
        else if (count == 3)
        {
            Console.WriteLine("Enter the first number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            double num3 = double.Parse(Console.ReadLine());

            double min = MyRootLibrary.Minimum(num1, num2, num3);
            Console.WriteLine($"The minimum of {num1}, {num2}, and {num3} is: {min}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 2 or 3.");
        }
    }
}
