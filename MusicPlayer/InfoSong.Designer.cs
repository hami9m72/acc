namespace MusicPlayer
{
    partial class InfoSong
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbComment = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbName.Location = new System.Drawing.Point(33, 24);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(76, 24);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "lbName";
            this.lbName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbArtist.Location = new System.Drawing.Point(34, 67);
            this.lbArtist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(38, 13);
            this.lbArtist.TabIndex = 1;
            this.lbArtist.Text = "lbArtist";
            this.lbArtist.Click += new System.EventHandler(this.lbArtist_Click);
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCountry.Location = new System.Drawing.Point(34, 89);
            this.lbCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(51, 13);
            this.lbCountry.TabIndex = 2;
            this.lbCountry.Text = "lbCountry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(33, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bình luận";
            // 
            // txbComment
            // 
            this.txbComment.Location = new System.Drawing.Point(37, 203);
            this.txbComment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbComment.Name = "txbComment";
            this.txbComment.Size = new System.Drawing.Size(395, 20);
            this.txbComment.TabIndex = 6;
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn1.Location = new System.Drawing.Point(37, 123);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(92, 29);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "Download";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // InfoSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txbComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbArtist);
            this.Controls.Add(this.lbName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InfoSong";
            this.Size = new System.Drawing.Size(455, 331);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbComment;
        private System.Windows.Forms.Button btn1;
    }
}
