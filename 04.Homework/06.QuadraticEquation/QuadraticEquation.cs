using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter coefficient a: ");
        string firstNumber = Console.ReadLine();
        float a = float.Parse(firstNumber);

        Console.Write("Enter coefficient b: ");
        string secondNumber = Console.ReadLine();
        float b = float.Parse(secondNumber);

        Console.Write("Enter coefficient c: ");
        string thirdNumber = Console.ReadLine();
        float c = float.Parse(thirdNumber);

        float d = ((b * b) - (4 * a * c));
        float sqrtD = (float)Math.Sqrt(d);
        float onlyOneRoot = ((-b) / (2 * a));
        float rootOne = ((-b + sqrtD) / (2 * a));
        float rootTwo = ((-b - sqrtD) / (2 * a));

      
        if (d > 0)
        {
            Console.WriteLine("The roots of the quadratic equation are:\nX1 = {0}\nX2 = {1}", rootOne, rootTwo);
        }
        else if (d == 0)
        {
            Console.WriteLine("The equation has only one root equal to:" + " " + onlyOneRoot);
        }
        else
        {
            Console.WriteLine("The equation has no real roots");
        }
    }
}

