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
    public partial class home : System.Windows.Forms.Form
    {
        private string appConfig = Application.StartupPath + @"\config.conf";
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
        }

        public static class TimerManager
        {
            private static List<Form> activeForms = new List<Form>();

            public static void RegisterForm(Form form)
            {
                activeForms.Add(form);
            }

            public static void UnregisterForm(Form form)
            {
                activeForms.Remove(form);
            }

            public static void StopAllTimers()
            {
                foreach (var form in activeForms)
                {
                    if (form is advanced advanced)
                    {
                        advanced.instance.StopTimer();
                    }
                    if (form is basic basic)
                    {
                        basic.instance.StopTimer();
                    }
                    if (form is home home)
                    {
                        home.instance.StopTimer();
                    }
                }
            }
        }

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Unregister this form from the TimerManager when its closed
            TimerManager.UnregisterForm(this);
        }

        public void welcome() // Welcome Text
        {
            var conf = new ConfigParser(appConfig);

            username = conf.GetValue("CONFIG", "username");
            if (username == "automatic")
            {
                string username = (Environment.UserName);
                richTextBoxWelcome.Text = ("Hello, " + username + "!");
            }
            else if (username != "automatic")
            {
                richTextBoxWelcome.Text = ("Hello, " + username + "!");
            }

        }

        public void StartTimer(int seconds)
        {
            // Start the timer with the specified number of seconds
            timerPre.Start();

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
            Process.Start("shutdown", "/s /t 300");
        }

        private void button4h_Click(object sender, EventArgs e) // Starts Timer and Shutdowns PC after 4 Hours (14400 Seconds)
        {
            seconds = Convert.ToInt32(14400);
            StartTimer(seconds);
            Process.Start("shutdown", "/s /t 14400");
        }

        private void button2h_Click(object sender, EventArgs e) // Starts Timer and Shutdowns PC after 2 Hours (7200 Seconds)
        {
            seconds = Convert.ToInt32(7200);
            StartTimer(seconds);
            Process.Start("shutdown", "/s /t 7200");
        }

        private void button1h_Click(object sender, EventArgs e) // Starts Timer and Shutdowns PC after 1 Hours (3600 Seconds)
        {
            seconds = Convert.ToInt32(3600);
            StartTimer(seconds);
            Process.Start("shutdown", "/s /t 3600");
        }

        private void button30m_Click(object sender, EventArgs e) // Starts Timer and Shutdowns PC after 30 Minutes (1800 Seconds)
        {
            seconds = Convert.ToInt32(1800);
            StartTimer(seconds);
            Process.Start("shutdown", "/s /t 1800");
        }

        private void button10m_Click(object sender, EventArgs e) // Starts Timer and Shutdowns PC after 10 Minutes (600 Seconds)
        {
            seconds = Convert.ToInt32(600);
            StartTimer(seconds);
            Process.Start("shutdown", "/s /t 600");
        }

        private void timerPre_Tick(object sender, EventArgs e) // Timer
        {
            // If the Timer is above 0 it normally works
            if (seconds < 1) // If Timer hits 0 it turns the Timer off and prints "Shutdown not set"
            {
            }
            else
            {
                TimeSpan time = TimeSpan.FromSeconds(seconds--);
                string str = time.ToString(@"hh\:mm\:ss");
                labelCdown.Text = str;
                Menu.instance.tb1.Text = ("Shutdown in: " + str);
            }

        }
    }
}
