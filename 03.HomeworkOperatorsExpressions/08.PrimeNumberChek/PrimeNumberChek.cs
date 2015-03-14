using System;

class PrimeNumberChek
{
    static void Main()
    {
        Console.WriteLine("Please insert one number (Not bigger than 100):");
        int number = int.Parse(Console.ReadLine());


        bool b = number % 3 == 0;
        bool c = number % 5 == 0;
        bool d = number % 7 == 0;
        bool f = number % 2 == 0;

        bool one = number == 3;
        bool two = number == 7;
        bool three = number == 5;



        if (b ^ c ^ d ^ f)

            Console.WriteLine("true");
        else
        {
            if (one || two || three)
            {
                Console.WriteLine("True");
            }
            else
            {
                if (b || c || d ||f)
                {
                    Console.WriteLine("False");
                }
            }





        }
    }
}
