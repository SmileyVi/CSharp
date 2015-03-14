using System;

    class SumOfFive
    {
        static void Main()
        {
            Console.WriteLine("Please enter a five numbers separated by a space:");
            string numbers = Console.ReadLine();
            string[] splitNums = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            for (int i = 0; i < splitNums.Length; i++)
            {
                sum = sum + double.Parse(splitNums[i]);
            }
            Console.WriteLine(sum);


        }
    }

