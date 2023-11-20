using DoAnCSharp.GoogleDriveAPI;
using DoAnCSharp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var files = DriveHelper.GetFilesInFloder(textBox1.Text);
            // "https://drive.google.com/uc?id=14H59EJconqc17YUreMOFFkr5oj93sAsn&export=download"
            string accessToken = DriveHelper.GetAccessToken();
            foreach (var file in files)
                comboBox1.Items.Add(file.Id+","+file.Size.ToString()+","+ file.Name);
            
        }

        private void StreamMp3(object fileID)
        {

            var url = $"https://www.googleapis.com/drive/v3/files/{fileID}?alt=media";
            var webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.PreAuthenticate = true;
            webRequest.Headers.Add("Authorization", "Bearer " + DriveHelper.GetAccessToken());
            HttpWebResponse resp;
            try
            {
                resp = (HttpWebResponse)webRequest.GetResponse();
            }
            catch (WebException e)
            {
                if (e.Status != WebExceptionStatus.RequestCanceled)
                {
                    Console.WriteLine(e.Message);
                }
                return;
            }
        }

        SimpleServer2 simpleServer;
        private void button2_Click(object sender, EventArgs e)
        {
            if (simpleServer == null)
                simpleServer = new SimpleServer2();
            simpleServer.CreateServer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (simpleServer == null)
            //    return;
            //simpleServer.StopServer();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var id = comboBox1.SelectedItem.ToString().Split(',')[0];
            var size = comboBox1.SelectedItem.ToString().Split(',')[1];
            mPlayer.URL = $"http://localhost:80/music/{id}/{size}";

           // DriveHelper.DownloadFile(id,long.Parse(size));
            
        }
    }
}
