using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int stars = n + 2;
        int innerDash = n;
        int outerDash = (n - 1) / 2;

        Console.WriteLine("{0}{1}{0}", new string('-', outerDash), new string('*', stars));

        for (int i = 0; i < n; i++)
        {
            stars = 1;
            outerDash = (n - 1) / 2;
            innerDash = n;
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', outerDash), new string('*', stars), new string('-', innerDash));
        }
        stars = 3;
        innerDash = n - 2;
        outerDash = (n - 1) / 2 - 1;
        for (int i = 0; i < (n - 1) / 2; i++)
        {
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', outerDash), new string('*', stars), new string('-', innerDash));
            }
            stars += 2;
            innerDash -= 2;
            outerDash -= 1;

        }

        stars = n;
        outerDash = 0;
        innerDash = 1;
       

        
        for (int i = 0; i < (n - 1) / 2; i++)
        {
            
            stars -= 2;
            innerDash += 2;
            outerDash += 1;
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', outerDash), new string('*', stars), new string('-', innerDash));
        }



        }

    }
    


