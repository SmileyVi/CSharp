using System;

    class PointInCircle
    {
        static void Main()
        {
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());
            bool a = (x >= -2);
            bool b=(x <= 2);
            bool c = (y >= -2);
            bool d = (y <= 2);
           
            bool one=(a && b);
            bool two=(c && d);
            if (one==two)
            Console.WriteLine("These coordinates are inside the circle ");
            else
                Console.WriteLine("These coordinates are not in the circle");

      
        }
    }

