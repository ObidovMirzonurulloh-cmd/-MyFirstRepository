using NUnit.Framework;
using YoutubeExplode;
using YoutubeExplode.Converter;
using System.IO;
using System.Threading.Tasks;

namespace TestCommandVideos
{
    public class Tests
    {
        private string _url = "https://youtu.be/wvnuRr9Yd24?si=5YwaSu3bIFAxS9WP";

        [Test]
        public async Task DescriptionCommandTest()
        {
            var client = new YoutubeClient();
            var video = await client.Videos.GetAsync(_url);

            Assert.IsNotNull(video, "Видео не найдено");
            Assert.IsNotEmpty(video.Title, "Название видео пустое");
            Assert.IsNotEmpty(video.Description, "Описание видео пустое");

            // Для проверки в консоли
            TestContext.WriteLine("Title: " + video.Title);
            TestContext.WriteLine("Description: " + video.Description);
        }

        [Test]
        public async Task TestDownloadVideoCommand()
        {
            var client = new YoutubeClient();
            string outputFile = "video.mp4";

            await client.Videos.DownloadAsync(_url, outputFile, builder =>
                builder.SetPreset(ConversionPreset.UltraFast).SetFFmpegPath("ffmpeg.exe"));

            Assert.IsTrue(File.Exists(outputFile), "Видео не скачано");
            Assert.IsTrue(new FileInfo(outputFile).Length > 0, "Скачанное видео пустое");
        }
    }
}