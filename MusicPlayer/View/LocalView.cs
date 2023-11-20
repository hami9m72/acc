
using MusicPlayer.DataRepo;
using MusicPlayer.Model;
using MusicPlayer.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using TagLib.Id3v2;

namespace MusicPlayer.View
{
    public partial class LocalView : UserControl
    {
        Playlist playlist1;
        Playlist playlist2;
        Playlist playlist3;

        public LocalView()
        {
            InitializeComponent();
            playlist1 = new Playlist("local");
            playlist2 = new Playlist("downloaded");
            //playlist3 = new Playlist("karaoke");
            comboBox1.SelectedIndex = 0;
        }
        public void LocalView_Load(object sender, EventArgs e)
        {
            LoadTabLocal();
            LoadTabDownload();
            //LoadTabKaraoke();
        }

        public void LoadTabLocal()
        {
            panelSong.Controls.Clear();
            if (Data.localPath.Count > 0)
            {
                playlist1.files.Clear();
                if (Data.localPath.Count > 0)
                    LoadLocalSong(Data.localPath, panelSong, playlist1);
            }
            else
            {
                playlist1.files.Clear();
            }
        }

        public void LoadTabDownload()
        {
            panelDownload.Controls.Clear();
            if (Data.downloadPath != "")
            {
                playlist2.files.Clear();
                if (Data.downloadPath != "")
                    LoadLocalSong(new List<string> { Data.downloadPath }, panelDownload, playlist2);
            }
            else
            {
                playlist2.files.Clear();
            }
        }

        private void LoadLocalSong(List<string> paths, Panel panel, Playlist p)
        {
            p.files = Data.LoadLocalSong(paths, p.name).files;
            int i = 0;
            foreach (var song in p.files)
            {
                var view = new MediaList1(song, i++, p);
                view.parent = this;
                view.Dock = DockStyle.Top;
                panel.Controls.Add(view);
            }
        }

        public Panel GetPanelSong()
        {
            return panelSong;
        }

        private void btnShuffer_Click(object sender, EventArgs e)
        {
            MainForm.Instance.isPlaying = playlist1;
            MainForm.Instance.ShufferPlaying();
            MainForm.Instance.counter = 0;
            MainForm.Instance.PlayMedia();
            MainForm.Instance.LoadViewPlaying();
        }

        private void panelSong_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
