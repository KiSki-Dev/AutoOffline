using Salaros.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Security.Policy;
using System.Threading;
using System.Windows.Forms;
using static AutoOffline.advanced;
using static AutoOffline.Menu;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AutoOffline
{
    public partial class Menu : System.Windows.Forms.Form
    {
        public static Menu instance;
        public Label tb1;
        public string usr_language = System.Globalization.CultureInfo.CurrentCulture.EnglishName;
        private string appConfig = Application.StartupPath + @"\config.conf";
        private string lanConfig = Application.StartupPath + @"\lanConfig.conf";
        public Menu()
        {
            string conPath = @".\config.conf";
            if (!File.Exists(conPath))
            {
                // Create the file and write content to it
                File.WriteAllText(conPath, $"[CONFIG]\nusername=automatic\nlanguage=en");
            }
            string lanPath = @".\lanConfig.conf";
            if (!File.Exists(lanPath)) { lanDownload(); }

            InitializeComponent();
            loadform(new home()); // Automatic get the Home View
            instance = this;
            tb1 = labelCountdown;

            language("menu");
            language("btn-stop");
            language("home");
            language("basic");
            language("advanced");
            language("settings");
            language("help");
            language("exit");
        }

       public void language(string translate)
        {
            var conf = new ConfigParser(appConfig);

            string language = conf.GetValue("CONFIG", "language");

            var lanConf = new ConfigParser(lanConfig);

            if (translate == "menu") { tb1.Text = lanConf.GetValue(language, translate); }
            else if (translate == "btn-stop") { buttonStopSTD.Text = lanConf.GetValue(language, translate); }
            else if (translate == "home") { buttonHome.Text = lanConf.GetValue(language, translate); }
            else if (translate == "basic") { buttonBasic.Text = lanConf.GetValue(language, translate); }
            else if (translate == "advanced") { buttonAdvanced.Text = lanConf.GetValue(language, translate); }
            else if (translate == "settings") { buttonSettings.Text = lanConf.GetValue(language, translate); }
            else if (translate == "help") { buttonHelp.Text = lanConf.GetValue(language, translate); }
            else if (translate == "exit") { buttonExit.Text = lanConf.GetValue(language, translate); }
        }

        public async void lanDownload()
        {
            string lanConfURL = "https://pastebin.com/raw/JxXD65te";
            string lanConPath = @".\lanConfig.conf";
            using (HttpClient httpClient = new HttpClient())
            {
                string content = await httpClient.GetStringAsync(lanConfURL);
                File.WriteAllText(lanConPath, content);

                Application.Restart();
            }
        }

        // Below is the Side Menu Code
        public void loadform(object Form) // The Logic how to open a Form with the Menu on the right and Top
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            System.Windows.Forms.Form f = Form as System.Windows.Forms.Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        // Open Forms (Buttons)
        private void buttonBasic_Click(object sender, EventArgs e) // Open Basic Form
        {
            loadform(new basic());
        }

        private void buttonSettings_Click(object sender, EventArgs e) // Open Settings Form
        {
            loadform(new settings());
        }

        private void buttonAdvanced_Click(object sender, EventArgs e) // Open Advanced Form
        {
            loadform(new advanced());
        }

        private void buttonHelp_Click(object sender, EventArgs e) // Open Help Form
        {
            loadform(new help());
        }

        private void buttonHome_Click(object sender, EventArgs e) // Open Home Form
        {
            loadform(new home());
        }

        private void buttonExit_Click(object sender, EventArgs e) // Exit Button
        {
            Application.Exit();
        }

        // Clickable Link
        public void pictureBoxLogo_Click(object sender, EventArgs e) // Logo Click opens Discord
        {
            string url = "https://discord.gg/CFKjb63KbG";
            Process.Start("explorer", url);
        }

        // Stop Timer
        private void buttonStopSTD_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "-a");

            TimerManager.StopAllTimers(); // Stop all Timers

            language("menu");
        }
    }
}