using System;

    class house
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int innerDots = 1;
            int outerDots = n-1;
            int star = n-3;
            int stars = n * 2 - 1;
            Console.WriteLine("{0}*{0}", new string ('.', outerDots));
            for (int i = 0; i < n-2; i++)
            {
                while (innerDots==1 && innerDots<2)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string ('.', outerDots-1), new string('.', innerDots));
                    break;

                }
                
                outerDots -= 1;
                innerDots += 2;
                Console.WriteLine("{0}*{1}*{0}", new string ('.', outerDots-1), new string('.', innerDots));
            }
            Console.WriteLine("{0}", new string ('*',stars));
            for (int i = 0; i < n/4; i++)
            {
                innerDots = n * 2-3;
                
                Console.WriteLine("*{0}*",new string('.', innerDots));
            }
            for (int j = 0; j < n/2; j++)
            {
            innerDots = n / 2;
            stars = n - 3;
            Console.WriteLine("*{0}{1}{0}*", new string('.', innerDots), new string('*', stars));
                    
            }
            for (int k = 0; k < n/4; k++)
            {
                innerDots = n * 2 - 3;

                Console.WriteLine("*{0}*", new string('.', innerDots));
                
            }
            stars=n*2-1;
                Console.WriteLine("{0}", new string ('*',stars));
            
        }
    }

