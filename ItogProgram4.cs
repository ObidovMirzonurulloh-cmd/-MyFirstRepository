using System;

namespace ItogPrograms
{
    public interface ICalculator
    {
        int Calculate(int a, int b, Func<int, int, int> operation);
    }

    class Calculator : ICalculator
    {
        public int Calculate(int a, int b, Func<int, int, int> operation)
        {
            return operation(a, b);
        }
    }

    class Program
    {
        static void Main()
        {
            ICalculator calculate = new Calculator();
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите первое число:");
                    if (!int.TryParse(Console.ReadLine(), out int number1))
                    {
                        Console.WriteLine("Ошибка ввода.");
                        return;
                    }

                    Console.WriteLine("Введите второе число:");
                    if (!int.TryParse(Console.ReadLine(), out int number2))
                    {
                        Console.WriteLine("Ошибка ввода.");
                        return;
                    }

                    Console.WriteLine("Введите операцию (+, -, *, /):");
                    string choice = Console.ReadLine();

                    Func<int, int, int> operation = choice switch
                    {
                        "+" => (a, b) => a + b,
                        "-" => (a, b) => a - b,
                        "*" => (a, b) => a * b,
                        "/" => (a, b) =>
                        {
                            if (b == 0)
                                throw new DivideByZeroException();
                            return a / b;
                        }
                        ,
                        _ => null
                    };

                    if (operation == null)
                    {
                        Console.WriteLine("Неверный выбор");
                        return;
                    }

                    int result = calculate.Calculate(number1, number2, operation);
                    Console.WriteLine($"Результат: {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Ошибка: Деление на ноль!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Программа завершена.");
                }
            }
        }
    }
}