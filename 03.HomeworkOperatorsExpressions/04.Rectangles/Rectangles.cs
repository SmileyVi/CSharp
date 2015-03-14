using System;
    class Rectangles
    {
        static void Main()
        {
            Console.Write("Enter width of the rectangle: ");
            float width = float.Parse(Console.ReadLine());
            Console.Write("Enter height of the rectangle: ");
            float height = float.Parse(Console.ReadLine());

            float perimeter = 2 * (width + height);
            float area = width * height;
            Console.WriteLine("The perimeter is "+perimeter);
            Console.WriteLine("The area is "+ area);
        }
    }

