using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class MusicPlayerPlay : ICommand
    {
        private MusicPlayer musicPlayer;
        public MusicPlayerPlay(MusicPlayer musicPlayer)
        {
            this.musicPlayer = musicPlayer;
        }
        public void Execute()
        {
            musicPlayer.PlayMusic();
        }
        public void Undo()
        {
            musicPlayer.StopMusic();
        }
    }
}
