using System;
class Plane
{
    static void Main()
    {
        Console.WriteLine("Enter N here: ");
        int size = int.Parse(Console.ReadLine());
        int outerDots = (size * 3 - 1)/2;
        int innerDots=1;
        //Console.WriteLine("{0}*{0}",new string ('.',outerDots));
        //outerDots -= 1;
        //innerDots = 1;
        //Console.WriteLine("{0}*{1}*{0}", new string('.',outerDots),new string ('.',innerDots));
      
        for (int i = 0; i < 2; i++)
        {
            outerDots -= 1;
            innerDots += 2;
                Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', innerDots));
        }
        //outerDots = 1;
        //innerDots = size * 3 - 4;

        //Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', innerDots));
        //innerDots = size - 2;
        //outerDots=0;
        //Console.WriteLine("*{0}*{1}*{0}*", new string('.', innerDots),new string('.',size));
        ///////

        ////outerDots = 1;
        ////innerDots = size-2;
        ////Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",new string('.', innerDots), new string('.', outerDots),new string('.',size));


        //innerDots = size - 2;
        //outerDots=1;
        //for (int i = 0; i < size/2-1; i++)

        //{
        //    outerDots = 1;
            
        //    innerDots -= 2;
        //    Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', innerDots), new string('.', outerDots),new string('.',size));
        //    outerDots+=2;
        //}
        /////
        //outerDots = size - 1;
        //innerDots=size;
        //for (int i = 0; i < size-1; i++)
        //{
        //    outerDots -= 1;
        //    innerDots += 2;
        //        Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', innerDots));
                
        //}Console.WriteLine(new string('*',3*size));
        }

    }


