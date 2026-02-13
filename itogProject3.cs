// Первая задача

/*using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ItogProject3
{
    //Делаем собственное исключение
    public class MyCustomException : Exception
    {
        public MyCustomException(string message)
            : base(message)
        {
        }
    }

    class Program
    {
    static void Main(string[] args)
        {
            //Создаем массив исключений
            Exception[] exceptions = new Exception[]
            {
                new ArgumentNullException("Аргумент, передаваемый в метод — null."),
                new FileNotFoundException("Файл не существует."),
                new InvalidOperationException("Вызов метода недопустим в текущем состоянии объекта."),
                new RankException("В метод передается массив с неправильным числом измерений."),
                new MyCustomException("Собственное сключение!")
            };

            //Перебираем массив исключений и обрабатываем каждое в отдельности
            foreach (Exception ex in exceptions)
            {
                try
                {
                   throw ex;


                }
                catch (ArgumentNullException exs)
                {
                    Console.WriteLine($"Catch ArgumentNull{exs}");
                }
                catch (FileNotFoundException exs)
                {
                    Console.WriteLine($"Catch FileNotFound{exs}");
                }
                catch (InvalidOperationException exs)
                {
                    Console.WriteLine($"Catch InvalidOperation{exs}");
                }
                catch (RankException exs)
                {
                    Console.WriteLine($"Catch Rank{exs}");
                }
                catch (MyCustomException exs)
                {
                    Console.WriteLine($"Catch MyCustom{exs}");
                }
                finally
                {
                    Console.WriteLine("Блок finally выполнен.\n");
                }

            }

        }

    }
}*/



//Вторая задача
using System;
using System.Collections.Generic;

namespace ItogProject3
{
    // Собственное исключение
    public class MyCustomException : Exception
    {
        public MyCustomException(string message)
            : base(message)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<string> surnames = new List<string>
            {
                "Иванов",
                "Петров",
                "Сидоров",
                "Ахмедов",
                "Кузнецов"
            };

            NumberClass numberClass = new NumberClass();

            //Подписка на событие
            numberClass.NumberEvent += (type) => SortedList(surnames, type);

            try
            {
                numberClass.Numbers();
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено некорректное значение");
            }
            finally
            {
                Console.WriteLine("Блок finally выполнен.");
            }
        }

        // Метод сортировки
        static void SortedList(List<string> list, int type)
        {
            if (type == 1)
                list.Sort(); // А-Я
            else
                list.Sort((a, b) => b.CompareTo(a)); // Я-А

            Console.WriteLine("\nОтсортированный список:");

            foreach (var item in list)
                Console.WriteLine(item);
        }
    }

    class NumberClass
    {
        //Делегат
        public delegate void ObjNumberDelegate(int number);

        //Событие
        public event ObjNumberDelegate NumberEvent;

        //Ввод числа
        public void Numbers()
        {
            Console.WriteLine();
            Console.WriteLine("Для сортировки от А до Я — 1, от Я до А — 2:");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
                throw new MyCustomException("Вы ввели не число!");

            if (number != 1 && number != 2)
                throw new MyCustomException("Можно вводить только 1 или 2!");

            NumberEntered(number);
        }

        //Вызов события
        protected virtual void NumberEntered(int number)
        {
            NumberEvent?.Invoke(number);
        }
    }
}
