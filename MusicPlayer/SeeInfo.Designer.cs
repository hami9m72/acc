namespace MusicPlayer
{
    partial class SeeInfo
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
            this.txbComment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btn1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbComment
            // 
            this.txbComment.Location = new System.Drawing.Point(27, 258);
            this.txbComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbComment.Name = "txbComment";
            this.txbComment.Size = new System.Drawing.Size(525, 22);
            this.txbComment.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(21, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bình luận";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCountry.Location = new System.Drawing.Point(23, 118);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(56, 16);
            this.lbCountry.TabIndex = 9;
            this.lbCountry.Text = "lbAlbum";
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbArtist.Location = new System.Drawing.Point(23, 91);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(47, 16);
            this.lbArtist.TabIndex = 8;
            this.lbArtist.Text = "lbArtist";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbName.Location = new System.Drawing.Point(21, 38);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(98, 29);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "lbName";
            // 
            // folderBrowser
            // 
            this.folderBrowser.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(27, 162);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(123, 36);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "Download";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(332, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 207);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // SeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txbComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbArtist);
            this.Controls.Add(this.lbName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SeeInfo";
            this.Text = "SeeInfo";
            this.Load += new System.EventHandler(this.SeeInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}