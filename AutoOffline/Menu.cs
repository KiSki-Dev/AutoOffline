using System.Diagnostics;
using System.Net.Sockets;
using System.Security.Policy;
using System.Threading;
using System.Windows.Forms;
using static AutoOffline.advanced;
using static AutoOffline.Menu;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoOffline
{

    public partial class Menu : System.Windows.Forms.Form
    {
        public static Menu instance;
        public Label tb1;
        public Menu()
        {
            InitializeComponent();
            loadform(new home()); // Automatic get the Home View
            instance = this;
            tb1 = labelCountdown;
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

            tb1.Text = "Shutdown not set";
        }
    }
}