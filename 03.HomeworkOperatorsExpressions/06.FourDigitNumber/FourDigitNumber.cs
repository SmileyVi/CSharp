using System;

    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Enter some four-digit number( it mustn't start with 0): ");
            int YourNumber = int.Parse(Console.ReadLine());

            int v = YourNumber % 10000;
            int a = v / 1000;

            int r = YourNumber % 1000;
            int b = r / 100;

            int y = YourNumber % 100;
            int c = y / 10;

            int n = YourNumber % 10;
            int d = n / 1;
        
            Console.WriteLine("The sum of digits is:"+ (a+b+c+d));
            Console.WriteLine("How looks your number reversed: {0}{1}{2}{3} ",d,c,b,a);
            Console.WriteLine("Here your last digit is first: {0}{1}{2}{3}",d,a,b,c);
            Console.WriteLine("Here second and third digist are exchanged: {0}{1}{2}{3}",a,c,b,d);

       }
    }

