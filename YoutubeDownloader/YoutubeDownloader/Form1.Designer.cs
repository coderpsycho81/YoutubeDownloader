
namespace YoutubeDownloader
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.downloadBTN = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mp4_rad = new System.Windows.Forms.RadioButton();
            this.mp3_rad = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.music_name = new System.Windows.Forms.Label();
            this.urlText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.downloadBTN);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(296, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 203);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(462, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // downloadBTN
            // 
            this.downloadBTN.BackColor = System.Drawing.Color.IndianRed;
            this.downloadBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadBTN.FlatAppearance.BorderSize = 0;
            this.downloadBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadBTN.Location = new System.Drawing.Point(190, 165);
            this.downloadBTN.Name = "downloadBTN";
            this.downloadBTN.Size = new System.Drawing.Size(89, 34);
            this.downloadBTN.TabIndex = 3;
            this.downloadBTN.Text = "INDIR";
            this.downloadBTN.UseVisualStyleBackColor = false;
            this.downloadBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mp4_rad);
            this.groupBox3.Controls.Add(this.mp3_rad);
            this.groupBox3.Location = new System.Drawing.Point(85, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 69);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Format";
            // 
            // mp4_rad
            // 
            this.mp4_rad.AutoSize = true;
            this.mp4_rad.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mp4_rad.Location = new System.Drawing.Point(161, 29);
            this.mp4_rad.Name = "mp4_rad";
            this.mp4_rad.Size = new System.Drawing.Size(50, 21);
            this.mp4_rad.TabIndex = 1;
            this.mp4_rad.TabStop = true;
            this.mp4_rad.Text = "MP4";
            this.mp4_rad.UseVisualStyleBackColor = true;
            this.mp4_rad.CheckedChanged += new System.EventHandler(this.mp4_rad_CheckedChanged);
            // 
            // mp3_rad
            // 
            this.mp3_rad.AutoSize = true;
            this.mp3_rad.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mp3_rad.Location = new System.Drawing.Point(100, 29);
            this.mp3_rad.Name = "mp3_rad";
            this.mp3_rad.Size = new System.Drawing.Size(50, 21);
            this.mp3_rad.TabIndex = 0;
            this.mp3_rad.TabStop = true;
            this.mp3_rad.Text = "MP3";
            this.mp3_rad.UseVisualStyleBackColor = true;
            this.mp3_rad.CheckedChanged += new System.EventHandler(this.mp3_rad_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.music_name);
            this.groupBox2.Controls.Add(this.urlText);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Youtube URL";
            // 
            // music_name
            // 
            this.music_name.AutoSize = true;
            this.music_name.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.music_name.Location = new System.Drawing.Point(25, 44);
            this.music_name.Name = "music_name";
            this.music_name.Size = new System.Drawing.Size(0, 14);
            this.music_name.TabIndex = 3;
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(79, 19);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(377, 20);
            this.urlText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adres: ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(498, 248);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Downloader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton mp4_rad;
        private System.Windows.Forms.RadioButton mp3_rad;
        private System.Windows.Forms.Button downloadBTN;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label music_name;
        private System.Windows.Forms.Label label2;
    }
}

