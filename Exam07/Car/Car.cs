using System;

class Car
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDots=n;
        int innerDots=n-2;
        int star=n;
        Console.WriteLine("{0}{1}{0}", new string('.', outerDots), new string('*', star));
        for (int i = 0; i < n / 2-1; i++)
        {
            outerDots -= 1;
            innerDots += 2;
            Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', innerDots));
        }
        for (int i = 0; i < 1; i++)
        {
            star = n / 2 + 1;
            innerDots = 3 * n - star*2;
            Console.WriteLine("{0}{1}{0}", new string('*', star), new string('.', innerDots));
        }
        for (int i = 0; i < n/2-2; i++)
        {
            innerDots = 3 * n - 2;
            Console.WriteLine("*{0}*", new string ('.', innerDots));
        }
        star= 3*n;
        Console.WriteLine("{0}", new string ('*', star));

        for (int i = 0; i < n/2-2; i++)
        {
            outerDots = n / 2;
            innerDots = n / 2 - 1;
            star = n - 2;
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}", new string('.', outerDots), new string('.', innerDots), new string ('.', star));

        }
        Console.WriteLine("{0}*{1}*{2}*{1}*{0}", new string('.', outerDots), new string('*', innerDots), new string('.', star));
    }
}

