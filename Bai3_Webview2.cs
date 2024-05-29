using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace _22520853_Lab04
{
    public partial class Bai3_Webview2 : Form
    {
        public Bai3_Webview2()
        {
            InitializeComponent();
        }

        private async void Bai3_Webview2_Load(object sender, EventArgs e)
        {
            await InitBrowser();
        }

        private async Task InitBrowser()
        {
            try
            {
                string userDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyWebView2App");
                var env = await CoreWebView2Environment.CreateAsync(null, userDataFolder);
                await webView.EnsureCoreWebView2Async(env);
                if (webView.CoreWebView2 != null)
                {
                    webView.CoreWebView2.Navigate("https://www.youtube.com");
                }
                else
                {
                    MessageBox.Show("WebView2 initialization failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
