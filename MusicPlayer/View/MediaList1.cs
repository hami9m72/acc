
using MusicPlayer.DataRepo;
using MusicPlayer.Model;
using MusicPlayer.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MusicPlayer.View
{

    public partial class MediaList1 : UserControl
    {
        public Song song;
        public Playlist local;
        public int idx;
        public LocalView parent;
        public bool IsLike = false;
        
        public MediaList1()
        {
            InitializeComponent();
        }

        public MediaList1(Song s, int idx, Playlist local)
        {
            InitializeComponent();
            this.song = s;
            this.local = local;
            this.idx = idx;

        }
        private void MediaList1_Load(object sender, EventArgs e)
        {
            lbName.Text = song.GetTitle();
            lbArtist.Text = song.GetArtistNameJoined();
            lbAlbum.Text = song.GetAlbumName();
           
            if (song.GetThumbImg() is Image)
            {
                pbImg.BackgroundImage = song.GetThumbImg() as Image;
                pbImg.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (song.GetTitle() == "" || song.GetTitle() == null)
            {
                lbName.Text = Path.GetFileNameWithoutExtension(song.GetSrc());
            }

            //if (song.isLiked)
            //    pbTim.BackgroundImage = Properties.Resources.icons8_heart_24px;
            //else
            //    pbTim.BackgroundImage = Properties.Resources.icons8_love_24px;
        }
        private void pbImg_Click(object sender, EventArgs e)
        {
            if (MainForm.Instance.isPlaying != null)
            {
                int old = MainForm.Instance.playingOrder[MainForm.Instance.counter];
                var ctls = parent.GetPanelSong().Controls;
                (ctls[ctls.Count - 1 - old] as MediaList1).DeActiveSongUI();
            }

            MainForm.Instance.isPlaying = local;
            MainForm.Instance.NormalPlaying();
            MainForm.Instance.counter = idx;
            MainForm.Instance.PlayMedia();
            MainForm.Instance.LoadViewPlaying();
            ActiveSongUI();
            Data.AddSongToPlayList(Data.MyPlaylist.Count - Data.MyPlaylist.Count + 1, song);
        }

        public void ActiveSongUI()
        {
            //ChangeColorLabel(Color.FromArgb(1, 241, 250));
        }

        public void DeActiveSongUI()
        {
            foreach (Control c in tableLayoutPanel1.Controls)
                c.BackColor = Color.FromArgb(37, 38, 44);
            ChangeColorLabel(Color.White);
        }

        private void ChangeColorLabel(Color color)
        {
            lbName.ForeColor = color;
            lbArtist.ForeColor = color;
            lbAlbum.ForeColor = color;
        }

        private void pbImg_MouseEnter(object sender, EventArgs e)
        {
            pbImg.Image = Properties.Resources.icons8_play_32px;
        }

        private void pbImg_MouseLeave(object sender, EventArgs e)
        {
            pbImg.Image = null;
        }

        //public void UpdateLikedUI()
        //{
        //    if (song.isLiked)
        //    {
        //        MainForm.Instance.favorite.files.Add(song);
        //        pbTim.BackgroundImage = Properties.Resources.icons8_heart_24px;
        //    }
        //    else
        //    {
        //        MainForm.Instance.favorite.files.Remove(song);
        //        pbTim.BackgroundImage = Properties.Resources.icons8_love_24px;
        //    }
        //}

        //private void pbTim_Click(object sender, EventArgs e)
        //{
        //    song.isLiked = !song.isLiked;
        //    UpdateLikedUI();
        //    if (MainForm.Instance.playingOrder != null)
        //    {
        //        MainForm.Instance.UpdateLikedSong(MainForm.Instance.playingOrder[idx]);
        //    }
        //    if (FavoriteView.Instance != null)
        //    {
        //        FavoriteView.Instance.ReloadView();
        //    }
        //}

        private void btnMore_Click(object sender, EventArgs e)
        {
            var tmp = menu.Items[0];
            menu.Items.Clear();
            menu.Items.Add(tmp);
            foreach (var playlist in Data.MyPlaylist)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(playlist.name);
                menu.Items.Add(item);
                item.Click += Item_Click;
            }
            menu.Show(btnMore, 0, btnMore.Height);

        }

        private void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                int index = (item.Owner).Items.IndexOf(item);
                if (Data.MyPlaylist[index - 1].files.Contains(song))
                {
                    DialogResult dialogResult = MessageBox.Show($"Bài hát này đã có trong playlist. Bạn có muốn thêm nó chứ ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Data.AddSongToPlayList(index - 1, song);
                    }
                }
                else
                    Data.AddSongToPlayList(index - 1, song);


            }

        }

        private void btnKaraoke_Click(object sender, EventArgs e)
        {
          
        }

        private void helloToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            var dialog = new CreatePlaylist();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                Data.CreatePlayList(dialog.result);
                Data.AddSongToPlayList(Data.MyPlaylist.Count - 1, song);
                var view = MainForm.Instance.GetContainerView("PlaylistView");
                if (view != null)
                {
                    (view as PlaylistView).LoadPlayList();
                }
            }
        }

        private void btnSeeInfo_Click(object sender, EventArgs e)
        {
            SeeInfo infoSong = new SeeInfo(song);
            infoSong.Show();
            
        }

        private void btnHeart2_Click(object sender, EventArgs e)
        {
            //Data.CreatePlayList("Like");
            //Data.CreatePlayList("Recent");
            btnHeart2.Visible = false;
            Data.AddSongToPlayList(Data.MyPlaylist.Count - Data.MyPlaylist.Count, song);
        }

        private void btnHeart1_Click(object sender, EventArgs e)
        {
            btnHeart2.Visible = true;
            Data.DeleteSongToPlayList(Data.MyPlaylist.Count - Data.MyPlaylist.Count, song);
        }

        private void lbArtist_Click(object sender, EventArgs e)
        {

        }

        private void lbAlbum_Click(object sender, EventArgs e)
        {

        }
    }
}
