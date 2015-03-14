using System;

    class DivideBy7And5
    {
        static void Main()
        {
            Console.Write("Enter some number: ");
            int YourNumber = int.Parse(Console.ReadLine());
            bool devide= YourNumber%5==0;
            bool devide2=YourNumber%7==0;
            Console.WriteLine(devide&&devide2);

        }
    }

