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
        public static basic instance;
        int time;
        public basic()
        {
            InitializeComponent();
            instance = this;
            timerBasic.Interval = 1000; // 1 second

            TimerManager.RegisterForm(this);
        }

        private void advanced_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Unregister this form from the TimerManager when it is closed
            TimerManager.UnregisterForm(this);

        }

        public void StartTimer(int time)
        {
            // Start the timer with the specified number of seconds
            int seconds = Convert.ToInt32(time);
            timerBasic.Start();
            Process.Start("shutdown", "/s /t " + seconds);
        }

        public void StopTimer()
        {
            timerBasic.Stop();
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
                labelCdown.Text = time.ToString();
                StartTimer(time);

            }
        }


        private void timerBasic_Tick(object sender, EventArgs e)
        {
            if (time < 1) // If Timer hits 0 it turns the Timer off and prints "Shutdown not set"
            {
            }
            else if (time > 86400) // If Timer goes over 1 day it adds 2 Zeros do the Countdown at the Top to print the Days left
            {
                TimeSpan seconds = TimeSpan.FromSeconds(time--);
                string str = seconds.ToString(@"dd\:hh\:mm\:ss");
                labelCdown.Text = str;
                Menu.instance.tb1.Text = ("Shutdown in: " + str);
            }
            else
            {
                TimeSpan seconds = TimeSpan.FromSeconds(time--);
                string str = seconds.ToString(@"hh\:mm\:ss");
                labelCdown.Text = str;
                Menu.instance.tb1.Text = ("Shutdown in: " + str);
            }

        }
    }
}
