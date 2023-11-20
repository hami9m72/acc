using MusicPlayer.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.Utils
{
    public static class Helper
    {
        public static string defaultPath = "C:\\Users\\DAT\\Desktop\\music\\Top 100 VPop";
        public static string FormatTime(double time)
        {
            TimeSpan t = TimeSpan.FromSeconds(time);
            return t.ToString(@"hh\:mm\:ss");
        }

        public static bool NotNullAndNotEmpty(string s)
        {
            return s != null && s != "";
        }
        public static async Task<Image> GetImageFromURL(string url)
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, url);
            HttpResponseMessage res = await httpClient.SendAsync(req);
            return Image.FromStream(await res.Content.ReadAsStreamAsync());
        }

        public static string[] SupportFile =
        {
            "Windows Media Metafiles (.asx, .wax, .wvx, .wmx, wpl)",
            "Windows Media formats (.asf, .wma, .wmv, .wm)",
            "Microsoft Digital Video Recording (.dvr-ms)",
            "Windows Media Download Package (.wmd)",
            "Audio Visual Interleave (.avi)",
            "Moving Pictures Experts Group (.mpg, .mpeg, .m1v, .mp2, .mp3, .mpa, .mpe, .m3u)",
            "Musical Instrument Digital Interface (.mid, .midi, .rmi)",
            "Audio Interchange File Format (.aif, .aifc, .aiff)",
            "Sun Microsystems and NeXT (.au, .snd)",
            "Audio for Windows (.wav)",
            "CD Audio Track (.cda)",
            "Indeo Video Technology (.ivf)",
            "Windows Media Player Skins (.wmz, .wms)",
            "QuickTime Movie file (.mov)",
            "MP4 Audio file (.m4a)",
            "MP4 Video file (.mp4, .m4v, .mp4v, .3g2, .3gp2, .3gp, .3gpp)",
            "Windows audio file (.aac, .adt, .adts)",
            "MPEG-2 TS Video file (.m2ts)",
            "Free Lossless Audio Codec (.flac)"
        };

        public static List<string> GetAllSupportFile()
        {
            List<string> result = new List<string>();
            foreach (string ext in SupportFile)
            {
                var temp1 = ext.Split(new char[] { '(', ')' });
                var temp2 = temp1[temp1.Length - 2].Split(',');
                foreach (var t in temp2)
                    result.Add(t.Trim());
            }
            return result;
        }

        public static Image LoadImageFromByteArray(byte[] arr)
        {
            MemoryStream ms = new MemoryStream(arr);
            return Image.FromStream(ms);
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            Random random = new Random();
            int n = list.Count;

            for (int i = list.Count - 1; i > 1; i--)
            {
                int rnd = random.Next(i + 1);

                T value = list[rnd];
                list[rnd] = list[i];
                list[i] = value;
            }
        }

        public static void HideScrollBar(FlowLayoutPanel panel, bool h = true, bool v = true)
        {
            // need to disable AutoScroll, otherwise disabling the horizontal scrollbar doesn't work
            panel.AutoScroll = false;

            if (h)
            {
                // disable horizontal scrollbar
                panel.HorizontalScroll.Enabled = false;
                panel.HorizontalScroll.Maximum = 0;
            }
            if (v)
            {
                panel.VerticalScroll.Enabled = false;
                panel.VerticalScroll.Maximum = 0;
            }

            // restore AutoScroll
            panel.AutoScroll = true;
        }

        public static async Task<Image> LoadImagefromURL(string url)
        {
            var request = WebRequest.Create(url);
            var response = await request.GetResponseAsync();
            var stream = response.GetResponseStream();
            return Image.FromStream(stream);
        }
    }

}
