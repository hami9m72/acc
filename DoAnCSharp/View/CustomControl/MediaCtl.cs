using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSharp.View
{
    public partial class MediaCtl : UserControl
    {
        public AxWMPLib.AxWindowsMediaPlayer MPlayer { get => mPlayer; }
        public MediaCtl()
        {
            InitializeComponent();
            //panel2.Visible = false;
        }




    }
}
