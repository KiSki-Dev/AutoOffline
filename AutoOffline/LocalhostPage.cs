using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutoOffline
{
    internal class LocalhostPage
    {
        public static LocalhostPage instance;
        private HttpListener _listener;
        private Thread _serverThread;
        private string _htmlFilePath;
        public int remainingTime;

        public void Start()
        {
            _serverThread = new Thread(StartServer);
            _serverThread.Start();

            _htmlFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "index.html");
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
                        MessageBox.Show("Clicked", "Click");

                        string responseText = "<html><body><h1>Button clicked!</h1></body></html>";
                        byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseText);

                        context.Response.ContentType = "text/html";
                        context.Response.ContentLength64 = buffer.Length;
                        context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                    }
                    else if (context.Request.HttpMethod == "POST" && context.Request.Url.AbsolutePath == "/stop-timer")
                    {
                        Menu.instance.StopTimer();

                        string responseText = "<html><body><h1>Button clicked!</h1></body></html>";
                        byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseText);

                        context.Response.ContentType = "text/html";
                        context.Response.ContentLength64 = buffer.Length;
                        context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                    }
                    else if (context.Request.HttpMethod == "GET" && context.Request.Url.AbsolutePath == "/get-timer")
                    {
                        string responseText = Menu.instance.time.ToString();
                        byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseText);

                        context.Response.ContentType = "text/plain";
                        context.Response.ContentLength64 = buffer.Length;
                        context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                    }
                    else
                    {
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
    }
}
