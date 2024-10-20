using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class User : IUser
    {
        public User(string name, IMediator mediator) : base(name, mediator) { }

        public override void SendPublicMessage(string message)
        {
            Mediator.SendPublicMessage(message, this);
        }
        public override void SendChatMessage(string message, Channel chat)
        {
            Mediator.SendChatMessage(message, this, chat);
        }
        public override void SendPrivateMessage(string message, IUser colleague)
        {
            Mediator.SendPrivateMessage(message, this, colleague);
        }
        public override void RecieveMessage(string message, string type)
        {
            Console.WriteLine($"{type}: Сообщение для {Name}: '{message}'.");
        }
    }
}
