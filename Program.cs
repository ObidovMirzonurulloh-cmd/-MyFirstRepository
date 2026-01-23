using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var myapples = 5;
        var hisapples = 6;
        var hispeares = 5;

        var result = (myapples != hispeares) & (myapples < hisapples);

        Console.WriteLine(result);
        Console.ReadKey();
    }
}