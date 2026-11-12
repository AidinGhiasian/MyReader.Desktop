namespace MyReader.Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
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
            HeaderPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            UploadPanel.SuspendLayout();
            StatusPanel.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = Color.White;
            HeaderPanel.Controls.Add(lblSubtitle);
            HeaderPanel.Controls.Add(lblAppName);
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.Location = new Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(684, 90);
            HeaderPanel.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(125, 135, 150);
            lblSubtitle.Location = new Point(33, 53);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(173, 15);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "\tYour personal document reader";
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.FromArgb(35, 45, 65);
            lblAppName.Location = new Point(30, 12);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(157, 40);
            lblAppName.TabIndex = 2;
            lblAppName.Text = "MyReader";
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(UploadPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 90);
            MainPanel.Name = "MainPanel";
            MainPanel.Padding = new Padding(35);
            MainPanel.Size = new Size(684, 771);
            MainPanel.TabIndex = 1;
            // 
            // UploadPanel
            // 
            UploadPanel.Anchor = AnchorStyles.None;
            UploadPanel.BackColor = Color.White;
            UploadPanel.Controls.Add(lblSupportedFormats);
            UploadPanel.Controls.Add(btnOpenFile);
            UploadPanel.Controls.Add(lblDescription);
            UploadPanel.Controls.Add(lblWelcome);
            UploadPanel.Location = new Point(8, 27);
            UploadPanel.Name = "UploadPanel";
            UploadPanel.Size = new Size(650, 300);
            UploadPanel.TabIndex = 0;
            // 
            // lblSupportedFormats
            // 
            lblSupportedFormats.AutoSize = true;
            lblSupportedFormats.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupportedFormats.ForeColor = Color.FromArgb(145, 150, 160);
            lblSupportedFormats.Location = new Point(42, 225);
            lblSupportedFormats.Name = "lblSupportedFormats";
            lblSupportedFormats.Size = new Size(169, 15);
            lblSupportedFormats.TabIndex = 3;
            lblSupportedFormats.Text = "PDF · DOCX · TXT · EPUB · XLSX";
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = Color.RoyalBlue;
            btnOpenFile.Cursor = Cursors.Hand;
            btnOpenFile.FlatStyle = FlatStyle.Flat;
            btnOpenFile.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenFile.ForeColor = Color.White;
            btnOpenFile.Location = new Point(40, 155);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(180, 48);
            btnOpenFile.TabIndex = 2;
            btnOpenFile.Text = "Choose File";
            btnOpenFile.UseVisualStyleBackColor = false;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = Color.FromArgb(125, 135, 150);
            lblDescription.Location = new Point(42, 90);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(186, 19);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Choose a file to start reading";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(35, 45, 65);
            lblWelcome.Location = new Point(35, 40);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(311, 40);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Open your document";
            // 
            // StatusPanel
            // 
            StatusPanel.BackColor = Color.White;
            StatusPanel.Controls.Add(label2);
            StatusPanel.Dock = DockStyle.Bottom;
            StatusPanel.Location = new Point(0, 821);
            StatusPanel.Name = "StatusPanel";
            StatusPanel.Size = new Size(684, 40);
            StatusPanel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(125, 135, 150);
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Ready";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(684, 861);
            Controls.Add(StatusPanel);
            Controls.Add(MainPanel);
            Controls.Add(HeaderPanel);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(600, 900);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyReader";
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            UploadPanel.ResumeLayout(false);
            UploadPanel.PerformLayout();
            StatusPanel.ResumeLayout(false);
            StatusPanel.PerformLayout();
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
    }
}
