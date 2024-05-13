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
using System.Net;

namespace AutoOffline
{
    public partial class Menu : System.Windows.Forms.Form
    {
        public static Menu instance;
        public Label tb1;
        public string usr_language = System.Globalization.CultureInfo.CurrentCulture.EnglishName;
        private string appConfig = Application.StartupPath + @"\config.conf";
        private string lanConfig = Application.StartupPath + @"\lanConfig.conf";

        private HttpListener _listener;
        private Thread _serverThread;
        private string _htmlFilePath;
        public int remainingTime;

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

            _htmlFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "index.html");
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            _serverThread = new Thread(StartServer);
            _serverThread.Start();
        }

        private void StartServer()
        {
            _listener = new HttpListener();
            _listener.Prefixes.Add("http://localhost:8080/");

            try
            {
                _listener.Start();
                Console.WriteLine("HTTP server running...");

                while (_listener.IsListening)
                {
                    HttpListenerContext context = _listener.GetContext();

                    if (context.Request.HttpMethod == "POST" && context.Request.Url.AbsolutePath == "/button-clicked")
                    {
                        // Führe hier die gewünschte C#-Funktion aus
                        // Zum Beispiel:
                        MessageBox.Show("Clicked", "Click");

                        string responseText = "<html><body><h1>Button clicked!</h1></body></html>";
                        byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseText);

                        context.Response.ContentType = "text/html";
                        context.Response.ContentLength64 = buffer.Length;
                        context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                    }
                    else if (context.Request.HttpMethod == "POST" && context.Request.Url.AbsolutePath == "/stop-timer")
                    {
                        StopTimer();

                        string responseText = "<html><body><h1>Button clicked!</h1></body></html>";
                        byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseText);

                        context.Response.ContentType = "text/html";
                        context.Response.ContentLength64 = buffer.Length;
                        context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                    }
                    else if (context.Request.HttpMethod == "GET" && context.Request.Url.AbsolutePath == "/get-timer")
                    {
                        // Sende den Timer-Wert als Antwort
                        string responseText = remainingTime.ToString();
                        byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseText);

                        context.Response.ContentType = "text/plain";
                        context.Response.ContentLength64 = buffer.Length;
                        context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                    }
                    else
                    {
                        // Lade die HTML-Datei wie zuvor
                        ServeHtmlFile(context);
                    }

                    context.Response.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                _listener.Stop();
                _listener.Close();
            }
        }

        private void ServeHtmlFile(HttpListenerContext context)
        {
            if (File.Exists(_htmlFilePath))
            {
                string responseText;
                using (StreamReader reader = new StreamReader(_htmlFilePath))
                {
                    responseText = reader.ReadToEnd();
                }

                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseText);

                context.Response.ContentType = "text/html";
                context.Response.ContentLength64 = buffer.Length;
                context.Response.OutputStream.Write(buffer, 0, buffer.Length);
            }
            else
            {
                string responseText = "<html><body><h1>404 Not Found</h1><p>Die angeforderte Datei wurde nicht gefunden.</p></body></html>";
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseText);

                context.Response.StatusCode = 404;
                context.Response.ContentType = "text/html";
                context.Response.ContentLength64 = buffer.Length;
                context.Response.OutputStream.Write(buffer, 0, buffer.Length);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_listener != null && _listener.IsListening)
            {
                _listener.Stop();
            }
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
            string lanConfURL = "https://raw.githubusercontent.com/KiSki-Dev/AutoOffline/main/lanConfig.conf";
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
            string url = "https://discord.com/invite/cYqpx7dqsn";
            Process.Start("explorer", url);
        }

        // Stop Timer
        private void buttonStopSTD_Click(object sender, EventArgs e)
        {
            StopTimer();
            language("menu");
        }

        private void StopTimer()
        {
            ProcessStartInfo psi = new ProcessStartInfo // Make the CMD invisible
            {
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = new Process { StartInfo = psi };

            process.Start();

            process.StandardInput.WriteLine("shutdown -a");

            TimerManager.StopAllTimers(); // Stop all Timers

            remainingTime = 0;
        }
    }
}