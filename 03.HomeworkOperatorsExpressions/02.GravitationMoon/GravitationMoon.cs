using System;

    class GravitationMoon
    {
        static void Main()
        {
            Console.Write("Enter your weight on the Earth: ");
            float EarthWeight = float.Parse(Console.ReadLine());
            float MoonWeight = EarthWeight-(EarthWeight*83)/100;
            Console.WriteLine("Your weight on the Moon is: "+MoonWeight);

        }
    }

