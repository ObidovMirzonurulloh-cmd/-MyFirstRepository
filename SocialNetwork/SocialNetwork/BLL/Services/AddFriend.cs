using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Services
{
    //класс для управления друзьями пользователя
    public class Friend
    {
            public List<AddData> _friends = new List<AddData>();
            public void AddFriend(AddData addData)
            {

                if (String.IsNullOrEmpty(addData.Email))
                    throw new UserNotFoundException();

                if (_friends.Any(x => x.Email == addData.Email))
                    throw new Exception("Друг уже добавлен");
                    _friends.Add(addData);

                if (!addData.Email.Contains("@"))
                {
                    throw new Exception("Некоректный эмайл!");
                }
            }


        }
    }
