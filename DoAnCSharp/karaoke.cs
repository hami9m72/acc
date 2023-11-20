using DoAnCSharp.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace DoAnCSharp
{
    public partial class karaoke : Form
    {
        Lyric lyric;
        int t = 0;
        string link;



        public karaoke()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string songID = comboBox1.SelectedItem.ToString().Split('-')[1].Trim();
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, $"https://dat-zing-mp3-api.herokuapp.com/song/lyric/{songID}");
            HttpResponseMessage response = await httpClient.SendAsync(requestMessage);
            lyric = JsonConvert.DeserializeObject<Lyric>(await response.Content.ReadAsStringAsync());
            label3.Text = "0";
            var words = lyric.sentences[lyric.sentences.Count - 1].words;
            label4.Text = words[words.Count - 1].endTime.ToString();
            hopeTrackBar1.MaxValue = words[words.Count - 1].endTime;
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, $"https://dat-zing-mp3-api.herokuapp.com/song/stream/{songID}");
            response = await httpClient.SendAsync(req);
            link = JsonConvert.DeserializeObject<Streaming>(await response.Content.ReadAsStringAsync())._128;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string txt = lyric.sentences[idx1].fullSentence() + "\n" + lyric.sentences[idx1 + 1].fullSentence();
            //Draw(panel1, panel1.CreateGraphics(), txt, -1, Color.Blue, Color.Black);
            axWindowsMediaPlayer1.URL = link;
            startTime = lyric.sentences[idx].words[0].startTime;
            endTime = lyric.sentences[idx].words.Last().endTime;

            l1 = lyric.sentences[0].fullSentence();
            l2 = lyric.sentences[1].fullSentence();
            panelL1.Invalidate();
            panelL2.Invalidate();
        }

        private int startTime;
        private int endTime;



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (idx >= lyric.sentences.Count)
            {
                timer1.Stop();
                return;
            }
            if (t >= startTime && t < endTime)
            {
                if (idx % 2 == 0)
                {
                    if (idx >= lyric.sentences.Count)
                    {
                        timer1.Stop();
                        return;
                    }
                    l2 = lyric.sentences[idx + 1].fullSentence();
                    idx2 = -1;
                    panelL2.Invalidate();
                    if (t >= lyric.sentences[idx].words[idx1].endTime)
                        idx1++;
                    panelL1.Invalidate();
                }
                else
                {
                    if (idx >= lyric.sentences.Count)
                    {
                        timer1.Stop();
                        return;
                    }
                    l1 = lyric.sentences[idx + 1].fullSentence();
                    panelL1.Invalidate();
                    idx1 = -1;
                    if (t >= lyric.sentences[idx].words[idx2].endTime)
                        idx2++;
                    panelL2.Invalidate();

                }
            }
            if (t >= endTime)
            {
                idx++;
                if (idx % 2 == 0) idx1 = 0;
                else idx2 = 0;
                startTime = lyric.sentences[idx].words[0].startTime;
                endTime = lyric.sentences[idx].words.Last().endTime;
            }
            t += timer1.Interval + 15;
        }




        bool start = true;
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (start && axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                t = 0;
                timer1.Start();
                start = false;
                idx1 = 0;
                idx2 = 0;
            }
        }



        string l1 = "Hello";
        string l2 = "World";
        int idx = 0;
        int idx1 = -1;
        int idx2 = -1;
        private void panelL1_Paint(object sender, PaintEventArgs e)
        {
            if (l1 != "")
            {
                Graphics g = e.Graphics;
                TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter |
                                    TextFormatFlags.NoPadding | TextFormatFlags.NoClipping;

                using (StringFormat format = new StringFormat())
                {
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Far;

                    MatchCollection mc = Regex.Matches(l1, @"[^\s]+");
                    CharacterRange[] ranges = mc.Cast<Match>().Select(m => new CharacterRange(m.Index, m.Length)).ToArray();
                    format.SetMeasurableCharacterRanges(ranges);

                    using (Font font = new Font("Times New Roman", 40, FontStyle.Regular, GraphicsUnit.Point))
                    {
                        Region[] regions = g.MeasureCharacterRanges(l1, font, panelL1.ClientRectangle, format);

                        for (int i = 0; i < ranges.Length; i++)
                        {
                            Rectangle WordBounds = Rectangle.Round(regions[i].GetBounds(g));
                            string word = l1.Substring(ranges[i].First, ranges[i].Length);
                            Color c = i <= idx1 ? Color.Blue : Color.Black;
                            TextRenderer.DrawText(g, word, font, WordBounds, c, flags);
                        }
                    }
                }
            }
        }

        private void panelL2_Paint(object sender, PaintEventArgs e)
        {
            if (l2 != "")
            {
                Graphics g = e.Graphics;
                TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.Top |
                                    TextFormatFlags.NoPadding | TextFormatFlags.NoClipping;

                using (StringFormat format = new StringFormat())
                {
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Near;

                    MatchCollection mc = Regex.Matches(l2, @"[^\s]+");
                    CharacterRange[] ranges = mc.Cast<Match>().Select(m => new CharacterRange(m.Index, m.Length)).ToArray();
                    format.SetMeasurableCharacterRanges(ranges);

                    using (Font font = new Font("Times New Roman", 40, FontStyle.Regular, GraphicsUnit.Point))
                    {
                        Region[] regions = g.MeasureCharacterRanges(l2, font, panelL1.ClientRectangle, format);

                        for (int i = 0; i < ranges.Length; i++)
                        {
                            Rectangle WordBounds = Rectangle.Round(regions[i].GetBounds(g));
                            string word = l2.Substring(ranges[i].First, ranges[i].Length);
                            Color c = i <= idx2 ? Color.Blue : Color.Black;
                            TextRenderer.DrawText(g, word, font, WordBounds, c, flags);
                        }
                    }
                }
            }
        }
    }
}
