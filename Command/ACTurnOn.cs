using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class ACTurnOn : ICommand
    {
        private AirConditioning AC;
        public ACTurnOn(AirConditioning AC)
        {
            this.AC = AC;
        }
        public void Execute()
        {
            AC.TurnOn();
        }
        public void Undo()
        {
            AC.TurnOff();
        }
    }
}
