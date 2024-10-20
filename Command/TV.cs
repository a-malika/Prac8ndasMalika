using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class TV
    {
        private string status = "off";
        public void TurnOn()
        {
            if (status == "off")
            {
                status = "on";
                Console.WriteLine("Телевизор включен.");
            }
            else
            {
                Console.WriteLine("Телевизор итак включен.");
            }
        }
        public void TurnOff()
        {
            if (status == "on")
            {
                status = "off";
                Console.WriteLine("Телевизор выключен.");
            }
            else
            {
                Console.WriteLine("Телевизор итак выключен.");
            }
        }
    }
}
