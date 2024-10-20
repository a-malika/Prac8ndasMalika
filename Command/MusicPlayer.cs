using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class MusicPlayer
    {
        private string status = "off";
        private string is_playing = "no";
        public void TurnOn()
        {
            if (status == "off")
            {
                status = "on";
                Console.WriteLine("Музыкальный плеер включен.");
            }
            else
            {
                Console.WriteLine("Музыкальный плеер итак включен.");
            }
        }
        public void TurnOff()
        {
            if (status == "on")
            {
                status = "off";
                is_playing = "no";
                Console.WriteLine("Музыкальный плеер выключен.");
            }
            else
            {
                Console.WriteLine("Музыкальный плеер итак выключен.");
            }
        }
        public void PlayMusic()
        {
            if (status == "on")
            {
                if (is_playing == "no")
                {
                    is_playing = "yes";
                    Console.WriteLine("Музыка включена.");
                }
                else
                {
                    Console.WriteLine("Музыка итак включена.");
                }
            }
            else
            {
                Console.WriteLine("Невозможно включить музыку, так как музыкальный плеер выключен.");
            }
        }
        public void StopMusic()
        {
            if (is_playing == "yes")
            {
                is_playing = "no";
                Console.WriteLine("Музыка выключена.");
            }
            else
            {
                Console.WriteLine("Музыка итак выключена.");
            }
        }
    }
}
