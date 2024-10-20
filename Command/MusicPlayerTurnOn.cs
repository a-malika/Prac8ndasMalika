using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class MusicPlayerTurnOn : ICommand
    {
        private MusicPlayer musicPlayer;
        public MusicPlayerTurnOn(MusicPlayer musicPlayer)
        {
            this.musicPlayer = musicPlayer;
        }
        public void Execute()
        {
            musicPlayer.TurnOn();
        }
        public void Undo()
        {
            musicPlayer.TurnOff();
        }
    }
}
