using System;

    class ExchangeVarValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before swap a = {0} and b = {1}", a, b);
            a = a + b; 
            b = a - b; 
            a = a - b; 
            Console.WriteLine("After swap a = {0} and b = {1}", a, b );

        }
    }

