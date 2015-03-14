using System;

    class ModifyBit
    {
        static void Main()
        {
            Console.Write("Enter some number: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter position of bit: ");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for bit on your position (0 or 1)");
            int v = int.Parse(Console.ReadLine());


            int mask = 1 << p;
            int result = n ^ mask;

            Console.WriteLine(result);
            
            



           
            //Console.WriteLine(Convert.ToString(result,2).PadLeft(16;0));

        }
    }

