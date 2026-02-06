using System;

class ItogProgram
{
    static void Main(string[] args)
    {
        // Создаем кортеж для хранения данных пользователя
        (string name, string surname, int age, string pet, int favcolor) personInfo;

        // Ввод имени
        Console.WriteLine("Введите ваше имя:");
        personInfo.name = Console.ReadLine();

        // Ввод фамилии
        Console.WriteLine("Введите вашу фамилию:");
        personInfo.surname = Console.ReadLine();

        // Ввод возраста
        personInfo.age = ReadPositiveInt("Введите возраст: ");

        // Информация о питомцах
        Console.WriteLine("У вас есть питомец (да/нет): ");
        personInfo.pet = Console.ReadLine();

        string[] petNames = new string[0];
        if (personInfo.pet == "да")
        {
            int petCount = ReadPositiveInt("Сколько у вас питомцев: ");
            petNames = GetPetsName(petCount);
        }

        // Ввод любимых цветов
        personInfo.favcolor = ReadPositiveInt("Сколько у вас любимых цветов: ");
        string[] colors = ColorName(personInfo.favcolor);

        // Вывод информации
        ShowPersonInfo(personInfo, petNames, colors);
    }

    // Метод проверки положительного числа
    static int ReadPositiveInt(string message)
    {
        int number;
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (int.TryParse(input, out number) && number >= 0)
            {
                return number;
            }
            Console.WriteLine("Ошибка! Введите корректное положительное число.");
        }
    }

    // Ввод имен питомцев
    static string[] GetPetsName(int count)
    {
        string[] names = new string[count];
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Введите имя питомца {i + 1}: ");
            names[i] = Console.ReadLine();
        }
        return names;
    }

    // Ввод любимых цветов
    static string[] ColorName(int count)
    {
        string[] colors = new string[count];
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Введите любимый цвет {i + 1}: ");
            colors[i] = Console.ReadLine();
        }
        return colors;
    }

    // Вывод всей информации о пользователе
    static void ShowPersonInfo((string name, string surname, int age, string pet, int favcolor) personInfo, string[] petNames, string[] colors)
    {
        Console.WriteLine($"Имя: {personInfo.name}");
        Console.WriteLine($"Фамилия: {personInfo.surname}");
        Console.WriteLine($"Возраст: {personInfo.age}");

        if (personInfo.pet.Trim().ToLower() == "да" && petNames.Length > 0)
        {
            Console.WriteLine($"Количество питомцев: {petNames.Length}");
            Console.WriteLine("Имена питомцев: " + string.Join(", ", petNames));
        }
        else
        {
            Console.WriteLine("Питомцев нет.");
        }

        if (colors.Length > 0)
        {
            Console.WriteLine($"Количество любимых цветов: {colors.Length}");
            Console.WriteLine("Любимые цвета: " + string.Join(", ", colors));
        }
    }
}
