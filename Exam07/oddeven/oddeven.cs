using System;

class oddeven
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter C: ");
        int c = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter S: ");
        string s = Console.ReadLine();

        Console.WriteLine("Enter numbers: ");
        string numbers = Console.ReadLine();
        

        if (n*c>0)
	{
	         string[] countNumbers = numbers.Split('\n');
            int counts=int.Parse(countNumbers[0]);

            int Sets=counts/n;
	
        if (counts%2==1)
        {
            string odd = "odd";
        }
        if (counts % 2 == 0)
        {
            string even = "even";
        }
        Console.WriteLine(Sets);
}
      


           
           
        }
    }


