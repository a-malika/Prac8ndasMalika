using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class MusicPlayerStop : ICommand
    {
        private MusicPlayer musicPlayer;
        public MusicPlayerStop(MusicPlayer musicPlayer)
        {
            this.musicPlayer = musicPlayer;
        }
        public void Execute()
        {
            musicPlayer.StopMusic();
        }
        public void Undo()
        {
            musicPlayer.PlayMusic();
        }
    }
}
