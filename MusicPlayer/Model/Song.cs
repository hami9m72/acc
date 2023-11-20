using MusicPlayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Model
{
    public abstract class Song
    {
        public bool isLiked = false;
        public Lyric lyric = null;

        public abstract string GetEncodedId();
        public abstract string GetTitle();
        public abstract string GetAlbumName();
        public abstract string GetArtistNameJoined();
        public abstract string GetSrc();
        public abstract void SetSrc(string src);
        public abstract object GetThumbImg();
        public abstract int GetDuration();
        public string GetFormatedDuration()
        {
            return TimeSpan.FromSeconds(GetDuration()).ToString(@"mm\:ss");
        }
        public virtual async Task<Lyric> GetLyric()
        {
            if (lyric == null)
            {
                if (GetEncodedId() != "")
                {
                    lyric = await MediaService.GetSongLyric(GetEncodedId());
                }
            }
            return lyric;
        }
    }
}
