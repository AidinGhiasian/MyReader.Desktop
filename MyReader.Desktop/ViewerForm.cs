using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Vml;
using System.Data;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace MyReader.Desktop
{
    public partial class ViewerForm : Form
    {
        public ViewerForm()
        {
            InitializeComponent();
            _ = InitializeDocumentViewerAsync();
            CenterDocumentPage();

            PageContainer.Resize += (s, e) => CenterDocumentPage();
        }

        private void DocumentPage_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CenterDocumentPage()
        {
            DocumentPage.Left = Math.Max(0, (PageContainer.ClientSize.Width - DocumentPage.Width) / 2);
            DocumentPage.Top = 20;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["MainForm"]?.Show();
        }
        public void SetFileName(string fileName)
        {
            lblFileName.Text = fileName;
        }
        private async Task InitializeDocumentViewerAsync()
        {
            await DocumentViewer.EnsureCoreWebView2Async();

            DocumentViewer.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            DocumentViewer.CoreWebView2.Settings.IsStatusBarEnabled = false;
        }
        public async Task LoadHtmlAsync(string html)
        {
            await DocumentViewer.EnsureCoreWebView2Async();
            DocumentViewer.DefaultBackgroundColor = Color.White;
            DocumentViewer.NavigateToString(
                """
        <!DOCTYPE html>
        <html>
        <body style="background:white; color:black; font-size:30px;">
            WebView2 Test
        </body>
        </html>
        """);
        }

        public async Task LoadTextAsync(byte[] content)
        {
            string text = Encoding.UTF8.GetString(content);
            string encodedText = WebUtility.HtmlEncode(text);

            string html = $$"""
        <!DOCTYPE html>
        <html>
        <head>
            <meta charset="UTF-8">
            <style>
                body {font - family: Arial, sans-serif;
                    font-size: 16px;
                    line-height: 1.8;
                    white-space: pre-wrap;
                    overflow-wrap: anywhere;
                    margin: 0;
                    padding: 20px;
                    color: #222;
                    background: white;
                }
            </style>
        </head>
        <body>{{encodedText}}</body>
        </html>
        """;

            await LoadHtmlAsync(html);
        }
    }
}
