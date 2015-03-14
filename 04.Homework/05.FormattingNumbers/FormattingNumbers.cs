using System;

    class FormattingNumbers
    {
        static void Main()
        {
            Console.WriteLine("Write a integer number(between 0 and 500): ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write floating point number: ");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Write another floating point number: ");
            double number3 = double.Parse(Console.ReadLine());
            while (number1 < 0 || number1 > 500) //Check number is valid
            {
                Console.WriteLine("Invalid input! Try again!");
                number1 = int.Parse(Console.ReadLine());
            }
            Console.Write("|{0,-10:X}|", number1);
            Console.Write(Convert.ToString(number1, 2).PadLeft(10, '0'));
            Console.Write("|{0,10:F2}|", number2);
            Console.WriteLine("|{0,-10:F3}|", number3);

        }
    }

