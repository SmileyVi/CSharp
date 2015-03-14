using System;
    class StringsObjects
    {
        static void Main()
        {
            string one = "Hello";
            string two = "World";
            object concatenation = one + " "+ two;
            string three = (string)concatenation;
                Console.WriteLine(one+ " "+two);
                Console.WriteLine(concatenation);
                Console.WriteLine(three);


        }
    }
