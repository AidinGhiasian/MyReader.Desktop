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
            DocumentViewer.CoreWebView2.Settings.IsStatusBarEnabled= false;
        }
        public async Task LoadHtmlAsync(string html)
        {
            await DocumentViewer.EnsureCoreWebView2Async();
            DocumentViewer.NavigateToString(html);
        }
    }
}
