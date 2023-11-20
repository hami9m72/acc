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
    public partial class CreatePlaylist : Form
    {
        public string result = "";
        public CreatePlaylist()
        {
            InitializeComponent();
            CenterToParent();
        }

        public CreatePlaylist(string title)
        {
            InitializeComponent();
            this.Text = title;
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
