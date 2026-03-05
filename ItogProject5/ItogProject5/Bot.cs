using ItogProject5.Controller;
using Microsoft.Extensions.Hosting;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ItogProject5.Controller
{
    internal class Bot : BackgroundService
    {
        private readonly ITelegramBotClient _telegramClient;
        private readonly ColbackController _colbackController;
        private readonly CountTextController _countTextController;
        private readonly CountNumber _countNumber;

        public Bot(
            ITelegramBotClient telegramClient,
            ColbackController colbackController,
            CountTextController countTextController,
            CountNumber countNumber
        )
        {
            _telegramClient = telegramClient;
            _colbackController = colbackController;
            _countTextController = countTextController;
            _countNumber = countNumber;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _telegramClient.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                new ReceiverOptions()
                {
                    AllowedUpdates = { }
                },
                cancellationToken: stoppingToken
            );

            Console.WriteLine("Бот запущен.");
        }

        private async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cs)
        {
            // Обработка нажатия кнопок
            if (update.Type == UpdateType.CallbackQuery)
            {
                await _colbackController.HandleCallbackQuery(update.CallbackQuery, cs);
                return;
            }

            // Обработка текстовых сообщений
            if (update.Type == UpdateType.Message && update.Message.Type == MessageType.Text)
            {
                var text = update.Message.Text;

                if (text == "/start")
                {
                    await _colbackController.Handle(update.Message, cs);
                    return;
                }

                bool allNumbers = text.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                      .All(x => int.TryParse(x, out _));

                if (allNumbers)
                {
                    await _countNumber.Handle(update.Message, cs);
                }
                else
                {
                    await _countTextController.Handle(update.Message, cs);
                }
            }
        }

        private Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            var errorMessage = exception switch
            {
                ApiRequestException apiRequestException
                    => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };

            Console.WriteLine(errorMessage);
            Console.WriteLine("Ожидаем 10 секунд перед повторным подключением.");

            Thread.Sleep(10000);

            return Task.CompletedTask;
        }
    }
}