using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Model
{
    public class Playlist
    {
        public string name;
        public List<Song> files;

        public Playlist()
        {
            this.files = new List<Song>();
        }
        public Playlist(string name)
        {
            this.name = name;
            this.files = new List<Song>();
        }


    }
}
