using ItogProject5.Controller;
using ItogProject5.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text;
using Telegram.Bot;



namespace ItogProject5.Controller
{
    public class Program
    {
        private readonly AppSettings _appSettings;
        public static async Task Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            var host = new HostBuilder()
                .ConfigureServices((hostContext, services) => ConfigureServices(services))
                .UseConsoleLifetime()
                .Build();

            Console.WriteLine("Starting Service");
            await host.RunAsync();
            Console.WriteLine("Service stopped");
        }



        static void ConfigureServices(IServiceCollection services)
        {
            AppSettings appSettings = BuildAppSettings();
            services.AddSingleton(appSettings);



            services.AddTransient<ColbackController>();
            services.AddTransient<InlineKeyboardController>();

            services.AddSingleton<CountTextController>();
            services.AddSingleton<CountNumber>();
            services.AddSingleton<ITelegramBotClient>(provider => new TelegramBotClient(appSettings.BotToken));
            services.AddHostedService<Bot>();
        }


        static AppSettings BuildAppSettings()
        {
            return new AppSettings()
            {

                BotToken = "8499249727:AAHwJa_jnc2FPSM-CU8hhcbN85SY2cllqso",
            };
        }

    }
}






