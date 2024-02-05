//Daniel Garcia
//CPS 3330*01
//Lab2

namespace MyRootLibrary;

public class Class1
{

    public static double MyRoot(double number)
    {
        double root;
        root = Math.Sqrt(number);

        Console.WriteLine("The square root of " + number + " is " +
        root);
        return root;
    }
}
