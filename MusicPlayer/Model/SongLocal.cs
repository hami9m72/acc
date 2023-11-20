using MusicPlayer.Service;
using MusicPlayer.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;
using TagLib.Id3v2;

namespace MusicPlayer.Model
{
    public class SongLocal : Song
    {
        public File file;

        public SongLocal(File file)
        {
            this.file = file;
        }

        public override async Task<Lyric> GetLyric()
        {
            if (lyric == null)
            {
                if (GetEncodedId() != "")
                {
                    lyric = await MediaService.GetSongLyric(GetEncodedId());
                }
                if (lyric == null)
                {
                    if (file.Tag.Lyrics != null && file.Tag.Lyrics != "")
                    {
                        lyric = new Lyric();
                        lyric.localLyric = file.Tag.Lyrics;
                        lyric.hasLocalLyric = true;
                    }
                }
            }

            return lyric;
        }

        public override string GetAlbumName()
        {
            return file.Tag.Album;
        }

        public override string GetArtistNameJoined()
        {
            return file.Tag.JoinedPerformers;
        }

        public override int GetDuration()
        {
            return (int)file.Properties.Duration.TotalSeconds;
        }

        public override string GetEncodedId()
        {
            TagLib.Id3v2.Tag t = (TagLib.Id3v2.Tag)file.GetTag(TagTypes.Id3v2);
            PrivateFrame p = PrivateFrame.Get(t, "EncodedId", false); // This is important. Note that the third parameter is false.
            if (p != null)
                return Encoding.Unicode.GetString(p.PrivateData.Data);
            return "";
        }

        public override string GetSrc()
        {
            return file.Name;
        }

        public override object GetThumbImg()
        {
            if (file.Tag.Pictures.Length > 0)
                return Helper.LoadImageFromByteArray(file.Tag.Pictures[0].Data.Data);
            return null;
        }

        public override string GetTitle()
        {
            return file.Tag.Title;
        }

        public override void SetSrc(string src)
        {

        }
    }
}
