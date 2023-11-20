using DoAnCSharp.Model;
using DoAnCSharp.Service;
using DoAnCSharp.View.CustomControl;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSharp.View
{
    public partial class HomeView : UserControl
    {
        private HomeService homeService;
        private Task<List<Song>> bannerSongs;

        public HomeView()
        {
            InitializeComponent();
            homeService = new HomeService();
        }

        private async void LoadUI()
        {
            List<string> bannerLink = await homeService.BanerPicture();
            pb1.LoadAsync(bannerLink[0]);
            pb2.LoadAsync(bannerLink[1]);
            pb3.LoadAsync(bannerLink[2]);
            bannerSongs= homeService.BanerSongs();
        }

        private void HomeView_Load(object sender, EventArgs e)
        {
            LoadUI();
        }

        private async void pb1_Click(object sender, EventArgs e)
        {
            int idx = int.Parse((sender as PictureBox).Tag.ToString());
            Main.Instance.SetMedia((await bannerSongs)[idx]);
        }

       
    }
}
