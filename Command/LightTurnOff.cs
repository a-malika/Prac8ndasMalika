using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class LightTurnOff : ICommand
    {
        private Light light;
        public LightTurnOff(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.TurnOff();
        }
        public void Undo()
        {
            light.TurnOn();
        }
    }
}
