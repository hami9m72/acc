using DoAnCSharp.Model;
using DoAnCSharp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSharp
{
    public partial class Main : Form
    {
        private int borderSize = 2;
        private Size formSize;

        private static Main instance;
        public static Main Instance { get => instance; }
        public AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        public MediaCtl mediaView;

        public Main()
        {
            InitializeComponent();
            instance = this;
            //CollapseMenu();
            //this.Padding = new Padding(borderSize);//Border size

            //var homeView = new HomeView();
            //panelContainer.Controls.Add(homeView);
            //homeView.Dock = DockStyle.Fill;

            //mediaView = new MediaCtl();
            //panelContainer.Controls.Add(mediaView);
            //mediaView.Dock = DockStyle.Fill;
            //MediaPlayer = mediaView.MPlayer;
            //mediaView.Visible = false;
            //MediaPlayer.PlayStateChange += MediaPlayer_PlayStateChange;

        }

        private void MediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                btnPlay.Image = Properties.Resources.pause;
                trackBar.MaxValue = (int)MediaPlayer.Ctlcontrols.currentItem.duration;
                lbMaxTime.Text = MediaPlayer.Ctlcontrols.currentItem.durationString;
                timer1.Start();
            }
            else if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                btnPlay.Image = Properties.Resources.play;
                timer1.Stop();
            }
            else if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                trackBar.Value = 0;
                lbMinTime.Text = "00:00";
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
        //Private methods
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 8);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        public void SetMedia(Song song)
        {
            MediaPlayer.URL = song.streaming._128;
            MediaPlayer.Ctlcontrols.play();
            if (song.thumbnailM != null)
                pbSong.LoadAsync(song.thumbnailM);
            else
                pbSong.Image = song.thumbnailMImg;
            lbSongName.Text = song.title;
            lbSongArtist.Text = song.artistsNames;

        }

        private bool canCollapse = false;
        private void CollapseMenu()
        {
            if (this.Width < 1075 && !canCollapse) //Collapse menu
            {
                panelMenu.Width = 64;
                //pictureBox1.Visible = false;
                ////btnMenu.Dock = DockStyle.Top;
                pbLogo.Location = new Point(6, 6);

                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
                //panelSongInfo.Visible = false;
                canCollapse = true;
            }

            if (this.Width > 1075 && canCollapse)
            { //Expand menu
                panelMenu.Width = 227;
                pbLogo.Location = new Point(21, 23);

                //btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }

                //panelSongInfo.Visible = true;
                canCollapse = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            CollapseMenu();
            AdjustForm();
            panelContainer.Invalidate();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            formSize = Size;
            this.WindowState = FormWindowState.Minimized;
        }

        private void ClearAllMenuCheck()
        {
            foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                menuButton.BackColor = Color.FromArgb(25, 26, 31);
        }

        private void ActiveMenu(Button btn)
        {
            btn.BackColor = Color.FromArgb(255, 128, 0);
        }



        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                MediaPlayer.Ctlcontrols.pause();
            }
            else if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                MediaPlayer.Ctlcontrols.play();
            }
        }

        private bool barChange = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                lbMinTime.Text = MediaPlayer.Ctlcontrols.currentPositionString;
                if (barChange)
                    trackBar.Value = (int)MediaPlayer.Ctlcontrols.currentPosition;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            ClearAllMenuCheck();
            ActiveMenu(sender as Button);
            MyMusicView view;
            if (panelContainer.Controls["MyMusicView"] == null)
            {
                view = new MyMusicView();
                panelContainer.Controls.Add(view);
            }
            else
                view = panelContainer.Controls["MyMusicView"] as MyMusicView;
            view.Dock = DockStyle.Fill;
            view.BringToFront();
        }

        private void trackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (MediaPlayer.currentMedia != null)
            {
                double cur = MediaPlayer.Ctlcontrols.currentItem.duration * e.X / (trackBar.Width - 15);
                MediaPlayer.Ctlcontrols.currentPosition = cur;
                lbMinTime.Text = MediaPlayer.Ctlcontrols.currentPositionString;
                barChange = true;
            }
        }

        private void trackBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (MediaPlayer.currentMedia != null && e.Button == MouseButtons.Left)
            {
                barChange = false;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ClearAllMenuCheck();
            ActiveMenu(sender as Button);

            HomeView view;
            if (panelContainer.Controls["HomeView"] == null)
            {
                view = new HomeView();
                panelContainer.Controls.Add(view);
            }
            else
                view = panelContainer.Controls["HomeView"] as HomeView;
            view.Dock = DockStyle.Fill;
            view.BringToFront();
        }

        private void btnCate_Click(object sender, EventArgs e)
        {
            ClearAllMenuCheck();
            ActiveMenu(sender as Button);
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            ClearAllMenuCheck();
            ActiveMenu(sender as Button);
        }

        private void btnBXH_Click(object sender, EventArgs e)
        {
            ClearAllMenuCheck();
            ActiveMenu(sender as Button);
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            ClearAllMenuCheck();
            ActiveMenu(sender as Button);
        }

        private void trackbarVolume_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.X);
        }

        private void trackbarVolume_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MediaPlayer.settings.volume = trackbarVolume.Value;
            }
        }

        private void trackbarVolume_Click(object sender, EventArgs e)
        {
            Console.WriteLine((e as MouseEventArgs).X);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            mediaView.Visible = true;
            mediaView.BringToFront();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            Control control = sender as Control;
            const string txt = "C# Helper! Draw some text with each word in a random color.";

            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter |
                                    TextFormatFlags.NoPadding | TextFormatFlags.NoClipping;

            using (StringFormat format = new StringFormat())
            {
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                MatchCollection mc = Regex.Matches(txt, @"[^\s]+");
                CharacterRange[] ranges = mc.Cast<Match>().Select(m => new CharacterRange(m.Index, m.Length)).ToArray();
                format.SetMeasurableCharacterRanges(ranges);

                using (Font font = new Font("Times New Roman", 40, FontStyle.Regular, GraphicsUnit.Point))
                {
                    Region[] regions = e.Graphics.MeasureCharacterRanges(txt, font, control.ClientRectangle, format);

                    for (int i = 0; i < ranges.Length; i++)
                    {
                        Rectangle WordBounds = Rectangle.Round(regions[i].GetBounds(e.Graphics));
                        string word = txt.Substring(ranges[i].First, ranges[i].Length);

                        TextRenderer.DrawText(e.Graphics, word, font, WordBounds, Color.Blue, flags);
                    }
                }
            }
        }
    }
}
