
namespace DoAnCSharp
{
    partial class karaoke
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(karaoke));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.hopeTrackBar1 = new ReaLTaiizor.Controls.HopeTrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelL1 = new System.Windows.Forms.Panel();
            this.panelL2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(678, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(678, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "play";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hopeTrackBar1
            // 
            this.hopeTrackBar1.AlwaysValueVisible = false;
            this.hopeTrackBar1.BallonArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTrackBar1.BallonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTrackBar1.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(220)))), ((int)(((byte)(223)))));
            this.hopeTrackBar1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.hopeTrackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeTrackBar1.FillBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTrackBar1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.hopeTrackBar1.ForeColor = System.Drawing.Color.White;
            this.hopeTrackBar1.HeadBorderColor = System.Drawing.Color.DodgerBlue;
            this.hopeTrackBar1.HeadColor = System.Drawing.Color.Black;
            this.hopeTrackBar1.Location = new System.Drawing.Point(719, 381);
            this.hopeTrackBar1.MaxValue = 1000;
            this.hopeTrackBar1.MinValue = 0;
            this.hopeTrackBar1.Name = "hopeTrackBar1";
            this.hopeTrackBar1.ShowValue = false;
            this.hopeTrackBar1.Size = new System.Drawing.Size(354, 16);
            this.hopeTrackBar1.TabIndex = 6;
            this.hopeTrackBar1.Text = "hopeTrackBar1";
            this.hopeTrackBar1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTrackBar1.UnknownColor = System.Drawing.Color.White;
            this.hopeTrackBar1.Value = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(688, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1019, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(694, 465);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(251, 102);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // timer1
            // 
            this.timer1.Interval = 110;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(706, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 46);
            this.panel2.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Phi hành gia - ZU9CE99E",
            "Thay lòng - ZU7C8FDU"});
            this.comboBox1.Location = new System.Drawing.Point(678, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Phi hành gia - ZU9CE99E";
            // 
            // panelL1
            // 
            this.panelL1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panelL1.Location = new System.Drawing.Point(2, 9);
            this.panelL1.Name = "panelL1";
            this.panelL1.Size = new System.Drawing.Size(563, 264);
            this.panelL1.TabIndex = 13;
            this.panelL1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelL1_Paint);
            // 
            // panelL2
            // 
            this.panelL2.BackColor = System.Drawing.Color.LightSalmon;
            this.panelL2.Location = new System.Drawing.Point(2, 279);
            this.panelL2.Name = "panelL2";
            this.panelL2.Size = new System.Drawing.Size(563, 312);
            this.panelL2.TabIndex = 14;
            this.panelL2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelL2_Paint);
            // 
            // karaoke
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1128, 603);
            this.Controls.Add(this.panelL2);
            this.Controls.Add(this.panelL1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hopeTrackBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "karaoke";
            this.Text = "karaoke";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ReaLTaiizor.Controls.HopeTrackBar hopeTrackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelL1;
        private System.Windows.Forms.Panel panelL2;
    }
}
