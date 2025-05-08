using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMC;

namespace OfficeMediaCreator
{
    public partial class DownloadForm : Form
    {
        WebClient client;
        public string Url { get; set; }
        public string FileName { get; set; }
        public double FileSize { get; set; }
        public double Percentage { get; set; }

        private long lastBytesReceived = 0;

        private Stopwatch stopwatch = new Stopwatch();

        private long bytesDownloaded = 0;
        private bool isPaused = false;


        public string url;
        public string by;
        public void show(MainForm main)
        {
            if (btnPause.Text == GetResourceString("Home"))
            { main.Show(); this.Close(); }
        }

        public DownloadForm(string uri, MainForm main, string lang,string dev)
        {
            InitializeComponent();

            by = dev;
            SetLanguage(lang);
            RefreshUI();
            Url = uri;
            saveFileDialog1.FileName = Path.GetFileName(uri);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = saveFileDialog1.FileName;
                download();
            }
            else
            {
                btnPause.Text = GetResourceString("Home");
                show(main);
                return;
            }
        }

        private void download()
        {
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;

            // Start stopwatch to measure time intervals
            stopwatch.Start();

            //Get path and download file from internet
            Uri uri = new Uri(this.Url);
            FileName = Path.GetFileName(uri.AbsolutePath);
            client.DownloadFileAsync(uri, saveFileDialog1.FileName);
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblVelocidad.Text = "0 KB/s"; // Resetear la etiqueta de velocidad
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error: " + $" {e.Error.Message}", "MegaDownloader", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblVelocidad.Text = "0 KB/s"; // Resetear la etiqueta de velocidad
            }
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            if (!isPaused)
            {
                bytesDownloaded = e.BytesReceived; // Actualizar la cantidad de bytes descargados
            }

            progressBar1.Minimum = 0;
            double receive = double.Parse(e.BytesReceived.ToString());
            FileSize = double.Parse(e.TotalBytesToReceive.ToString());
            Percentage = receive / FileSize * 100;

            // Convertir el tamaño descargado y el total a MB y GB
            double receivedMB = receive / (1024 * 1024); // Convertir a MB
            double totalSizeMB = FileSize / (1024 * 1024); // Convertir a MB
            double totalSizeGB = FileSize / (1024 * 1024 * 1024); // Convertir a GB con decimales
            lblProgreso.Text = $"{string.Format("{0:0.##} % " + GetResourceString("complete"), Percentage)}";
            lblDescargado.Text = $" {string.Format("{0:0.##} MB de {1:0.##} MB ({2:0.##} GB)", receivedMB, totalSizeMB, totalSizeGB)}";
            progressBar1.Value = int.Parse(Math.Truncate(Percentage).ToString());
            progressBar1.Update();

            // Calcular la velocidad de descarga
            if (stopwatch.ElapsedMilliseconds > 1000) // Actualizar cada segundo
            {
                long bytesReceivedSinceLastUpdate = e.BytesReceived - lastBytesReceived;
                double speedInKBps = bytesReceivedSinceLastUpdate / 1024.0 / (stopwatch.ElapsedMilliseconds / 1000.0);
                string speedText;

                // Verificar si la velocidad debe mostrarse en MB/s o KB/s
                if (speedInKBps >= 1024)
                {
                    double speedInMBps = speedInKBps / 1024.0;
                    speedText = $"{string.Format("{0:0.##} MB/s", speedInMBps)}";
                }
                else
                {
                    speedText = $"{string.Format("{0:0.##} KB/s", speedInKBps)}";
                }

                lblVelocidad.Text = $"{speedText}";

                // Reiniciar el cronómetro y actualizar los bytes recibidos
                stopwatch.Restart();
                lastBytesReceived = e.BytesReceived;
            }
        }

        //GetResourceString("operatingS")
        private void RefreshUI()
        {
            btnCancel.Text = GetResourceString("btnCancel2");
            saveFileDialog1.Title = GetResourceString("saveFile");
            saveFileDialog1.Filter = GetResourceString("filter");
            lblDownSpeed.Text = GetResourceString("lblDownSpeed");
            lblDown.Text = GetResourceString("lblDown");
            Text = GetResourceString("downloaderTitle");
        }

        private string GetResourceString(string name)
        {
            return Properties.Resources.ResourceManager.GetString(name);
        }

        private void SetLanguage(string languageCode)
        {
            // Establecer la cultura global de la aplicación
            CultureInfo cultureInfo = new CultureInfo(languageCode);
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(GetResourceString("msgTitleDownload") +
                Environment.NewLine +
                Environment.NewLine +
                GetResourceString("msgTitleDownload2"), "WMC", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                foreach (Process proceso in Process.GetProcesses())
                {
                    if (proceso.ProcessName == "WMC")
                    {
                        proceso.Kill();
                    }
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            //if (httpDownloader.State == Status.Paused)
            //{ httpDownloader.Resume(); btnPause.Text = GetResourceString("btnPause"); }
            //else
            //{ httpDownloader.Pause(); btnPause.Text = GetResourceString("Resumen"); }
            
        }

        private void DownloadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(GetResourceString("msgTitleDownload") +
                Environment.NewLine +
                Environment.NewLine +
                GetResourceString("msgTitleDownload2"), "WMC", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                foreach (Process proceso in Process.GetProcesses())
                {
                    if (proceso.ProcessName == "WMC")
                    {
                        proceso.Kill();
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

    }
}
