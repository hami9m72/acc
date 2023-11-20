
namespace MusicPlayer.View
{
    partial class MediaList1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbArtist = new System.Windows.Forms.Label();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSeeInfo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMore = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHeart2 = new System.Windows.Forms.Button();
            this.btnHeart1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbAlbum = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.menu = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 71);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel6.Controls.Add(this.lbArtist);
            this.panel6.Controls.Add(this.pbImg);
            this.panel6.Controls.Add(this.lbName);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(1, 3);
            this.panel6.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(413, 65);
            this.panel6.TabIndex = 5;
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtist.ForeColor = System.Drawing.Color.White;
            this.lbArtist.Location = new System.Drawing.Point(81, 38);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(55, 23);
            this.lbArtist.TabIndex = 2;
            this.lbArtist.Text = "label1";
            this.lbArtist.Click += new System.EventHandler(this.lbArtist_Click);
            // 
            // pbImg
            // 
            this.pbImg.BackgroundImage = global::MusicPlayer.Properties.Resources.music_96px;
            this.pbImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbImg.Location = new System.Drawing.Point(0, 0);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(74, 65);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 1;
            this.pbImg.TabStop = false;
            this.pbImg.Click += new System.EventHandler(this.pbImg_Click);
            this.pbImg.MouseEnter += new System.EventHandler(this.pbImg_MouseEnter);
            this.pbImg.MouseLeave += new System.EventHandler(this.pbImg_MouseLeave);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(80, 10);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(63, 28);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "label1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel5.Controls.Add(this.btnSeeInfo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(733, 3);
            this.panel5.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(45, 65);
            this.panel5.TabIndex = 4;
            // 
            // btnSeeInfo
            // 
            this.btnSeeInfo.AutoSize = true;
            this.btnSeeInfo.BackgroundImage = global::MusicPlayer.Properties.Resources.more_48px;
            this.btnSeeInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeeInfo.FlatAppearance.BorderSize = 0;
            this.btnSeeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeInfo.Location = new System.Drawing.Point(6, 10);
            this.btnSeeInfo.Name = "btnSeeInfo";
            this.btnSeeInfo.Size = new System.Drawing.Size(35, 39);
            this.btnSeeInfo.TabIndex = 6;
            this.btnSeeInfo.UseVisualStyleBackColor = true;
            this.btnSeeInfo.Click += new System.EventHandler(this.btnSeeInfo_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.btnMore);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(688, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(45, 65);
            this.panel4.TabIndex = 3;
            // 
            // btnMore
            // 
            this.btnMore.BackgroundImage = global::MusicPlayer.Properties.Resources.add_64px;
            this.btnMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMore.FlatAppearance.BorderSize = 0;
            this.btnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMore.Location = new System.Drawing.Point(5, 12);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(40, 38);
            this.btnMore.TabIndex = 0;
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.btnHeart2);
            this.panel3.Controls.Add(this.btnHeart1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(633, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(55, 65);
            this.panel3.TabIndex = 2;
            // 
            // btnHeart2
            // 
            this.btnHeart2.AutoSize = true;
            this.btnHeart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHeart2.BackgroundImage = global::MusicPlayer.Properties.Resources.Favorite_100px;
            this.btnHeart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeart2.FlatAppearance.BorderSize = 0;
            this.btnHeart2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeart2.Location = new System.Drawing.Point(6, 12);
            this.btnHeart2.Name = "btnHeart2";
            this.btnHeart2.Size = new System.Drawing.Size(41, 41);
            this.btnHeart2.TabIndex = 5;
            this.btnHeart2.UseVisualStyleBackColor = false;
            this.btnHeart2.Click += new System.EventHandler(this.btnHeart2_Click);
            // 
            // btnHeart1
            // 
            this.btnHeart1.BackgroundImage = global::MusicPlayer.Properties.Resources.music_heart_96px;
            this.btnHeart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeart1.FlatAppearance.BorderSize = 0;
            this.btnHeart1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeart1.Location = new System.Drawing.Point(6, 12);
            this.btnHeart1.Name = "btnHeart1";
            this.btnHeart1.Size = new System.Drawing.Size(40, 38);
            this.btnHeart1.TabIndex = 4;
            this.btnHeart1.UseVisualStyleBackColor = true;
            this.btnHeart1.Click += new System.EventHandler(this.btnHeart1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 65);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.lbAlbum);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(414, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 65);
            this.panel2.TabIndex = 1;
            // 
            // lbAlbum
            // 
            this.lbAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAlbum.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlbum.ForeColor = System.Drawing.Color.White;
            this.lbAlbum.Location = new System.Drawing.Point(-56, 18);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(275, 20);
            this.lbAlbum.TabIndex = 1;
            this.lbAlbum.Text = "album";
            this.lbAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAlbum.Click += new System.EventHandler(this.lbAlbum_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(778, 3);
            this.panel7.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 65);
            this.panel7.TabIndex = 6;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.menu.DropShadowEnabled = false;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.IsMainMenu = true;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloToolStripMenuItem});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu.MenuItemHeight = 25;
            this.menu.MenuItemTextColor = System.Drawing.Color.White;
            this.menu.Name = "menu";
            this.menu.PrimaryColor = System.Drawing.Color.Black;
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(189, 36);
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helloToolStripMenuItem.Image = global::MusicPlayer.Properties.Resources.icons8_add_24px_2;
            this.helloToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.helloToolStripMenuItem.Text = "Playlist mới";
            this.helloToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.helloToolStripMenuItem.Click += new System.EventHandler(this.helloToolStripMenuItem_Click_2);
            // 
            // MediaList1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MediaList1";
            this.Size = new System.Drawing.Size(788, 71);
            this.Load += new System.EventHandler(this.MediaList1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbAlbum;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnMore;
        private RJCodeAdvance.RJControls.RJDropdownMenu menu;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.Button btnHeart1;
        private System.Windows.Forms.Button btnHeart2;
        private System.Windows.Forms.Button btnSeeInfo;
    }
}
