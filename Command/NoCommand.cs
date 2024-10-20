using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Команда не назначена.");
        }
        public void Undo()
        {
            Console.WriteLine("Команда не назначена.");
        }
    }
}
