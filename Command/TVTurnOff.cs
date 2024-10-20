using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class TVTurnOff : ICommand
    {
        private TV tv;
        public TVTurnOff(TV tv)
        {
            this.tv = tv;
        }
        public void Execute()
        {
            tv.TurnOff();
        }
        public void Undo()
        {
            tv.TurnOn();
        }
    }
}
