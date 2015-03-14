using System;

class star
{
    static void Main()
    {
        Console.WriteLine("Enter N here: ");
        int size = int.Parse(Console.ReadLine());
        int outerDots = size;
        Console.WriteLine("{0}*{0}",new string('.',outerDots));
        int innerDots = 1;
        outerDots = size - 1;
        for (int i = 0; i < size/2; i++)
        {
            innerDots += 1;
            outerDots -= 2;
            Console.WriteLine("{0}*{1}*{0}", new string('.',outerDots), new string ('.', innerDots));
        }

    }
}

