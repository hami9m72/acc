using MusicPlayer.Model;
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
    public partial class FavoriteView : UserControl
    {
        private static FavoriteView instance;
        public static FavoriteView Instance { get => instance; }
        Playlist fav;
        public FavoriteView()
        {
            InitializeComponent();
            instance = this;
            fav = MainForm.Instance.favorite;
            MainForm.Instance.isPlaying = fav;
            MainForm.Instance.NormalPlaying();
            ReloadView();

        }

        public void ReloadView()
        {
            if (fav.files.Count > 0)
            {
                panelSong.Visible = true;
                panelSong.Controls.Clear();
                for (int i = fav.files.Count - 1; i > -1; i--)
                {
                    var view = new MediaList2(fav.files[i], i);
                    view.Dock = DockStyle.Top;
                    panelSong.Controls.Add(view);
                }
            }
            else
                panelSong.Visible = false;

        }


    }
}
