using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class ChatMediator : IMediator
    {
        private List<IUser> colleagueList;
        private List<Channel> chatList;
        public ChatMediator()
        {
            colleagueList = new List<IUser>();
            chatList = new List<Channel>();
        }
        public void RegisterColleague(IUser colleague)
        {
            colleagueList.Add(colleague);
            Console.WriteLine("Пользователь {0} добавлен в глобальный чат.", colleague.Name);
        }
        public void RegisterChat(Channel chat)
        {
            chatList.Add(chat);
            Console.WriteLine("Добавлен новый чат '{0}'.", chat.Name);
        }
        public void SendPublicMessage(string message, IUser colleague)
        {
            foreach (var col in colleagueList)
            {
                if (col != colleague)
                {
                    col.RecieveMessage(message, "Глобальный чат");
                }
            }
        }
        public void SendChatMessage(string message, IUser colleague, Channel chat)
        {
            if (chat.colleagueList.Contains(colleague))
            {
                foreach (var col in chat.colleagueList)
                {
                    if (col != colleague)
                    {
                        col.RecieveMessage(message, $"Чат '{chat.Name}'");
                    }
                }
            }
            else
            {
                Console.WriteLine("Пользователь {0} не может отправить сообщение в чат '{1}'. Он не зарегистрирован в нем.", colleague.Name, chat.Name);
            }
        }
        public void SendPrivateMessage(string message, IUser colleague1, IUser colleague2)
        {
            colleague2.RecieveMessage(message, $"{colleague1.Name}");
        }

    }
}
