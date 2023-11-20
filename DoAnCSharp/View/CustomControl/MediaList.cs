using DoAnCSharp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSharp.View.CustomControl
{
    public partial class MediaList : UserControl
    {
        private bool isClicked = false;
        private Song song;
        public MediaList()
        {
            InitializeComponent();
        }

        public MediaList(Image img, Song s)
        {
            InitializeComponent();
            pbImg.BackgroundImage = img;
            song = s;
            lbName.Text = song.title;
            lbArtist.Text = song.artistsNames;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Main.Instance.SetMedia(song);
        }
    }
}
