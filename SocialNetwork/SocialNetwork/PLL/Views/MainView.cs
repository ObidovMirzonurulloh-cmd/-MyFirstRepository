using SocialNetwork.BLL.Models;
using System;

namespace SocialNetwork.PLL.Views
{
    public class MainView
    {
        //метод для отображения главного меню и обработки ввода пользователя
        public void Show()
        {
            Console.WriteLine("Добро пожаловать в социальную сеть.");
            Console.WriteLine("Войти в профиль (нажмите 1)");
            Console.WriteLine("Зарегистрироваться (нажмите 2)");

            //обработка выбора пользователя и вызов соответствующих представлений для аутентификации или регистрации
            switch (Console.ReadLine())
            {
                case "1":
                    Program.authenticationView.Show();
                    break;

                case "2":
                    Program.registrationView.Show();
                    break;
 
            }
        }
    }
}