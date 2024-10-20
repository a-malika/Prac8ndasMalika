using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Создание устройств
            Light light = new Light();
            TV tv = new TV();
            AirConditioning airConditioning = new AirConditioning();
            MusicPlayer musicPlayer = new MusicPlayer();

            // Создание комманд
            ICommand com1 = new LightTurnOn(light);
            ICommand com2 = new TVTurnOn(tv);
            ICommand com3 = new ACTurnOn(airConditioning);
            ICommand com4 = new MusicPlayerTurnOn(musicPlayer);
            ICommand com5 = new MusicPlayerTurnOff(musicPlayer);
            ICommand com6 = new MusicPlayerPlay(musicPlayer);
            ICommand com7 = new MusicPlayerStop(musicPlayer);
            ICommand macroCom = new MacroCommand(new ICommand[] {com4, com6, com7, com6, com5});

            RemoteControl remoteControl = new RemoteControl();

            remoteControl.SetCommand(0, com1);
            remoteControl.SetCommand(1, com2);
            remoteControl.SetCommand(2, com3);
            remoteControl.SetCommand(3, com4);
            remoteControl.SetCommand(4, macroCom);

            remoteControl.PressButton(0);
            remoteControl.PressButton(1);
            remoteControl.PressButton(2);
            remoteControl.PressButton(3);
            remoteControl.PressButton(4);

            remoteControl.PressUndoButton();
            remoteControl.PressUndoButton();
            remoteControl.PressUndoButton();

            remoteControl.PressRedoButton();
            remoteControl.PressRedoButton();
            remoteControl.PressRedoButton();
        }
    }
}