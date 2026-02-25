using System;

namespace ItogPrograms
{
    //Интерфейс для логирования событий и ошибок
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }

    //Класс Logger, который реализует интерфейс ILogger и выводит сообщения в консоль с разными цветами для событий и ошибок
    public class Logger : ILogger
    {
        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{message}");
            Console.ResetColor();
        }

        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{message}");
            Console.ResetColor();
        }
    }

    //Интерфейс для калькулятора, который определяет метод Calculate, принимающий два числа и функцию операции
    public interface ICalculator
    {
        int Calculate(int a, int b, Func<int, int, int> operation);
    }

    class Calculator : ICalculator
    {
        private readonly ILogger _logger;

        public Calculator(ILogger logger)
        {
            _logger = logger;
        }

        public int Calculate(int a, int b, Func<int, int, int> operation)
        {
            _logger.Event($"Выполняется операция с числами {a} и {b}");
            Thread.Sleep(1000);

            try
            {
                int result = operation(a, b);
                _logger.Event($"Получен результат: {result}");
                return result;
            }
            catch (DivideByZeroException)
            {
                _logger.Error("Попытка деления на ноль!");
                throw;
            }
        }
    }

    //Главный класс программы, который создает экземпляр Logger и Calculator, и обрабатывает ввод пользователя для выполнения выбранной операции с помощью калькулятора, а также обрабатывает возможные ошибки и логирует события и ошибки
    class Program
    {
        static void Main()
        {
            ILogger logger = new Logger();
            ICalculator calculate = new Calculator(logger);
            //Используем бесконечный цикл для постоянного ввода данных пользователем и выполнения операций, с обработкой ошибок и логированием событий
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите первое число:");
                    if (!int.TryParse(Console.ReadLine(), out int number1))
                    {
                        logger.Error("Ошибка ввода первого числа.");
                        return;
                    }

                    Console.WriteLine("Введите второе число:");
                    if (!int.TryParse(Console.ReadLine(), out int number2))
                    {
                        logger.Error("Ошибка ввода второго числа.");
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
                        logger.Error("Неверный выбор операции.");
                        return;
                    }

                    int result = calculate.Calculate(number1, number2, operation);
                    Console.WriteLine($"Результат: {result}");
                }
                catch (DivideByZeroException)
                {
                    logger.Error("Ошибка: Деление на ноль!");
                }
                catch (Exception ex)
                {
                    logger.Error($"Произошла ошибка: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Программа завершена.");
                }
            }
        }
    }
}
