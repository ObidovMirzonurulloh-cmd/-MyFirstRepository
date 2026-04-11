using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class AuthenticationView
    {
        //поле для сервиса аутентификации
        UserService _userService;
        public AuthenticationView(UserService userService)
        {
            _userService = userService;
        }

        //метод для отображения интерфейса аутентификации и обработки ввода пользователя
        public void Show()
        {
            var authenticationData = new UserAuthenticationData();

            Console.WriteLine("Введите почтовый адрес:");
            authenticationData.Email = Console.ReadLine();

            Console.WriteLine("Введите пароль:");
            authenticationData.Password = Console.ReadLine();

            //попытка аутентификации пользователя и обработка возможных исключений
            try
            {
                var user = this._userService.Authenticate(authenticationData);
                SuccessMessage.Show("Вы успешно вошли в социальную сеть!");
                SuccessMessage.Show("Добро пожыловать " + user.FirstName);

                Program.userMenuView.Show(user);

            }
            catch (WrongPasswordException)
            {
                AlertMessage.Show("Пароль не коретный!");
            }
            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден!");
            }
          
        }
    }
}
