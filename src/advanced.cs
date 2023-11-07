using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AutoOffline.advanced;
using static AutoOffline.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoOffline
{
    public partial class advanced : System.Windows.Forms.Form
    {
        public static advanced instance;
        int time;
        public advanced()
        {
            InitializeComponent();
            instance = this;
            timerAdv.Interval = 1000; // 1 second

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

        private void advanced_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Unregister this form from the TimerManager when it is closed
            TimerManager.UnregisterForm(this);
        }

        public void StartTimer(int time)
        {
            // Start the timer with the specified number of seconds
            timerAdv.Start();
        }

        public void StopTimer()
        {
            timerAdv.Stop();
        }

        private void buttonFNSH_Click(object sender, EventArgs e)
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


        private void timerAdv_Tick_1(object sender, EventArgs e)
        {
            string off = "Shutdown not set";
            if (time < 1) // If Timer hits 0 it turns the Timer off and prints "Shutdown not set"
            {
                timerAdv.Stop();
                labelCdown.Text = off;
                Menu.instance.tb1.Text = ("Shutdown not set");
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
