
using MusicPlayer.DataRepo;
using MusicPlayer.Model;
using MusicPlayer.Service;
using Newtonsoft.Json.Linq;
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
    public partial class SearchView : UserControl
    {
        int page = 1;
        int total = 0;
        int counter = 0;

        Playlist search;

        public SearchView()
        {
            InitializeComponent();
            search = new Playlist("search");
        }



        private async void btnSearch_Click(object sender, EventArgs e)
        {
            panelSearch.Controls.Clear();
            string keyword = txtSearch.Texts.Trim();
            if (keyword != "")
            {
                var searchResult = Data.GetAllSong(keyword);
                if (searchResult != null && searchResult.Count > 0)
                {
                    int i = 0;
                    foreach (var song in searchResult)
                    {
                        var view = new MediaSearch(song, i++, search);
                        view.Dock = DockStyle.Top;
                        panelSearch.Controls.Add(view);
                        search.files.Add(song);
                    }
                    search.files.Reverse();
                } else
                {
                    MessageBox.Show("Không tìm thấy kết quả", "Thông báo");
                }
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnSearch_Click(null, null);
            }
        }
    }
}
