using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public interface ICommand
    {
        void Execute();
        void Undo(); 
    }
}
