
namespace MusicPlayer.View
{
    partial class SettingView
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
            this.hopeTabPage1 = new ReaLTaiizor.Controls.HopeTabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDownload = new System.Windows.Forms.TextBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLocal = new System.Windows.Forms.ComboBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.hopeTabPage1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hopeTabPage1
            // 
            this.hopeTabPage1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.hopeTabPage1.Controls.Add(this.tabPage1);
            this.hopeTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hopeTabPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hopeTabPage1.ForeColorA = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hopeTabPage1.ForeColorB = System.Drawing.Color.Gray;
            this.hopeTabPage1.ForeColorC = System.Drawing.Color.White;
            this.hopeTabPage1.ItemSize = new System.Drawing.Size(120, 40);
            this.hopeTabPage1.Location = new System.Drawing.Point(0, 0);
            this.hopeTabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.hopeTabPage1.Name = "hopeTabPage1";
            this.hopeTabPage1.SelectedIndex = 0;
            this.hopeTabPage1.Size = new System.Drawing.Size(999, 606);
            this.hopeTabPage1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.hopeTabPage1.TabIndex = 0;
            this.hopeTabPage1.ThemeColorA = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.hopeTabPage1.ThemeColorB = System.Drawing.Color.Red;
            this.hopeTabPage1.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtDownload);
            this.tabPage1.Controls.Add(this.btn3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbLocal);
            this.tabPage1.Controls.Add(this.btn1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn2);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(999, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cài đặt";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(157, 298);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtDownload
            // 
            this.txtDownload.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownload.Location = new System.Drawing.Point(49, 253);
            this.txtDownload.Margin = new System.Windows.Forms.Padding(4);
            this.txtDownload.Name = "txtDownload";
            this.txtDownload.ReadOnly = true;
            this.txtDownload.Size = new System.Drawing.Size(395, 29);
            this.txtDownload.TabIndex = 14;
            this.txtDownload.TextChanged += new System.EventHandler(this.txtDownload_TextChanged);
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Red;
            this.btn3.Location = new System.Drawing.Point(49, 298);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 36);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "Cập nhật";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Đường dẫn lưu nhạc tải về";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbLocal
            // 
            this.cbLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocal.FormattingEnabled = true;
            this.cbLocal.Location = new System.Drawing.Point(49, 79);
            this.cbLocal.Margin = new System.Windows.Forms.Padding(4);
            this.cbLocal.Name = "cbLocal";
            this.cbLocal.Size = new System.Drawing.Size(395, 29);
            this.cbLocal.TabIndex = 6;
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Red;
            this.btn1.Location = new System.Drawing.Point(49, 123);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 36);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "Thêm";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đường dẫn lấy nhạc";
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(157, 123);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 36);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Xóa";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // SettingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.hopeTabPage1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingView";
            this.Size = new System.Drawing.Size(999, 606);
            this.Load += new System.EventHandler(this.SettingView_Load);
            this.hopeTabPage1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.HopeTabPage hopeTabPage1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLocal;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtDownload;
        private System.Windows.Forms.Button button1;
    }
}
