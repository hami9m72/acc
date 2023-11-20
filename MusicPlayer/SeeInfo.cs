using MusicPlayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
namespace MusicPlayer
{
    public partial class SeeInfo : Form
    {
        Song song2;
        public SeeInfo(Song song)
        {
            InitializeComponent();
            song2 = song;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
    
        }

        public static void CopyFileToDirectory(string sourceFilePath, string destinationDirectory)
        {
            try
            {
                // Ensure the destination directory exists
                if (!Directory.Exists(destinationDirectory))
                {
                    Directory.CreateDirectory(destinationDirectory);
                }

                // Extract the filename from the source file path
                string fileName = Path.GetFileName(sourceFilePath);

                // Combine the destination directory and filename to create the destination file path
                string destinationFilePath = Path.Combine(destinationDirectory, fileName);

                // Copy the file
                System.IO.File.Copy(sourceFilePath, destinationFilePath, true); // Overwrites if the file already exists
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void SeeInfo_Load(object sender, EventArgs e)
        {
            lbCountry.Text = song2.GetAlbumName();
            lbArtist.Text = GetSongArtist(song2.GetSrc());
            lbName.Text = Path.GetFileNameWithoutExtension(song2.GetSrc());
            pictureBox1.Image = null;
            pictureBox1.BackgroundImage = song2.GetThumbImg() as Image;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

        }
        private string GetSongArtist(string filePath)
        {
            try
            {
                TagLib.File file = TagLib.File.Create(filePath);

                string artist = string.Join(", ", file.Tag.Performers);

                return artist;
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            String destPath = folderBrowser.SelectedPath;
            String sourcePath = song2.GetSrc();
            try
            {
                CopyFileToDirectory(sourcePath, destPath);
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }
        }
    }
}
