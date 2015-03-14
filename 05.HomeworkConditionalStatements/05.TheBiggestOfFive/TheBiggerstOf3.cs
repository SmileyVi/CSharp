using System;

    class TheBiggerstOf3
    {
        static void Main()
        {
            Console.WriteLine("Enter first number: ");
            double a=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double b=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            double c=double.Parse(Console.ReadLine());

            bool greaterA=(a>b)&&(a>c);
            bool greaterB=(b>a)&&(b>c);
            bool greaterC=(c>b)&&(c>a);

            if (greaterA)
                Console.WriteLine("{0}",a);
            else
            {
                if (greaterB)
                {
                    Console.WriteLine("{0}",b);
                }
                else
                    Console.WriteLine("{0}",c);
            }
        }
    }

