using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public abstract class IUser
    {
        public string Name { get; set; }
        protected IMediator Mediator { get; set; }
        public IUser(string name, IMediator mediator)
        {
            Name = name;
            Mediator = mediator;
            mediator.RegisterColleague(this);
        }
        public abstract void SendPublicMessage(string message);
        public abstract void SendChatMessage(string message, Channel chat);
        public abstract void SendPrivateMessage(string message, IUser colleague);
        public abstract void RecieveMessage(string message, string type);
    }
}
