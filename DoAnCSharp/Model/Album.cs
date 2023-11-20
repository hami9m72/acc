using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSharp.Model
{
    public class Album
    {
        public string encodeId { get; set; }
        public string title { get; set; }
        public string thumbnail { get; set; }
        public bool isoffical { get; set; }
        public string link { get; set; }
        public bool isIndie { get; set; }
        public string releaseDate { get; set; }
        public string sortDescription { get; set; }
        public bool PR { get; set; }
        public List<Artist> artists { get; set; }
        public string artistsNames { get; set; }
    }
}
