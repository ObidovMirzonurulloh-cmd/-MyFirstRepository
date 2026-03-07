using System;
using System.Collections.Generic;
using System.Threading;

class User
{
    public string Login { get; set; }
    public string Name { get; set; }
    public bool IsPremium { get; set; }
}

class Program
{
    static void Main()
    {
        List<User> users = new List<User>()
        {
            new User { Login = "user1", Name = "Анна", IsPremium = true },
            new User { Login = "user2", Name = "Олег", IsPremium = false },
            new User { Login = "user3", Name = "Мария", IsPremium = false },
            new User { Login = "user4", Name = "Иван", IsPremium = true }
        };

        foreach (var user in users)
        {
            Console.WriteLine($"Здравствуйте, {user.Name}!");

            if (!user.IsPremium)
            {
                ShowAds();
            }
        }
    }

    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        Thread.Sleep(3000);
    }
}