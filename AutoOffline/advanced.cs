using Salaros.Configuration;
using System.Diagnostics;
using System.Drawing;


namespace AutoOffline
{
    public partial class advanced : System.Windows.Forms.Form, ITimerClient
    {
        private string appConfig = Application.StartupPath + @"\config.conf";
        private string lanConfig = Application.StartupPath + @"\lanConfig.conf";
        public static advanced? instance;
        int time;

        public advanced()
        {
            InitializeComponent();
            DatePicker1.MinDate = DateTime.Now;
            instance = this;
            TimerManager.RegisterForm(this);

            language("btn-fnsh");
            language("error");
            language("error-msg");
            language("startup");

            autoPlace();
        }

        public void language(string translate)
        {
            var conf = new ConfigParser(appConfig);

            string language = conf.GetValue("CONFIG", "language");

            var lanConf = new ConfigParser(lanConfig);

            if (translate == "btn-fnsh") { buttonFNSH.Text = lanConf.GetValue(language, translate); }
            else if (translate == "error") { labelError.Text = lanConf.GetValue(language, translate); }
            else if (translate == "error-msg") { labelErrorMessage.Text = (lanConf.GetValue(language, "error-msg2")); }
            else if (translate == "startup")
            {
                dateTextOn.Text = lanConf.GetValue(language, "adv-text");
                dateTextAt.Text = lanConf.GetValue(language, "adv-text2");
                dateOn.Text = $"{DateTime.Now.Day.ToString().PadLeft(2, '0')}.{DateTime.Now.Month.ToString().PadLeft(2, '0')}.{DateTime.Now.Year.ToString().PadLeft(2, '0')}";
                dateAt.Text = $"{DateTime.Now.Hour.ToString().PadLeft(2, '0')}:{DateTime.Now.Minute.ToString().PadLeft(2, '0')}:{DateTime.Now.Second.ToString().PadLeft(2, '0')}";
            }
        }

        public void autoPlace()
        {
            dateOn.Location = new Point(dateTextOn.Location.X + dateTextOn.Width, dateTextOn.Location.Y);
            dateAt.Location = new Point(dateTextOn.Location.X + dateTextOn.Width, dateAt.Location.Y);
            dateTextAt.Location = new Point(dateTextOn.Location.X + dateTextOn.Width - dateTextAt.Width, dateAt.Location.Y);
        }

        private void advanced_FormClosed(object sender, FormClosedEventArgs e)
        {
            TimerManager.UnregisterForm(this);
        }

        public void StartTimer(int time)
        {
            // Start the timer with the specified number of seconds
            int seconds = Convert.ToInt32(time);
            timerAdv.Start();

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
            timerAdv.Stop();
        }

        private void buttonFNSH_Click(object sender, EventArgs e)
        {
            int times = 0;
            string OrSec = numUpDownSec.Text;
            string OrMin = numUpDownMin.Text;
            string OrHr = numUpDownHr.Text;
            DateTime selectedDateTime = new DateTime(DatePicker1.Value.Year, DatePicker1.Value.Month, DatePicker1.Value.Day, int.Parse(numUpDownHr.Text), int.Parse(numUpDownMin.Text), int.Parse(numUpDownSec.Text));

            if (selectedDateTime > DateTime.Now.Date) // Calculate...
            {
                DateTime now = DateTime.Now;
                DateTime select = new DateTime(DatePicker1.Value.Year, DatePicker1.Value.Month, DatePicker1.Value.Day, int.Parse(numUpDownHr.Text), int.Parse(numUpDownMin.Text), int.Parse(numUpDownSec.Text));

                times = (int)select.Subtract(now).TotalSeconds;
            }

            if (times == 0 || selectedDateTime <= DateTime.Now) // Error
            {
                labelError.Visible = true;
                labelErrorMessage.Visible = true;
            }
            else // Working
            {
                time = Convert.ToInt32(times);

                labelError.Visible = false;
                labelErrorMessage.Visible = false;

                StartTimer(time);
            }
        }

        private void timerAdv_Tick_1(object sender, EventArgs e)
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
                Menu.instance.tb1.Text = ($"{lanConf.GetValue(language, "cdown")} {str}");
            }
            else
            {
                TimeSpan seconds = TimeSpan.FromSeconds(time--);
                string str = seconds.ToString(@"hh\:mm\:ss");
                Menu.instance.tb1.Text = ($"{lanConf.GetValue(language, "cdown")} {str}");
            }

        }

        private void numUpDownHr_TextChanged(object sender, EventArgs e) { OnChange(); }
        private void numUpDownMin_TextChanged(object sender, EventArgs e) { OnChange(); }
        private void numUpDownSec_TextChanged(object sender, EventArgs e) { OnChange(); }
        private void DatePicker1_ValueChanged(object sender, EventArgs e) { OnChange(); }

        private void OnChange()
        {
            var conf = new ConfigParser(appConfig);

            string language = conf.GetValue("CONFIG", "language");

            var lanConf = new ConfigParser(lanConfig);

            dateTextOn.Text = lanConf.GetValue(language, "adv-text");
            dateTextAt.Text = lanConf.GetValue(language, "adv-text2");
            dateOn.Text = $"{DatePicker1.Value.Day.ToString().PadLeft(2, '0')}.{DatePicker1.Value.Month.ToString().PadLeft(2, '0')}.{DatePicker1.Value.Year.ToString().PadLeft(2, '0')}";
            dateAt.Text = $"{numUpDownHr.Text.PadLeft(2, '0')}:{numUpDownMin.Text.PadLeft(2, '0')}:{numUpDownSec.Text.PadLeft(2, '0')}";

        }

    }
}