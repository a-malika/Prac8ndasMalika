using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class MusicPlayerTurnOff : ICommand
    {
        private MusicPlayer musicPlayer;
        public MusicPlayerTurnOff(MusicPlayer musicPlayer)
        {
            this.musicPlayer = musicPlayer;
        }
        public void Execute()
        {
            musicPlayer.TurnOff();
        }
        public void Undo()
        {
            musicPlayer.TurnOn();
        }
    }
}
