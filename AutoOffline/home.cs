using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Salaros.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AutoOffline
{
    public partial class home : System.Windows.Forms.Form, ITimerClient
    {
        private string appConfig = Application.StartupPath + @"\config.conf";
        private string lanConfig = Application.StartupPath + @"\lanConfig.conf";
        int seconds;
        private string username;
        public static home instance;
        public home()
        {
            InitializeComponent();
            welcome();
            instance = this;
            timerPre.Interval = 1000; // 1 second

            TimerManager.RegisterForm(this);

            language("preset");
            language("home-info");
            language("minute");
            language("hour");
        }

        public void language(string translate)
        {
            var conf = new ConfigParser(appConfig);

            string language = conf.GetValue("CONFIG", "language");

            var lanConf = new ConfigParser(lanConfig);

            if (translate == "preset") { labelPre.Text = lanConf.GetValue(language, translate); }
            else if (translate == "home-info")
            {
                labelInfo.Text = $"{lanConf.GetValue(language, "home-info1")}\n\n{lanConf.GetValue(language, "home-info2")}\n{lanConf.GetValue(language, "home-info3")}\n\n" +
                    $"{lanConf.GetValue(language, "home-info4")}\n{lanConf.GetValue(language, "home-info5")}\n\n{lanConf.GetValue(language, "home-info6")}\n{lanConf.GetValue(language, "home-info7")}";
            }
            else if (translate == "minute")
            {
                button5m.Text = $"5 {lanConf.GetValue(language, translate)}";
                button10m.Text = $"10 {lanConf.GetValue(language, translate)}";
                button30m.Text = $"30 {lanConf.GetValue(language, translate)}";
            }
            else if (translate == "hour")
            {
                button1h.Text = $"1 {lanConf.GetValue(language, translate)}";
                button2h.Text = $"2 {lanConf.GetValue(language, translate)}";
                button4h.Text = $"4 {lanConf.GetValue(language, translate)}";
            }
        }

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Unregister this form from the TimerManager when it is closed
            TimerManager.UnregisterForm(this);
        }

        public void welcome() // Welcome Text
        {
            var conf = new ConfigParser(appConfig);

            var lanConf = new ConfigParser(lanConfig);

            string language = conf.GetValue("CONFIG", "language");
            string message = lanConf.GetValue(language, "welcome");
            username = conf.GetValue("CONFIG", "username");
            if (username == "automatic")
            {
                string username = Environment.UserName;
                labelWelcome.Text = $"{message} {username}!";
            }
            else if (username != "automatic")
            {
                labelWelcome.Text = $"{message} {username}!";
            }

        }

        public void StartTimer(int seconds)
        {
            // Start the timer with the specified number of seconds
            timerPre.Start();

            ProcessStartInfo psi = new ProcessStartInfo // Make the CMD invisible
            {
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = new Process { StartInfo = psi };

            process.Start();

            process.StandardInput.WriteLine("shutdown /s /t " + seconds);

        }

        public void StopTimer()
        {
            timerPre.Stop();
        }

        // Presets
        private void button5m_Click(object sender, EventArgs e) // Starts Timer and Shutdowns PC after 5 Minutes (300 Seconds)
        {
            seconds = Convert.ToInt32(300);
            StartTimer(seconds);
        }

        private void button4h_Click(object sender, EventArgs e) // Starts Timer and Shutdowns PC after 4 Hours (14400 Seconds)
        {
            seconds = Convert.ToInt32(14400);
            StartTimer(seconds);
        }

        private void button2h_Click(object sender, EventArgs e) // Starts Timer and Shutdowns PC after 2 Hours (7200 Seconds)
        {
            seconds = Convert.ToInt32(7200);
            StartTimer(seconds);
        }

        private void button1h_Click(object sender, EventArgs e) // Starts Timer and Shutdowns PC after 1 Hours (3600 Seconds)
        {
            seconds = Convert.ToInt32(3600);
            StartTimer(seconds);
        }

        private void button30m_Click(object sender, EventArgs e) // Starts Timer and Shutdowns PC after 30 Minutes (1800 Seconds)
        {
            seconds = Convert.ToInt32(1800);
            StartTimer(seconds);
        }

        private void button10m_Click(object sender, EventArgs e) // Starts Timer and Shutdowns PC after 10 Minutes (600 Seconds)
        {
            seconds = Convert.ToInt32(600);
            StartTimer(seconds);
        }

        private void timerPre_Tick(object sender, EventArgs e) // Timer
        {
            LocalhostPage webpageClass = new LocalhostPage();
            var conf = new ConfigParser(appConfig);
            string language = conf.GetValue("CONFIG", "language");
            var lanConf = new ConfigParser(lanConfig);
            // If the Timer is above 0 it normally works
            if (seconds < 1) // If Timer hits 0 it turns the Timer off and prints "Shutdown not set"
            {
            }
            else
            {
                TimeSpan time = TimeSpan.FromSeconds(seconds--);
                string str = time.ToString(@"hh\:mm\:ss");

                Menu.instance.time = seconds;
                Menu.instance.tb1.Text = ($"{lanConf.GetValue(language, "cdown")} {str}");
            }

        }
    }
}
