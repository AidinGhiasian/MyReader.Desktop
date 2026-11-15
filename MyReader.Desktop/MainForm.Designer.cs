
namespace MyReader.Desktop
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            HeaderPanel = new Panel();
            lblSubtitle = new Label();
            lblAppName = new Label();

            MainPanel = new Panel();
            UploadPanel = new Panel();
            lblSupportedFormats = new Label();
            btnOpenFile = new Button();
            lblDescription = new Label();
            lblWelcome = new Label();

            StatusPanel = new Panel();
            label2 = new Label();

            RecentPanel = new Panel();
            lblRecentTitle = new Label();
            lblRecentDescription = new Label();

            HeaderPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            UploadPanel.SuspendLayout();
            StatusPanel.SuspendLayout();
            RecentPanel.SuspendLayout();
            SuspendLayout();

            // HeaderPanel
            HeaderPanel.BackColor = Color.FromArgb(17, 19, 24);
            HeaderPanel.Controls.Add(lblSubtitle);
            HeaderPanel.Controls.Add(lblAppName);
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.Location = new Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(1100, 80);
            HeaderPanel.TabIndex = 0;

            // lblSubtitle
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(145, 153, 165);
            lblSubtitle.Location = new Point(33, 53);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(173, 15);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "Your personal document reader";

            // lblAppName
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            lblAppName.ForeColor = Color.FromArgb(241, 243, 245);
            lblAppName.Location = new Point(30, 12);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(157, 40);
            lblAppName.TabIndex = 2;
            lblAppName.Text = "MyReader";

            // MainPanel
            MainPanel.BackColor = Color.FromArgb(17, 19, 24);
            MainPanel.Controls.Add(UploadPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(320, 80);
            MainPanel.Name = "MainPanel";
            MainPanel.Padding = new Padding(30);
            MainPanel.Size = new Size(780, 640);
            MainPanel.TabIndex = 1;

            // UploadPanel
            UploadPanel.Anchor = AnchorStyles.Top |AnchorStyles.Bottom |AnchorStyles.Left |AnchorStyles.Right;
            UploadPanel.BackColor = Color.FromArgb(27, 32, 41);
            UploadPanel.Controls.Add(lblSupportedFormats);
            UploadPanel.Controls.Add(btnOpenFile);
            UploadPanel.Controls.Add(lblDescription);
            UploadPanel.Controls.Add(lblWelcome);
            UploadPanel.Location = new Point(20, 20);
            UploadPanel.Name = "UploadPanel";
            UploadPanel.Size = new Size(740, 600);
            UploadPanel.TabIndex = 0;

            // lblSupportedFormats
            lblSupportedFormats.AutoSize = true;
            lblSupportedFormats.Font = new Font("Segoe UI", 9F);
            lblSupportedFormats.ForeColor = Color.FromArgb(145, 153, 165);
            lblSupportedFormats.Location = new Point(53, 365);
            lblSupportedFormats.Name = "lblSupportedFormats";
            lblSupportedFormats.Size = new Size(169, 15);
            lblSupportedFormats.TabIndex = 3;
            lblSupportedFormats.Text = "PDF · DOCX · TXT · EPUB · XLSX";

            // btnOpenFile
            btnOpenFile.BackColor = Color.FromArgb(67, 132, 102);
            btnOpenFile.Cursor = Cursors.Hand;
            btnOpenFile.FlatStyle = FlatStyle.Flat;
            btnOpenFile.FlatAppearance.BorderSize = 0;
            btnOpenFile.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnOpenFile.ForeColor = Color.White;
            btnOpenFile.Location = new Point(50, 290);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(230, 52);
            btnOpenFile.TabIndex = 2;
            btnOpenFile.Text = "Open a Document";
            btnOpenFile.UseVisualStyleBackColor = false;
            btnOpenFile.Click += btnOpenFile_Click;

            // lblDescription
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = Color.FromArgb(145, 153, 165);
            lblDescription.Location = new Point(42, 90);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(186, 19);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Choose a file to start reading";

            // lblWelcome
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(241, 243, 245);
            lblWelcome.Location = new Point(50, 145);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(311, 40);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to MyReader";

            // StatusPanel
            StatusPanel.BackColor = Color.FromArgb(17, 19, 24);
            StatusPanel.Controls.Add(label2);
            StatusPanel.Dock = DockStyle.Bottom;
            StatusPanel.Location = new Point(320, 720);
            StatusPanel.Name = "StatusPanel";
            StatusPanel.Size = new Size(780, 40);
            StatusPanel.TabIndex = 2;

            // label2
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(145, 153, 165);
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Ready";

            // RecentPanel
            RecentPanel.BackColor = Color.FromArgb(27, 32, 41);
            RecentPanel.Dock = DockStyle.Left;
            RecentPanel.Width = 320;
            RecentPanel.Padding = new Padding(25, 35, 20, 20);
            RecentPanel.Name = "RecentPanel";
            RecentPanel.Controls.Add(lblRecentDescription);
            RecentPanel.Controls.Add(lblRecentTitle);

            // lblRecentTitle
            lblRecentTitle.AutoSize = true;
            lblRecentTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblRecentTitle.ForeColor = Color.FromArgb(241, 243, 245);
            lblRecentTitle.Location = new Point(25, 35);
            lblRecentTitle.Name = "lblRecentTitle";
            lblRecentTitle.Text = "Recent";

            // lblRecentDescription
            lblRecentDescription.AutoSize = true;
            lblRecentDescription.Font = new Font("Segoe UI", 9F);
            lblRecentDescription.ForeColor = Color.FromArgb(145, 153, 165);
            lblDescription.Location = new Point(53, 205);
            lblRecentDescription.Name = "lblRecentDescription";
            lblDescription.Text = "Your documents. Beautifully organized.";


            // MainForm
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 19, 24);
            ClientSize = new Size(1100, 760);
            Controls.Add(StatusPanel);
            Controls.Add(MainPanel);
            Controls.Add(RecentPanel);
            Controls.Add(HeaderPanel);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(900, 600);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyReader";

            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            UploadPanel.ResumeLayout(false);
            UploadPanel.PerformLayout();
            StatusPanel.ResumeLayout(false);
            StatusPanel.PerformLayout();
            RecentPanel.ResumeLayout(false);
            RecentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel HeaderPanel;
        private Label lblAppName;
        private Label lblSubtitle;

        private Panel MainPanel;
        private Panel UploadPanel;
        private Label lblSupportedFormats;
        private Button btnOpenFile;
        private Label lblDescription;
        private Label lblWelcome;

        private Panel StatusPanel;
        private Label label2;

        private Panel RecentPanel;
        private Label lblRecentTitle;
        private Label lblRecentDescription;
    }
}
