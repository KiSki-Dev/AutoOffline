using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoOffline
{
    public partial class help : System.Windows.Forms.Form
    {
        public help()
        {
            InitializeComponent();
        }

        // Clickable Links
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://discord.gg/CFKjb63KbG";
            Process.Start("explorer", url);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string url = "https://discord.gg/CFKjb63KbG";
            Process.Start("explorer", url);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/KiSki-Dev/AutoOffline";
            Process.Start("explorer", url);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/KiSki-Dev/AutoOffline";
            Process.Start("explorer", url);
        }
    }
}
