using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.Enums;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;

namespace ItogProject5.Controller
{
    public class ColbackController
    {
        private readonly ITelegramBotClient _telegramClient;

        public ColbackController(ITelegramBotClient telegramClient)
        {
            _telegramClient = telegramClient;
        }

        // Команда /start
        public async Task Handle(Message message, CancellationToken cs)
        {
            var buttons = new List<InlineKeyboardButton[]>
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("Считать кол-во букв", "count_letters"),
                    InlineKeyboardButton.WithCallbackData("Сумма чисел", "sum_numbers")
                }
            };

            await _telegramClient.SendMessage(
                message.Chat.Id,
                "<b>Наш бот умеет считать кол-во букв в тексте и считать сумму чисел</b>",
                parseMode: ParseMode.Html,
                replyMarkup: new InlineKeyboardMarkup(buttons),
                cancellationToken: cs
            );
        }

        // Обработка нажатия кнопок
        public async Task HandleCallbackQuery(CallbackQuery callbackQuery, CancellationToken cs)
        {
            var chatId = callbackQuery.Message.Chat.Id;

            switch (callbackQuery.Data)
            {
                case "count_letters":

                    await _telegramClient.SendMessage(
                        chatId,
                        "Отправьте текст, чтобы я посчитал количество букв",
                        cancellationToken: cs
                    );

                    break;

                case "sum_numbers":

                    await _telegramClient.SendMessage(
                        chatId,
                        "Отправьте числа через пробел, чтобы я посчитал их сумму",
                        cancellationToken: cs
                    );

                    break;

                default:

                    await _telegramClient.SendMessage(
                        chatId,
                        "Неизвестная команда",
                        cancellationToken: cs
                    );

                    break;
            }

            await _telegramClient.AnswerCallbackQuery(callbackQuery.Id, cancellationToken: cs);
        }
    }
}