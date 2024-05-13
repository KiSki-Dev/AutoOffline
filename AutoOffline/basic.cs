using Salaros.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoOffline
{
    public partial class basic : System.Windows.Forms.Form, ITimerClient
    {
        private string appConfig = Application.StartupPath + @"\config.conf";
        private string lanConfig = Application.StartupPath + @"\lanConfig.conf";
        public static basic instance;
        int time;

        public basic()
        {
            InitializeComponent();
            instance = this;
            timerBasic.Interval = 1000; // 1 second

            TimerManager.RegisterForm(this);

            language("sec");
            language("minute");
            language("hour");
            language("day");
            language("btn-fnsh");
            language("error");
            language("error-msg");
        }

        public void language(string translate)
        {
            var conf = new ConfigParser(appConfig);

            string language = conf.GetValue("CONFIG", "language");

            var lanConf = new ConfigParser(lanConfig);

            if (translate == "sec") { labelSec.Text = lanConf.GetValue(language, translate); }
            else if (translate == "minute") { labelMin.Text = lanConf.GetValue(language, translate); }
            else if (translate == "hour") { labelHr.Text = lanConf.GetValue(language, translate); }
            else if (translate == "day") { labelDay.Text = lanConf.GetValue(language, translate); }
            else if (translate == "btn-fnsh") { buttonFNSH.Text = lanConf.GetValue(language, translate); }
            else if (translate == "error") { labelError.Text = lanConf.GetValue(language, translate); }
            else if (translate == "error-msg") { labelErrorMessage.Text = lanConf.GetValue(language, translate); }
        }

        private void basic_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Unregister this form from the TimerManager when it is closed
            TimerManager.UnregisterForm(this);
        }

        public void StartTimer(int time)
        {
            // Start the timer with the specified number of seconds
            int seconds = Convert.ToInt32(time);
            timerBasic.Start();

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
            timerBasic.Stop();
            time = 0;
        }

        private void buttonFNSH_Click_1(object sender, EventArgs e)
        {
            int Sec = int.Parse(tbSec.Text);
            int Min = int.Parse(tbMin.Text) * 60;
            int Hr = int.Parse(tbHr.Text) * 3600;
            int Day = int.Parse(tbDay.Text) * 86400;

            int times = Sec + Min + Hr + Day;

            if (times == 0)
            {
                labelError.Visible = true;
                labelErrorMessage.Visible = true;
            }

            else
            {
                time = Convert.ToInt32(times);

                labelError.Visible = false;
                labelErrorMessage.Visible = false;
                StartTimer(time);

            }
        }

        private void timerBasic_Tick(object sender, EventArgs e)
        {
            var conf = new ConfigParser(appConfig);
            string language = conf.GetValue("CONFIG", "language");
            var lanConf = new ConfigParser(lanConfig);
            if (time < 1) // If Timer hits 0 it turns the Timer off and prints "Shutdown not set"
            {
            }
            else if (time > 86400) // If Timer goes over 1 day it adds 2 Zeros do the Countdown at the Top to print the Days left
            {
                TimeSpan seconds = TimeSpan.FromSeconds(time--);
                string str = seconds.ToString(@"dd\:hh\:mm\:ss");
                Menu.instance.tb1.Text = $"{lanConf.GetValue(language, "cdown")} {str}";
            }
            else
            {
                TimeSpan seconds = TimeSpan.FromSeconds(time--);
                string str = seconds.ToString(@"hh\:mm\:ss");
                Menu.instance.remainingTime = time;
                Menu.instance.tb1.Text = ($"{lanConf.GetValue(language, "cdown")} {str}");
            }
        }
    }
}
