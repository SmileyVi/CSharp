using System;

    class CompareNumbers
    {
        static void Main()
        {
            Console.WriteLine("Write number for compare: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Write another number for compare: ");
            double number2 = double.Parse(Console.ReadLine());
            double highest = Math.Max(number1, number2);
            Console.WriteLine("The highest number is: {0}",highest);

        }
    }
