using System;

    class TheBiggestOf5
    {
        static void Main()
        {
            Console.WriteLine("Enter number 1: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 3: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 4: ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 5: ");
            double e = double.Parse(Console.ReadLine());

            bool greaterA = (a > b) && (a > c) && (a > d) && (a > e);
            bool greaterB = (b > a) && (b > c) && (b > d) && (b > e);
            bool greaterC = (c > a) && (c > b) && (c > d) && (c > e);
            bool greaterD = (d > a) && (d > b) && (d > c) && (d > e);
            Console.WriteLine("\r\nThe bigest number is: ");
            if (greaterA)
            {
                Console.WriteLine("{0}", a);
            }
            else  if (greaterB)
            {
                    Console.WriteLine("{0}", b);
            }
                else if (greaterC)
            {
                    Console.WriteLine("{0}", c);
                }
                else if (greaterD)
            {
                    Console.WriteLine("{0}", d);
                }
                else
                    Console.WriteLine("{0}", e);
            }
        }
        
    

