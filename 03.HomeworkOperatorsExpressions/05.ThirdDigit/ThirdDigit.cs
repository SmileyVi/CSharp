using System;

    class ThirdDigit
    {
        static void Main()
        {
            Console.Write("Enter some number: ");
            int YourNumber = int.Parse(Console.ReadLine());
            int Hundred = YourNumber % 1000;
            int b = Hundred / 100;
            bool thirdDigit = Math.Abs (b) == 7;
            bool thirdDigit2 = b == 1;
            Console.WriteLine(thirdDigit||thirdDigit2);
         

        }
    }

