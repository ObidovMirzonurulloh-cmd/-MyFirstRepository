/*string[] favcolors = new string[3];

for (int i = 0; i < favcolors.Length; i++)
{
    Console.WriteLine("Введите любимый цвет номер {0}", i + 1);
    favcolors[i] = Console.ReadLine();
}

foreach (var color in favcolors)
{
    switch (color)
}*/


/*using System;

class MainClass
{
    public static void Main(string[] args)
    {

        //Размерность массива 
        var arr = new int[] { 1, 2, 3, 4 };
        var l = arr.Length;

        //Разные виды инициализации массива
        int[] arr1 = new int[4] { 1, 2, 3, 5 };
        int[] arr2 = new int[] { 1, 2, 3, 5 };
        int[] arr3 = new[] { 1, 2, 3, 5 };
        int[] arr4 = { 1, 2, 3, 5 };

    }
}*/



/*using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите своё имя");

        var name = Console.ReadLine();

        Console.WriteLine("Ваше имя по буквам: ");

        foreach (var ch in name)
        {
            Console.Write(ch + " ");
        }

        Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);

        Console.ReadKey();
    }
}*/



//Масив
/*using System;


class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите своё имя");
        var name = Console.ReadLine();

        Console.WriteLine("Ваше имя по буквам: ");

        for (int i = name.Length- 1; i >= 0; i--)
        {
            Console.Write(name[i] + " ");
        }
        Console.ReadKey();
            
        }
    }
}*/



//Масив

/*using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
        Console.WriteLine(array[0, 0]);
    }
}*/



// массив через цикл foreach
/*
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
        foreach (var item in array) {
        Console.WriteLine(item + "");
    }
}
}*/



//обратимся к длине двумерного массива
/*using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
        Console.WriteLine(array.Length);
    }
}*/