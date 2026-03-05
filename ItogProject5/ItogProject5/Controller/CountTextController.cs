using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace ItogProject5.Controller
{
    public class CountTextController
    {
        private readonly ITelegramBotClient _telegramClient;

        public CountTextController(ITelegramBotClient telegramClient)
        {
            _telegramClient = telegramClient;
        }
        public async Task Handle(Message message, CancellationToken cs)
        {
            if (message.Type == MessageType.Text)
            {
                await _telegramClient.SendMessage(
                    message.Chat.Id,
                    $"Длина вашего сообщения: {message.Text.Length}",
                    cancellationToken: cs);
            }
        }
    }
}
