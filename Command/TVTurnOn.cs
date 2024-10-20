using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class TVTurnOn : ICommand
    {
        private TV tv;
        public TVTurnOn(TV tv)
        {
            this.tv = tv;
        }
        public void Execute()
        {
            tv.TurnOn();
        }
        public void Undo()
        {
            tv.TurnOff();
        }
    }
}
