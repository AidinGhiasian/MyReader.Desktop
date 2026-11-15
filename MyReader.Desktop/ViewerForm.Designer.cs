namespace MyReader.Desktop
{
    partial class ViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainPanel = new Panel();
            ViewerPanel = new Panel();
            DocumentPanel = new Panel();
            PageContainer = new Panel();
            DocumentPage = new Panel();
            DocumentViewer = new Microsoft.Web.WebView2.WinForms.WebView2();
            TopPanel = new Panel();
            btnHome = new Button();
            lblFileName = new Label();
            MainPanel.SuspendLayout();
            ViewerPanel.SuspendLayout();
            DocumentPanel.SuspendLayout();
            PageContainer.SuspendLayout();
            DocumentPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DocumentViewer).BeginInit();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(17, 19, 24);
            MainPanel.Controls.Add(ViewerPanel);
            MainPanel.Controls.Add(TopPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1184, 761);
            MainPanel.TabIndex = 0;
            // 
            // ViewerPanel
            // 
            ViewerPanel.BackColor = Color.FromArgb(17, 19, 24);
            ViewerPanel.Controls.Add(DocumentPanel);
            ViewerPanel.Dock = DockStyle.Fill;
            ViewerPanel.Location = new Point(0, 60);
            ViewerPanel.Name = "ViewerPanel";
            ViewerPanel.Size = new Size(1184, 701);
            ViewerPanel.TabIndex = 2;
            // 
            // DocumentPanel
            // 
            DocumentPanel.BackColor = Color.FromArgb(17, 19, 24);
            DocumentPanel.Controls.Add(PageContainer);
            DocumentPanel.Dock = DockStyle.Fill;
            DocumentPanel.Location = new Point(0, 0);
            DocumentPanel.Name = "DocumentPanel";
            DocumentPanel.Padding = new Padding(20);
            DocumentPanel.Size = new Size(1184, 701);
            DocumentPanel.TabIndex = 0;
            // 
            // PageContainer
            // 
            PageContainer.AutoScroll = true;
            PageContainer.BackColor = Color.FromArgb(17, 19, 24);
            PageContainer.Controls.Add(DocumentPage);
            PageContainer.Dock = DockStyle.Fill;
            PageContainer.Location = new Point(20, 20);
            PageContainer.Name = "PageContainer";
            PageContainer.Size = new Size(1144, 661);
            PageContainer.TabIndex = 0;
            // 
            // DocumentPage
            // 
            DocumentPage.Anchor = AnchorStyles.Top;
            DocumentPage.BackColor = Color.FromArgb(17, 19, 24);
            DocumentPage.Controls.Add(DocumentViewer);
            DocumentPage.Location = new Point(415, 242);
            DocumentPage.Margin = new Padding(20);
            DocumentPage.Name = "DocumentPage";
            DocumentPage.Size = new Size(794, 1123);
            DocumentPage.TabIndex = 0;
            DocumentPage.Paint += DocumentPage_Paint;
            // 
            // DocumentViewer
            // 
            DocumentViewer.AllowExternalDrop = true;
            DocumentViewer.CreationProperties = null;
            DocumentViewer.DefaultBackgroundColor = Color.White;
            DocumentViewer.Dock = DockStyle.Fill;
            DocumentViewer.Location = new Point(0, 0);
            DocumentViewer.Name = "DocumentViewer";
            DocumentViewer.Size = new Size(794, 1123);
            DocumentViewer.TabIndex = 0;
            DocumentViewer.ZoomFactor = 1D;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(17, 19, 24);
            TopPanel.Controls.Add(btnHome);
            TopPanel.Controls.Add(lblFileName);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1184, 60);
            TopPanel.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHome.BackColor = Color.FromArgb(27, 32, 41);
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe MDL2 Assets", 18F);
            btnHome.ForeColor = Color.FromArgb(241, 243, 245);
            btnHome.Location = new Point(1120, 8);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(44, 44);
            btnHome.TabIndex = 1;
            btnHome.Text = "⌂";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // lblFileName
            // 
            lblFileName.Anchor = AnchorStyles.Top;
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(450, 21);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(88, 15);
            lblFileName.TabIndex = 0;
            lblFileName.Text = "No file selected";
            lblFileName.TextAlign = ContentAlignment.MiddleCenter;
            lblFileName.Visible = false;
            // 
            // ViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1184, 761);
            Controls.Add(MainPanel);
            MinimumSize = new Size(900, 600);
            Name = "ViewerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyReader - Viewer";
            WindowState = FormWindowState.Maximized;
            MainPanel.ResumeLayout(false);
            ViewerPanel.ResumeLayout(false);
            DocumentPanel.ResumeLayout(false);
            PageContainer.ResumeLayout(false);
            DocumentPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DocumentViewer).EndInit();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel ViewerPanel;
        private Panel TopPanel;
        private Label lblFileName;
        private Panel DocumentPanel;
        private Panel PageContainer;
        private Panel DocumentPage;
        private Button btnHome;
        private Microsoft.Web.WebView2.WinForms.WebView2 DocumentViewer;
    }
}