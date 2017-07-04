using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02SignOfNumber
{
    class SignOfNumber
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            CheckValue(input);
        }
        static void CheckValue( int a)
        {
            if (a<0)
            { 
                Console.WriteLine("The number " + a + " is negative.");
            }
            else if (a==0)
            {
                Console.WriteLine("The number " + a + " is zero.");
            }
            else 
            {
                Console.WriteLine("The number " + a + " is positive.");
            }
        }
    }
}
