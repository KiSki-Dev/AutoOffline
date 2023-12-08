using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Salaros.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace AutoOffline
{
    public partial class settings : System.Windows.Forms.Form
    {
        private string appConfig = Application.StartupPath + @"\config.conf";
        private string username;

        public settings()
        {
            InitializeComponent();
        }

        // Clickable Links
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://discord.gg/CFKjb63KbG";
            Process.Start("explorer", url);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/KiSki-Dev/AutoOffline";
            Process.Start("explorer", url);
        }

        private void buttonUsr_Click(object sender, EventArgs e) // Username Config
        {
            var conf = new ConfigParser(appConfig);

            username = richTextBoxUsr.Text;

            conf.SetValue("CONFIG", "username", username);
            conf.Save();
        }

        private void buttonLan_Click(object sender, EventArgs e) // Language Config
        {
            var conf = new ConfigParser(appConfig);

            string language = this.comboBoxLan.GetItemText(this.comboBoxLan.SelectedItem);

            if (language == "German")
            {
                conf.SetValue("CONFIG", "language", "de");
                conf.Save();
            }
            else if (language == "English")
            {
                conf.SetValue("CONFIG", "language", "en");
                conf.Save();
            }
            else if (language == "Spanish")
            {
                conf.SetValue("CONFIG", "language", "en"); // Change if Spanish is avaible
                conf.Save();
            }
            else if (language == "Russian")
            {
                conf.SetValue("CONFIG", "language", "ru"); // Change if Spanish is avaible
                conf.Save();
            }
        }

    }
}