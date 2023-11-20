using MusicPlayer.Service;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Model
{
    public class SongOnline : Song
    {
        public JObject data;

        public SongOnline(JObject data)
        {
            this.data = data;
        }

        public override string GetAlbumName()
        {
            if (data["album"] != null)
                return data["album"]["title"].ToString();
            return "";
        }

        public override string GetArtistNameJoined()
        {
            return data["artistsNames"].ToString();
        }

        public override int GetDuration()
        {
            return Convert.ToInt32(data["duration"].ToString());
        }

        public override string GetEncodedId()
        {
            return data["encodeId"].ToString();
        }

        public override string GetSrc()
        {
            if (data["streamLink"] == null)
                return "";
            return data["streamLink"].ToString();
        }



        public override object GetThumbImg()
        {
            return data["thumbnailM"].ToString();
        }

        public override string GetTitle()
        {
            return data["title"].ToString();
        }

        public override void SetSrc(string src)
        {
            if (GetSrc() == "")
            {
                data["streamLink"] = src;
            }
        }
    }
}
