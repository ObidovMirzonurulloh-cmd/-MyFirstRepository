using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;




namespace ItogProject5.Controller
{
    public class InlineKeyboardController
    {
        private readonly ITelegramBotClient _telegramBotClient;

        public InlineKeyboardController(ITelegramBotClient telegramBotClient)
        {
            _telegramBotClient = telegramBotClient;
        }

        internal async Task Handle(CallbackQuery? callbackQuery, CancellationToken cancellationToken)
        {
            if (callbackQuery == null)
                return;

            await _telegramBotClient.SendMessage(callbackQuery.From.Id, $"Вы нажали кнопку: {callbackQuery.Data}", cancellationToken: cancellationToken);

            
        }
    }
}