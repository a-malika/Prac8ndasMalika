using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class AirConditioning
    {
        private string status = "off";
        public void TurnOn()
        {
            if (status == "off")
            {
                status = "on";
                Console.WriteLine("Кондиционер включен.");
            }
            else
            {
                Console.WriteLine("Кондиционер итак включен.");
            }
        }
        public void TurnOff()
        {
            if (status == "on")
            {
                status = "off";
                Console.WriteLine("Кондиционер выключен.");
            }
            else
            {
                Console.WriteLine("Кондиционер итак выключен.");
            }
        }
    }
}
