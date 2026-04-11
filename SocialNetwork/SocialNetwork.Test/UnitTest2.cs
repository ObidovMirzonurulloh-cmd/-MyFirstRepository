using Castle.Core.Smtp;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Test
{
    [TestFixture]
    class UnitTest2
    {

        [Test]
        public void Email_Friends_Test()
        {
            var friend = new Friend();

            var data = new AddData { Email = "obidov@nur.com" };

            friend.AddFriend(data);

            Assert.AreEqual(1, friend._friends.Count);

         
        }
    }
}
