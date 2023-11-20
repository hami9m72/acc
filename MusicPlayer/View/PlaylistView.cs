using MusicPlayer.DataRepo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.View
{
    public partial class PlaylistView : UserControl
    {
        int iPSelect = -1;
        public PlaylistView()
        {
            InitializeComponent();
            listView1.LargeImageList = imageList1;
            lbTitle.Text = "";
            LoadPlayList();
        }

        public void LoadPlayList()
        {
            foreach (var playlist in Data.MyPlaylist)
            {
                listView1.Items.Add(playlist.name, 0);
                listView1.View = System.Windows.Forms.View.LargeIcon;
            }
        }

        //private void btnAction_Click(object sender, EventArgs e)
        //{
        //    menu.Show(btnAction, 0, btnAction.Height);
        //}

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                iPSelect = e.ItemIndex;
                panelData.Controls.Clear();
                e.Item.ImageIndex = 1;
                var playlist = Data.MyPlaylist[e.ItemIndex];
                lbTitle.Text = playlist.name;
                btnMore.Visible = true;

                for (int i = playlist.files.Count - 1; i > -1; i--)
                {
                    var view = new MediaList2(playlist.files[i], i);
                    view.Dock = DockStyle.Top;
                    panelData.Controls.Add(view);
                    view.Box.CheckedChanged += Box_CheckedChanged;
                }
            }
            else
            {
                e.Item.ImageIndex = 0;
            }
        }


        int countBox = 0;
        private void Box_CheckedChanged(object sender, EventArgs e)
        {
            var box = sender as CheckBox;
            if (box.Checked)
            {
                btnDel.Visible = true;
                countBox++;
            }
            else
                countBox--;
            if (countBox < 1)
            {
                btnDel.Visible = false;
            }
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            menu.Show(btnMore, 0, btnMore.Height);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < panelData.Controls.Count; i++)
            {
                MediaList2 view = panelData.Controls[i] as MediaList2;
                if (view.Box.Checked)
                {
                    Data.MyPlaylist[iPSelect].files.Remove(view.song);
                    panelData.Controls.Remove(view);
                    i--;
                }
            }

        }

        private void menuDel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc muốn xóa playlist: {Data.MyPlaylist[iPSelect].name}", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Data.MyPlaylist.RemoveAt(iPSelect);
                MainForm.Instance.btnPlaylist_Click(null, null);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            var dialog = new CreatePlaylist("Đổi tên playlist");
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                Data.MyPlaylist[iPSelect].name = dialog.result;
                MainForm.Instance.btnPlaylist_Click(null, null);
            }
        }

        private void menuPlay_Click(object sender, EventArgs e)
        {
            MainForm.Instance.isPlaying = Data.MyPlaylist[iPSelect];
            MainForm.Instance.NormalPlaying();
            MainForm.Instance.counter = 0;
            MainForm.Instance.PlayMedia();
            MainForm.Instance.LoadViewPlaying();

            //MainForm.Instance.btnPlaylist_Click(null, null);

            var local = (MainForm.Instance.GetContainerView("LocalView") as LocalView).GetPanelSong();
            if (local != null)
            {
                var song = MainForm.Instance.isPlaying.files[MainForm.Instance.playingOrder[MainForm.Instance.counter]];
                foreach (MediaList1 item in local.Controls)
                {
                    if (item.song != song) item.DeActiveSongUI();
                    else item.ActiveSongUI();
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
