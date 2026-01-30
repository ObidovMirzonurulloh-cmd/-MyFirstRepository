//работа с методом с параметром out Массив по возрастанию Массив по убыванию
/*using System;

class NurClass
{
    static int[] GetArrayFromConsole()
    {
        var result = new int[6];

        for (int i = 0; i < result.Length; i++)
        {
            Console.Write("Введите элемент {0}: ", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }

    static int[] SortArrayAsc(int[] number)
    {
        int[] copy = (int[])number.Clone();
        int temp;

        for (int i = 0; i < copy.Length; i++)
        {
            for (int j = i + 1; j < copy.Length; j++)
            {
                if (copy[i] > copy[j])
                {
                    temp = copy[i];
                    copy[i] = copy[j];
                    copy[j] = temp;
                }
            }
        }

        return copy;
    }

    static int[] SortArrayDesc(int[] nums)
    {
        int[] copy = (int[])nums.Clone();
        int temp;

        for (int i = 0; i < copy.Length; i++)
        {
            for (int j = i + 1; j < copy.Length; j++)
            {
                if (copy[i] < copy[j])
                {
                    temp = copy[i];
                    copy[i] = copy[j];
                    copy[j] = temp;
                }
            }
        }

        return copy;
    }

    static void SortArray(int[] array, out int[] sortedAsc, out int[] sortedDesc)
    {
        sortedAsc = SortArrayAsc(array);
        sortedDesc = SortArrayDesc(array);
    }

    public static void Main(string[] args)
    {
        int[] array = GetArrayFromConsole();

        SortArray(array, out int[] sortedAsc, out int[] sortedDesc);

        Console.WriteLine("Массив по возрастанию:");
        foreach (int num in sortedAsc)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("Массив по убыванию:");
        foreach (int num in sortedDesc)
        {
            Console.WriteLine(num);
        }
    }
}*/




/*using System;

class MainClass
{

    int val = 8;

    public static void Main(string[] args)
    {

        int val = 10;
        Doubled(ref val);
        Console.WriteLine(val);
        Console.ReadKey();
    }

    static void Doubled(ref int val)
    {
        val *= 2;
    }
}*/




/*using System;

class MainClass
{
    int val = 8;

    public static void Main(string[] args)
    {

        int val = 9;
        {
            val++;
        }

        Console.WriteLine(val);
        Console.ReadKey();

    }
}*/

