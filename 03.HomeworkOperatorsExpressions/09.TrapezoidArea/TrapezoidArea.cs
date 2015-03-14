using System;
    class TrapezoidArea
    {
        static void Main()
        {
            Console.WriteLine("Please insert side a: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Please insert side b: ");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Please insert height: ");
            double height = double.Parse(Console.ReadLine());

            double area = (sideA + sideB) / 2 * height;
            Console.WriteLine("The area of this trapezoid is: "+area);


        }
    }

