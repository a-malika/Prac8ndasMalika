using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class Program
    {
        static void Main(string[] args)
        {
            IMediator Mediator = new ChatMediator();
            User user1 = new User("Миша", Mediator);
            User user2 = new User("Саша", Mediator);
            User user3 = new User("Маша", Mediator);
            User user4 = new User("Анатолий", Mediator);
            User user5 = new User("Констанция", Mediator);

            user1.SendPublicMessage("Всем привет!!");
            user4.SendPublicMessage("И тебе привет!");
            user2.SendPrivateMessage("Хэй? Что задали по матеше?", user3);

            Channel chat1 = new Channel("Окончанье -ша", Mediator);
            Channel chat2 = new Channel("Нумерологи-Астрологи-Онторингологи", Mediator);

            chat1.AddColleague(user1);
            chat1.AddColleague(user2);
            chat1.AddColleague(user3);

            chat2.AddColleague(user3);
            chat2.AddColleague(user4);
            chat2.AddColleague(user5);

            user1.SendChatMessage("Как делишки? Кто со мной в кино?", chat1);
            user1.SendChatMessage("Как делишки? Кто со мной в кино?", chat2);
            user5.SendChatMessage("Кто сделает бесплатный расклад? Срочно.", chat2);
            chat2.RemoveColleague(user3);
        }
    }
}
