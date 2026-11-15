
using MR.Application.Contracts.Readers;
using Services.Application;
using System.Drawing.Drawing2D;

namespace MyReader.Desktop
{
    public partial class MainForm : Form
    {
        private readonly ViewerForm _viewerForm;
        private readonly IDocumentReadingService _documentReadingService;

        public MainForm(IDocumentReadingService documentReadingService, ViewerForm viewerForm)
        {
            InitializeComponent();
            SetRoundedRegion(UploadPanel, 20);
            SetRoundedRegion(btnOpenFile, 12);
            _viewerForm = viewerForm;
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
                if (result.ContentType == "text/plain")
                {
                    await _viewerForm.LoadTextAsync(result.Content);
                }else
                {
                    MessageBox.Show("Currently, only TXT files are supported.");
                }
                _viewerForm.SetFileName(result.FileName);
                _viewerForm.Show();
                this.Hide();
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
        private void SetRoundedRegion(Control control, int radius)
        {
            Rectangle bounds = new Rectangle(0, 0, control.Width, control.Height);

            using GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }

    }
}
