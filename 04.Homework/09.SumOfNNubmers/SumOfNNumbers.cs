using System;

    class SumOfNNumbers
    {
        static void Main()
        {
            //Console.WriteLine("Enter number here: ");
            //int n=int.Parse(Console.ReadLine());

            

            //Console.WriteLine("Enter here {0} numbers for calculating: ",n);
            //object original=Console.ReadLine();ConsoleKey key=(ConsoleKey.Enter);
            //int calc = (int)original;

            Console.Write("Enter number here: ");
            int n = int.Parse(Console.ReadLine());
            double calc = 0;
            for (int a = 1; a <= n; a++)
            {
                Console.Write("Enter number {0} here: ", a);
                double number = double.Parse(Console.ReadLine());
                calc += number;
            }
            Console.WriteLine("The sum of these numbers is = {0}", calc);
        }
    }

