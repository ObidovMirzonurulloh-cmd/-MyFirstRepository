using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace ItogUrokPatern
{
    //Класс для команды скачивания видео с YouTube
    class GetCommandDownload : Command
   {
        private string _url;

        // Конструктор, принимающий клиента и URL видео
        public GetCommandDownload(YoutubeClient client, string url) : base(client)
        {
            _url = url;
        }

        // Метод для выполнения команды скачивания видео
        public override async Task Execute()
        {
            await _client.Videos.DownloadAsync(_url, "video.mp4", 
                builder => builder.SetPreset(ConversionPreset.UltraFast)
                .SetFFmpegPath("ffmpeg.exe")
                );
            Console.WriteLine("Видео скачано");
            
        }
    }
}
