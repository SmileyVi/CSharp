﻿using System;

    class ChekBit
    {
        static void Main()
        {

            Console.Write("Enter some number: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter position of bit: ");
            int p = int.Parse(Console.ReadLine());

            int np = n >> p;
            int bit = np & 1;
            bool chek = bit == 1;
            Console.WriteLine(chek);

        }
    }

