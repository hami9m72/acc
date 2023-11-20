using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSharp.Model
{
    public class Song
    {
        public string encodeId { get; set; }
        public string title { get; set; }
        public string alias { get; set; }
        public bool isOffical { get; set; }
        public string username { get; set; }
        public string artistsNames { get; set; }
        public List<Artist> artists { get; set; }
        public bool isWorldWide { get; set; }
        public string thumbnailM { get; set; }
        public Image thumbnailMImg { get; set; }
        public string link { get; set; }
        public string thumbnail { get; set; }
        public int duration { get; set; }
        public bool isZMA { get; set; }
        public bool zingChoise { get; set; }
        public bool isPrivate { get; set; }
        public bool preRelease { get; set; }
        public int releaseDate { get; set; }
        public List<object> indicators { get; set; }
        public bool isIndie { get; set; }
        public string mvlink { get; set; }
        public int streamingStatus { get; set; }
        public bool allowAudioAds { get; set; }
        public bool hasLyric { get; set; }
        public int userid { get; set; }
        public List<Genre> genres { get; set; }
        public List<Composer> composers { get; set; }
        public Album album { get; set; }
        public bool isRBT { get; set; }
        public int like { get; set; }
        public int listen { get; set; }
        public bool liked { get; set; }
        public int comment { get; set; }
        public Streaming streaming { get; set; }


    }
}
