using System;

    class Sum
    {
        static void Main()
        {
            Console.WriteLine("Please enter first real number: ");
            double number1=double.Parse (Console.ReadLine());
            Console.WriteLine("Please enter second real number: ");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter third real number: ");
            double number3 = double.Parse(Console.ReadLine());
            Console.WriteLine("The sum of these numbers is: {0}", number1+ number2+ number3);
        }
    }

