using System;
class NullValues
{
    static void Main()
    {
        int? nullableInt=null;
        Console.WriteLine("Integer nullable value is here ->"+ nullableInt + "<-");
        double? nullableD = null;
        Console.WriteLine("Double nullable value is here ->"+ nullableD+ "<-");
        nullableInt += 7;
        nullableD += 4.546453;
        Console.WriteLine("Number + null value: " + nullableInt);
        Console.WriteLine("Number + null value: " + nullableD);
        nullableInt = 7;
        nullableD = 4.546453;
        Console.WriteLine("Number value: " + nullableInt);
        Console.WriteLine("Number value: " + nullableD);
    }
}

