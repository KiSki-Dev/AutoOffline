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
    public partial class basic : System.Windows.Forms.Form
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
                    if (form is basic basic)
                    {
                        basic.StopTimer();
                    }
                    if (form is advanced advanced)
                    {
                        advanced.instance.StopTimer();
                    }
                    if (form is home home)
                    {
                        home.instance.StopTimer();
                    }
                }
            }
        }

        private void basic_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Unregister this form from the TimerManager when it is closed
            TimerManager.UnregisterForm(this);
        }

        public void StartTimer(int time)
        {
            // Start the timer with the specified number of seconds
            timerBasic.Start();
        }

        public void StopTimer()
        {
            timerBasic.Stop();
        }

        private void buttonFNSH_Click(object sender, EventArgs e)
        {
            int Sec = int.Parse(comboBoxSec.Text);
            int Min = int.Parse(comboBoxMin.Text) * 60;
            int Hr = int.Parse(comboBoxHr.Text) * 3600;
            int Day = int.Parse(comboBoxDay.Text) * 86400;

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

                Process.Start("shutdown", "/s /t " + time);

            }

        }

        private void timerBasic_Tick(object sender, EventArgs e)
        {
            string off = "Shutdown not set";
            if (time < 1) // If Timer hits 0 it turns the Timer off and prints "Shutdown not set"
            {
                timerBasic.Stop();
                labelConDown.Text = off;
                Menu.instance.tb1.Text = ("Shutdown not set");
            }
            else if (time > 86400)
            {
                TimeSpan seconds = TimeSpan.FromSeconds(time--);
                string str = seconds.ToString(@"dd\:hh\:mm\:ss");
                labelConDown.Text = str;
                Menu.instance.tb1.Text = ("Shutdown in: " + str);
            }
            else
            {
                TimeSpan seconds = TimeSpan.FromSeconds(time--);
                string str = seconds.ToString(@"hh\:mm\:ss");
                labelConDown.Text = str;
                Menu.instance.tb1.Text = ("Shutdown in: " + str);
            }
        }
    }
}
