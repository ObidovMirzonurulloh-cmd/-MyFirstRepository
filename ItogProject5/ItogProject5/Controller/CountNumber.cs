using Telegram.Bot;
using Telegram.Bot.Types;

namespace ItogProject5.Controller
{
    public class CountNumber
    {
        private readonly ITelegramBotClient _telegramClient;

        public CountNumber(ITelegramBotClient telegramClient)
        {
            _telegramClient = telegramClient;
        }

        public async Task Handle(Message message, CancellationToken cs)
        {
            var parts = message.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            bool isNumber = true;

            foreach (var part in parts)
            {
                if (int.TryParse(part, out int number))
                    sum += number;
                else
                {
                    isNumber = false;
                    break;
                }
            }

            if (isNumber)
                await _telegramClient.SendMessage(message.Chat.Id, $"Сумма чисел: {sum}", cancellationToken: cs);
            else
                await _telegramClient.SendMessage(message.Chat.Id, "Введите числа через пробел", cancellationToken: cs);
        }
    }
}