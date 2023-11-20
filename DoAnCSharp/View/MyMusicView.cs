using DoAnCSharp.Model;
using DoAnCSharp.Utils;
using DoAnCSharp.View.CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSharp.View
{
    public partial class MyMusicView : UserControl
    {
        public MyMusicView()
        {
            InitializeComponent();
            //for (int i = 0; i < 2; i++)
            //{
            //    var view = new MediaList();
            //    view.Dock = DockStyle.Top;
            //    if (i % 2 == 0)
            //        view.BackColor = Color.Red;
            //    else
            //        view.BackColor = Color.Blue;
            //    view.Dock = DockStyle.Top;

            //    panelList.Controls.Add(view);
            //}
            poisonPanel1.MouseWheel += PoisonPanel1_MouseWheel;
        }

        private void PoisonPanel1_MouseWheel(object sender, MouseEventArgs e)
        {
            poisonScrollBar1.Maximum = poisonPanel1.VerticalScroll.Maximum;
            poisonScrollBar1.SmallChange = poisonPanel1.VerticalScroll.SmallChange;
            poisonScrollBar1.LargeChange = poisonPanel1.VerticalScroll.LargeChange;
            poisonScrollBar1.Value = poisonPanel1.VerticalScroll.Value;
        }



        private void poisonPanel1_VerticalScrolled(object sender, ScrollEventArgs e)
        {
            //Console.WriteLine("1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var extensions = Helper.GetAllSupportFile();
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath, "*.*", SearchOption.AllDirectories)
                                    .Where(f => extensions.Contains(Path.GetExtension(f).ToLower())).ToArray();

                    for (int i = 0; i < files.Length; i++)
                    {
                        var tfile = TagLib.File.Create(files[i]);
                        Image pic;
                        if (tfile is TagLib.Mpeg.AudioFile)
                        {
                            if (tfile.Tag.Pictures.Length > 0 && tfile.Tag.Pictures != null)
                            {
                                MemoryStream ms = new MemoryStream(tfile.Tag.Pictures[0].Data.Data);
                                pic = Image.FromStream(ms);
                            }
                            else
                                pic = Properties.Resources.icons8_music_48px;
                        }
                        else
                            pic = Properties.Resources.icons8_video_100px;

                        string songName = "";
                        if (tfile.Tag.Title != null)
                            songName = tfile.Tag.Title;
                        else
                            songName = Path.GetFileNameWithoutExtension(files[i]);

                        string artistName = "";
                        if (tfile.Tag.JoinedPerformers != null)
                            artistName = tfile.Tag.JoinedPerformers;

                        Song song = new Song();
                        song.streaming = new Streaming();
                        song.streaming._128 = files[i];
                        song.thumbnailMImg = pic;
                        song.title = songName;
                        song.artistsNames = artistName;

                        var view = new MediaList(pic, song);
                        view.Dock = DockStyle.Top;
                        poisonPanel1.Controls.Add(view);
                    }

                }

            }
        }
    }
}
