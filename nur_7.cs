/*using System;


class NurClass
{
    public static void Main()
    {
        (string name, int age) anketa;

        Console.WriteLine("Введите ваше имя: ");
        anketa.name = Console.ReadLine();

        Console.WriteLine("Введите ваш возраст: ");
        anketa.age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", anketa.name);
        Console.WriteLine("Ваш возраст: {0}", anketa.age);

        var favcolors = new string[3];
        for (int i = 0; i < favcolors.Length; i++)
        {
            favcolors[i] = ShowColor(anketa.name, anketa.age);
        }

    }

    static string ShowColor(string username, int userage)
    {
        Console.WriteLine("{0} {1} лет \nВведите свой любимый цвет: ", username, userage);
        var fav = Console.ReadLine();
        

        switch (fav)
        {

            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;

            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;

            
        }
        
       
       

        return username;
    }
}*/




//Массив и сорт масива
/*using System;

class NurClass
{
    static int[] GetArrayFromConsole()
    {
        var result = new int[3];

        for (int i = 0; i < result.Length; i++)
        {
            Console.Write("Введите элемент {0}: ", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }

    static int[] SortArray(int[] number)
    {
        int temp;

        for (int i = 0; i < number.Length; i++)
        {
            for (int j = i + 1; j < number.Length; j++)
            {
                if (number[i] > number[j])
                {
                    temp = number[i];
                    number[i] = number[j];
                    number[j] = temp;
                }
            }
        }

        return number;
    }

    public static void Main(string[] args)
    {
        int[] array = GetArrayFromConsole();
        int[] sorted = SortArray(array);

        Console.WriteLine("Отсортированный массив:");
        for (int i = 0; i < sorted.Length; i++)
        {
            Console.WriteLine(sorted[i]);
        }
    }
}*/






/*using System;


class Program
{

    public static void Main(string[] args)
    {
        var someName = "Евгений";
        Console.WriteLine(someName);

        var someAge = 17;
        Console.WriteLine(someAge);


        GetName(ref someName);
        ChangeAge(someAge);

        Console.WriteLine(someName);
        Console.WriteLine(someAge);

        Console.ReadKey();
    }

    static void GetName(ref string name)
    {
        Console.WriteLine("Введите имя: ");
        name = Console.ReadLine();
        
    }

    static void ChangeAge(int age)
    {
        Console.WriteLine("Введите возраст: ");
        age = Convert.ToInt32(Console.ReadLine());
    }
}*/


/*using System;

class MainClass
{
    public static void Main(string[] args)
    {

        var arr = new int[] { 1, 2, 3 };
        BigDataOperation(arr);

        Console.WriteLine(arr[0]);

    }

    static void BigDataOperation(in int[] arr)
    {
        arr[0] = 4;
    }
}*/




//C использованием ref
/*using System;

class NurClass
{
    static int[] GetArrayFromConsole(ref int nur)
    {
        var result = new int[nur];

        for (int i = 0; i < result.Length; i++)
        {
            Console.Write("Введите элемент {0}: ", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }

    static int[] SortArray(int[] number)
    {
        int temp;

        for (int i = 0; i < number.Length; i++)
        {
            for (int j = i + 1; j < number.Length; j++)
            {
                if (number[i] > number[j])
                {
                    temp = number[i];
                    number[i] = number[j];
                    number[j] = temp;
                }
            }
        }

        return number;
    }

    public static void Main(string[] args)
    {
        int nur = 6;
        int[] array = GetArrayFromConsole(ref nur);
        int[] sorted = SortArray(array);

        Console.WriteLine("Отсортированный массив:");
        for (int i = 0; i < sorted.Length; i++)
        {
            Console.WriteLine(sorted[i]);
        }
    }
}*/