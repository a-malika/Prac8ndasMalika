using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class Channel
    {
        public string Name { get; set; }
        public List<IUser> colleagueList { get; private set; }
        private IMediator Mediator { get; set; }
        public Channel(string name, IMediator mediator)
        {
            Name = name;
            colleagueList = new List<IUser>();
            Mediator = mediator;
            mediator.RegisterChat(this);
        }
        public void AddColleague(IUser colleague)
        {
            colleagueList.Add(colleague);
            Console.WriteLine("Пользователь {0} добавлен в чат '{1}'.", colleague.Name, Name);
        }
        public void RemoveColleague(IUser colleague)
        {
            colleagueList.Remove(colleague);
            Console.WriteLine("Пользователь {0} удален из чата '{1}'.", colleague.Name, Name);
        }
    }
}
