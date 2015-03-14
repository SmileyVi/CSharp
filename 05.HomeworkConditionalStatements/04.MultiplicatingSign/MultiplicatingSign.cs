using System;

class MultiplicatingSign
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        double c = double.Parse(Console.ReadLine());


        bool four = a == 0;
        bool five = b == 0;
        bool six = c == 0;
        bool one = a < 0;
        bool two = b < 0;
        bool three = c < 0;
        bool seven = a > 0;
        bool eight = b > 0;
        bool nine = c > 0;

        if (four || five || six)
        {
            Console.WriteLine("0");
        }
        else
        {
            if (one && two && three)
            {

                Console.WriteLine("-");
            }
            else
            {
                if (seven ^ eight ^ nine)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    if (one || two || three)
                        Console.WriteLine("-");

                }



            }
        }
    }
}
