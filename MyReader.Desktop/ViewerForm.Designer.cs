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
            TopPanel = new Panel();
            lblFileName = new Label();
            MainPanel.SuspendLayout();
            ViewerPanel.SuspendLayout();
            DocumentPanel.SuspendLayout();
            PageContainer.SuspendLayout();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
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
            ViewerPanel.BackColor = Color.Gainsboro;
            ViewerPanel.Controls.Add(DocumentPanel);
            ViewerPanel.Dock = DockStyle.Fill;
            ViewerPanel.Location = new Point(0, 60);
            ViewerPanel.Name = "ViewerPanel";
            ViewerPanel.Size = new Size(1184, 701);
            ViewerPanel.TabIndex = 2;
            // 
            // DocumentPanel
            // 
            DocumentPanel.BackColor = Color.White;
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
            PageContainer.BackColor = Color.WhiteSmoke;
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
            DocumentPage.BackColor = Color.White;
            DocumentPage.BorderStyle = BorderStyle.FixedSingle;
            DocumentPage.Location = new Point(415, 242);
            DocumentPage.Margin = new Padding(20);
            DocumentPage.Name = "DocumentPage";
            DocumentPage.Padding = new Padding(40);
            DocumentPage.Size = new Size(794, 1123);
            DocumentPage.TabIndex = 0;
            DocumentPage.Paint += DocumentPage_Paint;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.White;
            TopPanel.Controls.Add(lblFileName);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1184, 60);
            TopPanel.TabIndex = 1;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(390, 21);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(88, 15);
            lblFileName.TabIndex = 0;
            lblFileName.Text = "No file selected";
            // 
            // ViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1184, 761);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(900, 600);
            Name = "ViewerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyReader - Viewer";
            WindowState = FormWindowState.Maximized;
            MainPanel.ResumeLayout(false);
            ViewerPanel.ResumeLayout(false);
            DocumentPanel.ResumeLayout(false);
            PageContainer.ResumeLayout(false);
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
    }
}