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

            var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if(mainForm != null)
            {
                mainForm.Show();
                mainForm.Activate();
            }
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
            DocumentViewer.DefaultBackgroundColor = Color.FromArgb(17, 19, 24);
            DocumentViewer.NavigateToString(html);
        }
        public async Task LoadTextAsync(byte[] content)
        {
            string text = Encoding.UTF8.GetString(content);
            DocumentPanel.Padding = Padding.Empty;
            PageContainer.Padding = Padding.Empty;
            DocumentPage.Dock = DockStyle.Fill;
            DocumentPage.Margin = Padding.Empty;

            string encodedText = WebUtility.HtmlEncode(text);

            string html = $$"""
        <!DOCTYPE html>
        <html>
        <head>
            <meta charset="UTF-8">
        <style>
            body {
                width: 100%;
                min-height: 100vh;
                margin: 0;
                background: #111318;
                color: #f1f3f5;
                font-family: "Segoe UI", Tahoma, sans-serif;
                -webkit-font-smoothing: antialiased;
            }

            #textContainer {
                width: min(100%, 1050px);
                min-height: 100vh;
                margin: 0 auto;
                padding: clamp(32px, 5vw, 64px) clamp(20px, 5vw, 72px);
                font-size: 17px;
                line-height: 2;
                white-space: pre-wrap;
                overflow-wrap: anywhere;
                word-break: normal;
                text-align: start;
                unicode-bidi: plaintext;
                box-sizing: border-box;
            }
        </style>
        </head>
        <body>
            <div id="textContainer">{{encodedText}}</div>
        </body>
        </html>
        """;

            await LoadHtmlAsync(html);
        }
    }
}
