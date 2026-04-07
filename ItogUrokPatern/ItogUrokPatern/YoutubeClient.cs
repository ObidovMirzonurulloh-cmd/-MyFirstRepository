using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace ItogUrokPatern
{
    // Класс для команды получения информации о видео с YouTube
    class GetVideoInfoCommand : Command
    {

        private string _url;
        // Конструктор, принимающий клиента и URL видео
        public GetVideoInfoCommand(YoutubeClient client, string url) : base(client)
        {
            _url = url;
        }

        // Метод для выполнения команды получения информации о видео
        public override async Task Execute()
        {
            var video = await _client.Videos.GetAsync(_url);
            Console.WriteLine("Название видео: " + video.Title);
            Console.WriteLine("Описание видео: " + video.Description);
        }
    }
}
