using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabaTinche
{
    class BabaTinche
    {
        static void Main()
        {
            string[] FirstClass = Console.ReadLine().Split(' ');
            int PassFirstClass = int.Parse(FirstClass[0]);
            int FirstFrequentFlyers = int.Parse(FirstClass[1]);
            int FirstMeals = int.Parse(FirstClass[2]);

            string[] BuisnessClass = Console.ReadLine().Split(' ');
            int PassBuisnessClass = int.Parse(BuisnessClass[0]);
            int BuisnessFrequentFlyers = int.Parse(BuisnessClass[1]);
            int BuisnessMeals = int.Parse(BuisnessClass[2]);

            string[] EconomyClass = Console.ReadLine().Split(' ');
            int PassEconomyClass = int.Parse(EconomyClass[0]);
            int EconomyFrequentFlyers = int.Parse(EconomyClass[1]);
            int EconomyMeals = int.Parse(EconomyClass[2]);


            int FirstTicket = 7000;
            int BuisnessTicket = 3500;
            int EconomyTicket = 1000;
            int FirstTicketOff = FirstTicket - (FirstTicket * 70 / 100);
            int BuisnessTicketOff = BuisnessTicket - (BuisnessTicket * 70 / 100);
            int EconomyTicketOff = EconomyTicket - (EconomyTicket * 70 / 100);

            decimal FirstMealsCost = ((0.5m * FirstTicket) / 100);
            decimal BuisnessMealsCost = ((0.5m * BuisnessTicket) / 100);
            decimal EconomyMealsCost = ((0.5m * EconomyTicket) / 100);

            int MaxIncome = 233160;
            decimal TotalIncome = 0m;

            TotalIncome += FirstFrequentFlyers * FirstTicketOff;
            TotalIncome += (PassFirstClass - FirstFrequentFlyers) * FirstTicket;
            TotalIncome += FirstMeals * FirstMealsCost;

            TotalIncome += BuisnessFrequentFlyers * BuisnessTicketOff;
            TotalIncome += (PassBuisnessClass - BuisnessFrequentFlyers) * BuisnessTicket;
            TotalIncome += BuisnessMeals * BuisnessMealsCost;

            TotalIncome += EconomyFrequentFlyers * EconomyTicketOff;
            TotalIncome += (PassEconomyClass - EconomyFrequentFlyers) * EconomyTicket;
            TotalIncome += EconomyMeals * EconomyMealsCost;



            Console.WriteLine((int)TotalIncome);
            Console.WriteLine(MaxIncome - (int)TotalIncome);
        }
    }
}


