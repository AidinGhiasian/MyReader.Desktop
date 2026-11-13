using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyReader.Desktop
{
    public partial class ViewerForm : Form
    {
        public ViewerForm()
        {
            InitializeComponent();
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
    }
}
