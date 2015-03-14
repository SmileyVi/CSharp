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
            Console.WriteLine("n");
            int budget = int.Parse(Console.ReadLine());
            Console.WriteLine("p");
            int weekOut = int.Parse(Console.ReadLine());
            Console.WriteLine("h");
            int hometown = int.Parse(Console.ReadLine());

            int monthMoney = budget - 150 - (22 * 10) - (20 * 8);
            double monthMoneylefted;
            double monthMoneyhometown;
            for (int i = 0; i < weekOut; i++)
            {
                monthMoneylefted = monthMoney - (budget * 3 / 100) * weekOut;

                if (monthMoney < budget)
                    monthMoneylefted = budget - monthMoney;
                Console.WriteLine("Yes, leftover {0}", monthMoneylefted);

                for (int j = 0; j < hometown; j++)
                {
                    monthMoneyhometown = monthMoney + hometown * 40;

                    Console.WriteLine(monthMoneyhometown);
                   
                }
            }


            //if (weekOut > 0)
            //{
            //    int weekDaysMoney = weekOut*((budget * 3) / 100);
            //    monthMoney -= weekDaysMoney;
            //}
            //else
            //{
            //    int weekDaysMoney = monthMoney - 10 * 22;
            //}

            //if (hometown > 0)
            //{
            //    monthMoney -= 0;
            //}
            //else
            //{
            //    monthMoney = monthMoney - 20 * (4 * 2);
            //}

            //Console.WriteLine(monthMoney);
        }
    }
}
