using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class LightTurnOn : ICommand
    {
        private Light light;
        public LightTurnOn(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.TurnOn();
        }
        public void Undo()
        {
            light.TurnOff();
        }
    }
}
