using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.DAL.Entities;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class AddDataView
    {
        /// <summary>

        Friend _addFriend;
        public AddDataView(Friend addFriend)
        {
            _addFriend = addFriend;
        }

        //метод для отображения интерфейса добавления друга и обработки ввода пользователя
        public void Show(User user)
        {
            var addData = new AddData();
            Console.WriteLine("Введите почту друга которого хотите добавить: ");
            addData.Email = Console.ReadLine();

            try
            {
                _addFriend.AddFriend(addData);
                SuccessMessage.Show("Друг успешно добавлен");
            }
            catch (Exception ex)
            {
                AlertMessage.Show($"Ошибка: {ex.Message}");
            }


        }
    }
}
  
