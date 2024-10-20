using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class ACTurnOff : ICommand
    {
        private AirConditioning AC;
        public ACTurnOff(AirConditioning AC)
        {
            this.AC = AC;
        }
        public void Execute()
        {
            AC.TurnOff();
        }
        public void Undo()
        {
            AC.TurnOn();
        }
    }
}
