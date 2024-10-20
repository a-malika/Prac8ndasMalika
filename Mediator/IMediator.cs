using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public interface IMediator
    {
        void RegisterColleague(IUser colleague);
        void RegisterChat(Channel chat);
        void SendPublicMessage(string message, IUser colleague);
        void SendChatMessage(string message, IUser colleague, Channel chat);
        void SendPrivateMessage(string message, IUser colleague1, IUser colleague2);
    }
}
