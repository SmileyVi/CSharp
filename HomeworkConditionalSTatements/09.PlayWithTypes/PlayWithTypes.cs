using System;

    class PlayWithTypes
    {
        static void Main()
        {
            Console.WriteLine("Please enter a type: \r\n1-->int\r\n2-->double\r\n3-->sting");
            int user = int.Parse(Console.ReadLine());
            switch (user)
            {
                case 1: Console.WriteLine("Enter integer:");
                    int one = int.Parse(Console.ReadLine());
                    Console.WriteLine(one+1);
                    break;
                case 2: Console.WriteLine("Enter double: ");
                    double two = double.Parse(Console.ReadLine());
                        Console.WriteLine(two+1);
                    break;
                case 3: Console.WriteLine("Enter string: ");
                    string three = Console.ReadLine();
                        Console.WriteLine(three+"*");
                        break;
                default: Console.WriteLine("Error! Try again."); break;

            }
        }
    }

