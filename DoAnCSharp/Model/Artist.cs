using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSharp.Model
{
    public class Artist
    {
        public string id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public bool spotlight { get; set; }
        public string alias { get; set; }
        public string thumbnail { get; set; }
        public string thumbnailM { get; set; }
        public int totalFollow { get; set; }
    }
}
