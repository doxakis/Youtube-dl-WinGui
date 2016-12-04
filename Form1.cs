using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

// Tosil Velkov - tosil@velkoff.net

namespace Youtube_dl_WinGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Check_YoutubeDL();

            // Disable resize.
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            // Destination folder: My music
            DestinationBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        }

        private static bool Check_YoutubeDL()
        {
            if (!File.Exists("youtube-dl.exe"))
            {
                MessageBox.Show("Cannot find Youtube-dl.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        
        private void GoButton_Click(object sender, EventArgs e)
        {
            if (Check_YoutubeDL()) return;

            if (string.IsNullOrWhiteSpace(this.DestinationBox.Text.ToString()))
            {
                MessageBox.Show("Please specify a destination folder.");
                return;
            }

            if (string.IsNullOrWhiteSpace(URLbox.Text))
            {
                MessageBox.Show("Please specify at least one URL.");
                return;
            }
            
            // One link per line.
            var links = URLbox.Text.Replace("\t", "").Split('\n');
            foreach (var link in links)
            {
                Process startprogd = new Process();
                startprogd.StartInfo.FileName = "youtube-dl.exe";
                startprogd.StartInfo.Arguments = "--audio-quality 5 --extract-audio --audio-format mp3 " + @" -o """ + this.DestinationBox.Text.ToString().Trim() + @"\%(title)s.%(ext)s""" + " " + link;
                startprogd.Start();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.DestinationBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void openFolder_Click(object sender, EventArgs e)
        {
            // Open destination in File Explorer.
            Process.Start("explorer.exe", DestinationBox.Text);
        }

        private void addUrl_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(URLbox.Text))
            {
                URLbox.Text += Environment.NewLine + Clipboard.GetText();
            }
            else
            {
                URLbox.Text = Clipboard.GetText();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Reset form.
            URLbox.Text = "";
        }
    }
}
