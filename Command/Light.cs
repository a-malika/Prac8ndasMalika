using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class Light
    {
        private string status = "off";
        public void TurnOn()
        {
            if (status == "off")
            {
                status = "on";
                Console.WriteLine("Свет включен.");
            }
            else
            {
                Console.WriteLine("Свет итак включен.");
            }
        }
        public void TurnOff()
        {
            if (status == "on")
            {
                status = "off";
                Console.WriteLine("Свет выключен.");
            }
            else
            {
                Console.WriteLine("Свет итак выключен.");
            }
        }
    }
}
