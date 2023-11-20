using MusicPlayer.DataRepo;
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

namespace MusicPlayer.View
{
    public partial class SettingView : UserControl
    {
        string basePath = Environment.SpecialFolder.MyMusic.ToString() + "/dplayer";

        public SettingView()
        {
            InitializeComponent();
            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            var f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                cbLocal.Items.Add(f.SelectedPath);
                cbLocal.SelectedIndex = cbLocal.Items.Count - 1;
                Data.localPath.Add(f.SelectedPath);
                var view = MainForm.Instance.GetContainerView("LocalView");
                if (view != null)
                    (view as LocalView).LocalView_Load(null, null);
                Data.SaveSetting();
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (cbLocal.Items.Count > 0)
            {
                Data.localPath.RemoveAt(cbLocal.SelectedIndex);
                cbLocal.Items.RemoveAt(cbLocal.SelectedIndex);
                var view = MainForm.Instance.GetContainerView("LocalView");
                if (view != null)
                    (view as LocalView).LoadTabLocal();
            }
        }

        private void SettingView_Load(object sender, EventArgs e)
        {
            cbLocal.Items.AddRange(Data.localPath.ToArray());
            txtDownload.Text = Data.downloadPath;
            if (cbLocal.Items.Count > 0)
                cbLocal.SelectedIndex = 0;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            var f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtDownload.Text = f.SelectedPath;
                Data.downloadPath = f.SelectedPath;
                Data.SaveSetting();
                var view = MainForm.Instance.GetContainerView("LocalView");
                if (view != null)
                    (view as LocalView).LoadTabDownload();
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDownload_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
