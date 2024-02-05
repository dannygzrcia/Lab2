//Daniel Garcia
//CPS 3330*01
//Lab2
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = double.Parse(Console.ReadLine());

        double min = Minimum(num1, num2);
        Console.WriteLine($"The minimum of {num1} and {num2} is: {min}");

        // Check if the last digit of the Kean ID is 2 or 3
        string keanID = "1149413"; 
        int lastDigit = int.Parse(keanID[^1].ToString());

        if (lastDigit == 2 || lastDigit == 3)
        {
            Console.WriteLine("Enter the third number:");
            double num3 = double.Parse(Console.ReadLine());

            min = Minimum(min, num3);
            Console.WriteLine($"The minimum of {num1}, {num2}, and {num3} is: {min}");
        }
    }

    static double Minimum(double a, double b)
    {
        return Math.Min(a, b);
    }

    static double Minimum(double a, double b, double c)
    {
        return Math.Min(Math.Min(a, b), c);
    }
}
