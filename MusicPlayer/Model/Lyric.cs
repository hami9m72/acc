using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Model
{
    public class Lyric
    {
        public List<Sentence> sentences { get; set; }
        public string file { get; set; }
        public bool enabledVideoBG { get; set; }
        public List<string> defaultIBGUrls { get; set; }
        public List<string> defaultVBGUrls { get; set; }
        public int BGMode { get; set; }

        public bool hasLocalLyric = false;
        public string localLyric = "";
    }

    public class Word
    {
        public int startTime { get; set; }
        public int endTime { get; set; }
        public string data { get; set; }
    }

    public class Sentence
    {
        public List<Word> words { get; set; }
        public string fullSentence()
        {
            return string.Join(" ", words.Select(e => e.data));
        }
    }
}
