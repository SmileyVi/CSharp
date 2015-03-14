using System;

class Program
{
    static void Main()
    {
        string yearType = Console.ReadLine();
        int c = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());

        
        int weeksInMonth = 4;

        
        
        double travellers=0;
        int familyMonth = 2 * 2;

        int contractMon=weeksInMonth*3;
        int contractMonthsTravels = c * contractMon;
        
        
        int familyMonthTravels = f*familyMonth;

        double perc = ((double)contractMon * 40) / 100;
        double normalMon=contractMon-perc;
        int normalCount = 12 - c - f;
       
        double NormalMonthsTravels = normalMon*normalCount;

        travellers += contractMonthsTravels;
        travellers += familyMonthTravels;
        travellers += NormalMonthsTravels;



        switch (yearType)
        {
            case "leap": travellers += (travellers * 5) / 100; break;


            case "normal": travellers += 0; break;
        }

        Console.WriteLine((int)travellers);
            
            

    }
}

