using System;
using YoutubeExplode;


namespace ItogUrokPatern
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Создаем экземпляр YoutubeClient для взаимодействия с YouTube API
            var client = new YoutubeClient();
            Console.WriteLine("Введите URL видео:");
            string url = Console.ReadLine();

            // Создаем и выполняем команды для получения информации о видео и его загрузки
            Command getInfoCommand = new GetVideoInfoCommand(client, url);
            await getInfoCommand.Execute();

            // После получения информации о видео, выполняем команду для его загрузки
            Command downloadCommand = new GetCommandDownload(client, url);
            await downloadCommand.Execute();
        }
    }
}