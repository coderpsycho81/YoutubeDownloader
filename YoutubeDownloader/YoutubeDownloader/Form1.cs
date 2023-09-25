using System;
using System.Windows.Forms;
using VideoLibrary;
using MediaToolkit;
using System.IO;
using System.Net;

namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean format = true;

        #region Download BTNs
        private async void button1_Click(object sender, EventArgs e)
        {
            if(urlText.Text != "")
            {
                try
                {
                    using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Nereye İndirmek İstiyorsun ? " })
                    {
                        if (fbd.ShowDialog() == DialogResult.OK)
                        {
                            GetTitle();
                            timer1.Start();
                            progressBar1.Minimum = 0;
                            progressBar1.Maximum = 100;
                            progressBar1.Step = 1;

                            MessageBox.Show("İndirme Başlatıldı. Lütfen Bekleyiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Cursor = Cursors.WaitCursor;
                            downloadBTN.Enabled = false;
                            progressBar1.Value = 50;
                            MessageBox.Show("Biraz Uzun Sürebilir. Lütfen Bekleyiniz..", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;

                            var yt = YouTube.Default; // Youtube Service
                            var video = await yt.GetVideoAsync(urlText.Text); // asenkron olarak indirir. video ya atar.

                            File.WriteAllBytes(fbd.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync()); // Dizine Kaydeder.

                            var inputFile = new MediaToolkit.Model.MediaFile { Filename = fbd.SelectedPath + @"\" + video.FullName };
                            var outputFile = new MediaToolkit.Model.MediaFile { Filename = $"{fbd.SelectedPath + @"\" + video.FullName }.mp3" };

                            using (var enging = new Engine())
                            {
                                enging.GetMetadata(inputFile);
                                enging.Convert(inputFile, outputFile);
                            }

                            if (format == true)
                            {
                                File.Delete(fbd.SelectedPath + @"\" + video.FullName);
                                progressBar1.Value = 100;

                            }
                            else
                            {
                                File.Delete($"{fbd.SelectedPath + @"\" + video.FullName}.mp3");
                                progressBar1.Value = 100;

                            }

                            MessageBox.Show("İndirme İşlemi Tamamlandı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Cursor = Cursors.Arrow;
                            downloadBTN.Enabled = true;
                            progressBar1.Value = 0;
                            urlText.Text = "";
                            music_name.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Dosya Yolu Seçiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Cursor = Cursors.Arrow;
                            downloadBTN.Enabled = true;
                            progressBar1.Value = 0;
                            urlText.Text = "";
                            music_name.Text = "";
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Üzgünüm Beklenmedik Bi Hata Çıktı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Cursor = Cursors.Arrow;
                    downloadBTN.Enabled = true;
                    progressBar1.Value = 0;
                    urlText.Text = "";
                    music_name.Text = "";
                }
            }
        }
        #endregion

        #region GetTitle
        private void GetTitle()
        {
            WebRequest request = HttpWebRequest.Create(urlText.Text);
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            string incoming = sr.ReadToEnd();
            int beginning = incoming.IndexOf("<title>") + 7;
            int end = incoming.Substring(beginning).IndexOf("</title>");
            string incoming_information = incoming.Substring(beginning, end);
            music_name.Text = (incoming_information);
        }
        #endregion

        #region timerClock
        private void timer1_Tick(object sender, EventArgs e)
        {
            music_name.Text = music_name.Text.Substring(1) + music_name.Text.Substring(0, 1);
        }
        #endregion

        #region MP3_rad
        private void mp3_rad_CheckedChanged(object sender, EventArgs e)
        {
            format = true;
        }
        #endregion

        #region MP4_rad
        private void mp4_rad_CheckedChanged(object sender, EventArgs e)
        {
            format = false;
        }
        #endregion
    }
}
