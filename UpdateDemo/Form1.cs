using System.Net;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;
using System.Windows.Forms;

namespace UpdateDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            WebClient webClient = new WebClient();
            var client = new WebClient();

            try
            {
                System.Threading.Thread.Sleep(5000);
                File.Delete(@".\ResourceTest.exe");
                client.DownloadFile("https://github.com/KaizerHind/DemoResourceTest/releases/download/1.1/ResourceTest.zip", @"ResourceTest.zip");
                string zipPath = @".\ResourceTest.zip";
                string extractPath = @".\";
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                File.Delete(@".\ResourceTest.zip");
                Process.Start(@".\ResourceTest.exe");
            }
            catch
            {
                Process.Start("ResourceTest.exe");
            }
        }

    }
}
