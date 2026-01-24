/*using System;

class nurClass
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
}*/

/*using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var a = 5 + 6;
        var b = 7 + 8;

        var c = (b == a) & (b < a + 1);
        var d = (b != a) && (b > a + 1);

        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.ReadKey();
    }
}*/

/*using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var a = 6;
        var b = 7;

        var c = (a > b) ^ (a != b);
        Console.WriteLine(c);

    }
}*/


/*using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var inv = true;
        var result = !inv;
        Console.WriteLine(result);
    }
}*/


/*using System;

class MainClass
{
    public static void Main(string[] args)
    {

        var a = 7;
        var b = 7;

        if (a == b)
        {
            Console.WriteLine("Условие истинно");
        }
        else
        {
            Console.WriteLine("Условие ложно");
        }

    }
}*/

/*using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

        var color = Console.ReadLine();

        if (color == "red")
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is red!");
        }

        else if (color == "green")
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is green!");
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is cyan!");
        }
    }
}*/



// switch («переключатель»).
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;

            default:
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
        }
    }
}