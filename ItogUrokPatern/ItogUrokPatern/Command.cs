using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace ItogUrokPatern
{
    // Абстрактный класс для команд, использующий YoutubeClient
    abstract class Command
    {
        protected YoutubeClient _client;

        public Command(YoutubeClient client)
        {
            _client = client;
        }

        // Абстрактный метод для выполнения команды, который должен быть реализован в наследниках
        public abstract Task Execute();
    }
}
