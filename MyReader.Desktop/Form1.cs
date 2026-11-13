
using MR.Application.Contracts.Readers;
using Services.Application;

namespace MyReader.Desktop
{
    public partial class Form1 : Form
    {
        private readonly IDocumentReadingService _documentReadingService;

        public Form1(IDocumentReadingService documentReadingService)
        {
            InitializeComponent();

            _documentReadingService = documentReadingService;
        }

        private async void btnOpenFile_Click(object? sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Select a Document";

            openFileDialog.Filter =
                "Supported Documents|*.pdf;*.docx;*.txt;*.epub;*.xlsx|" +
                "PDF Files|*.pdf|" +
                "Word Documents|*.docx|" +
                "Text Files|*.txt|" +
                "EPUB Books|*.epub|" +
                "Excel Files|*.xlsx";

            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using FileStream fileStream = File.OpenRead(openFileDialog.FileName);

                var result = await _documentReadingService.ProcessAsync(
                    fileStream,
                    Path.GetFileName(openFileDialog.FileName));

                if (result == null)
                {
                    MessageBox.Show(
                        ApplicationMessage.NotFound,
                        "Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                MessageBox.Show(
                    $"File loaded successfully!\n\n" +
                    $"Name: {result.FileName}\n" +
                    $"Content Type: {result.ContentType}\n" +
                    $"Size: {result.Content.Length:N0} bytes",
                    "MyReader",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "MyReader - Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CenterDocumentPage()
        {
            DocumentPage.Left = Math.Max(0, (PageContainer.ClientSize.Width - DocumentPage.Width) / 2);
            DocumentPage.Top = 20;
        }
    }
}
