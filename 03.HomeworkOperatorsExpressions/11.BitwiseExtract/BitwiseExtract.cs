using System;

    class BitwiseExtract
    {
        static void Main()
        {
            Console.Write("Enter some positive integer: ");
            uint YourNumber = uint.Parse(Console.ReadLine());
            int Position = 3;
            uint YourNumberP = YourNumber >> Position;
            uint bit = YourNumberP & 1;
            Console.WriteLine(bit);


        }
    }

