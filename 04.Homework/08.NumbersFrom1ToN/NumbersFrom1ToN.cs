using System;

    class NumbersFrom1ToN
    {
        static void Main()
        {
            Console.WriteLine("Enter n= ");
            int n = int.Parse(Console.ReadLine());
            for (int c =1; c <= n; c++) 
            {
                Console.WriteLine("{0}", c);
            }
        }
    }

