using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budget
{
    class Budget
    {
        static void Main()
        {
            
            int budget = int.Parse(Console.ReadLine());
          
            int weekOut = int.Parse(Console.ReadLine());
           
            int hometown = int.Parse(Console.ReadLine());

            double razhod=0;
            double razhod2=0;
            double Days = 22;
            double WeekendDays = 4 * 2;
            double ostatyk;
            double rent = 150;
           
                razhod = (budget * 3 / 100+10) * weekOut;
            
            if (hometown > 0)
                {
                    razhod2 = WeekendDays * 20 - hometown * 40;
                }
            else
            {
                razhod2 = WeekendDays * 20;
            }
            double dayHome = (Days - weekOut) * 10;
            double Obshto = razhod + razhod2;
            ostatyk = budget -(dayHome+ Obshto + rent);

                if (ostatyk > 0)
                {
                    
                    Console.WriteLine("Yes, leftover {0}.", ostatyk);
                }
                else if (ostatyk < 0)
                {
                    

                    Console.WriteLine("No, not enough {0}.", Math.Abs(ostatyk));
                }
                else if (ostatyk == 0)
                {
                    Console.WriteLine("Exact Budget.");
                }
               
        }
    }
}

