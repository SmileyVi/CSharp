using System;

    class CirclePerimeterArea
    {
        static void Main()
        {
            Console.WriteLine("Enter radius of circle: ");
            double r = double.Parse(Console.ReadLine());

            double perimeter = (2 * Math.PI * r);
            double area = (Math.PI * r * r);
            Console.WriteLine("The perimeter is: {0:F2}\r\nThe area is: {1:F2}",perimeter,area);
            
        }
    }

