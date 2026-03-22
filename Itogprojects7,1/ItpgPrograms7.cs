/*using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp8
{
    class ItpgPrograms7
    {
        // обобщенная коллекция
        public static LinkedList<string> linkedList = new LinkedList<string>();
        //список 
        public static List<string> list = new List<string>();

        static void Main(string[] args)

        {
            //Где хранится файл txt
            var filePath = @"C:\Users\obido\Desktop\input";

            //Начинаем новый счет
            var watchWon = Stopwatch.StartNew();

            //Добавляем текст в начало и канец
            linkedList.AddFirst(filePath);
            linkedList.AddLast(filePath);

            //когда все добавлено останавливаем
            watchWon.Stop();

            //Вывод на консоль
            Console.WriteLine(watchWon.Elapsed.TotalMilliseconds);


            //Начинаем новый счет
            var watchTwo = Stopwatch.StartNew();

            //Добавляем текст
            list.Add(filePath);
            list.Insert(0, filePath);

            //когда все добавлено останавливаем
            watchTwo.Stop();

            //Вывод на консоль
            Console.WriteLine(watchTwo.Elapsed.TotalMilliseconds);
        }
    }
}
*/