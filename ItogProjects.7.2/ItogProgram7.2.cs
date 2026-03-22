using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        //Путь к файлу.txt
        var filePath = @"C:\Users\obido\Desktop\input.txt.txt";
        //выведем текст из файла
        var text = File.ReadAllText(filePath);


        var words = text.Split(' ');
        //Создаём словарь
        Dictionary<string, int> dict = new Dictionary<string, int>();

        //пробегаем по словарь и шитаем сколько раз встречаются слова
        foreach (var word in words)
        {
            if (dict.ContainsKey(word))
                dict[word]++;
            else
                dict[word] = 1;
        }

        //Цыкл для дово чтобы получить 10 самых повторяемх слов
        for (int i = 0; i < 10; i++)
        {
            string maxWord = null;
            int maxCount = 0;

            foreach (var pair in dict)
            {
                if (pair.Value > maxCount)
                {
                    maxCount = pair.Value;
                    maxWord = pair.Key;
                }
            }

            
            if (maxWord == null)
                break;

            Console.WriteLine(maxWord + "-" + maxCount);

            dict.Remove(maxWord);
        }
    }
}