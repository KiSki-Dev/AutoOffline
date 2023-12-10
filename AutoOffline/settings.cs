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
        private string lanConfig = Application.StartupPath + @"\lanConfig.conf";
        private string username;

        public settings()
        {
            InitializeComponent();

            language("conf");
            language("lan");
            language("usr");
            language("save");
            language("fea");
            language("feaTxt1");
            language("feaTxt2");
            language("feaTxt3");
            language("feaTxt4");
        }

        public void language(string translate)
        {
            var conf = new ConfigParser(appConfig);

            string language = conf.GetValue("CONFIG", "language");

            var lanConf = new ConfigParser(lanConfig);

            if (translate == "conf") { labelCon.Text = lanConf.GetValue(language, translate); }
            else if (translate == "lan") { labelLan.Text = lanConf.GetValue(language, translate); }
            else if (translate == "usr") { labelUsr.Text = lanConf.GetValue(language, translate); }
            else if (translate == "save") { buttonUsr.Text = lanConf.GetValue(language, translate); buttonLan.Text = lanConf.GetValue(language, translate); }
            else if (translate == "fea") { labelFea.Text = lanConf.GetValue(language, translate); }
            else if (translate == "feaTxt1") { labelNFeaText.Text = lanConf.GetValue(language, translate); }
            else if (translate == "feaTxt2") { labelNFeaText2.Text = lanConf.GetValue(language, translate); }
            else if (translate == "feaTxt3") { labelNFeaText3.Text = lanConf.GetValue(language, translate); }
            else if (translate == "feaTxt4") { linkLabelNFeaText.Text = lanConf.GetValue(language, translate); }
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

                string message = "Please restart AutoOffline to change the Language.";
                string title = "Restart AutoOffline";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    conf.SetValue("CONFIG", "language", "de");
                    conf.Save();
                    Application.Restart();
                }
            }
            else if (language == "English")
            {
                string message = "Please restart AutoOffline to change the Language.";
                string title = "Restart AutoOffline";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    conf.SetValue("CONFIG", "language", "en");
                    conf.Save();
                    Application.Restart();
                }
            }
            else if (language == "Spanish")
            {
                string message = "Please restart AutoOffline to change the Language.";
                string title = "Restart AutoOffline";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    conf.SetValue("CONFIG", "language", "en");
                    conf.Save();
                    Application.Restart();
                }
            }
            else if (language == "Russian")
            {
                string message = "Please restart AutoOffline to change the Language.";
                string title = "Restart AutoOffline";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    conf.SetValue("CONFIG", "language", "ru");
                    conf.Save();
                    Application.Restart();
                }
            }
        }

    }
}