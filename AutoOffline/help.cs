using Salaros.Configuration;
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
        private string appConfig = Application.StartupPath + @"\config.conf";
        private string lanConfig = Application.StartupPath + @"\lanConfig.conf";

        public help()
        {
            InitializeComponent();

            language("helpTxt");
            language("github");
            language("disc");
        }

        public void language(string translate)
        {
            var conf = new ConfigParser(appConfig);

            string language = conf.GetValue("CONFIG", "language");

            var lanConf = new ConfigParser(lanConfig);

            if (translate == "helpTxt") { labelText.Text = $"{lanConf.GetValue(language, "helpTxt")}\n{lanConf.GetValue(language, "helpTxt2")}\n{lanConf.GetValue(language, "helpTxt3")}\n\n{lanConf.GetValue(language, "helpTxt4")}\n{lanConf.GetValue(language, "helpTxt5")}\n\n{lanConf.GetValue(language, "helpTxt6")}"; }
            else if (translate == "github") { linkLabelGit.Text = lanConf.GetValue(language, translate); }
            else if (translate == "disc") { linkLabelDisc.Text = lanConf.GetValue(language, translate); }
        }

        // Clickable Links
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://discord.com/invite/cYqpx7dqsn";
            Process.Start("explorer", url);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string url = "https://discord.com/invite/cYqpx7dqsn";
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
