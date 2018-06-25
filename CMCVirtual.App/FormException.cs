using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMCVirtual.App
{
    public partial class FormException : Form
    {
        public FormException(Exception e)
        {
            InitializeComponent();

            TXTMessage.Text    = e.Message;
            TXTStackTrace.Text = e.StackTrace;
            ToolTip.SetToolTip(BTNDownloadLog, " Download do Log");
        }

        private void FormException_Shown(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void BTNDownloadLog_Click(object sender, EventArgs e)
        {
            var Dlg = new SaveFileDialog()
            { 
                DefaultExt = "log",
                FileName   = string.Format("{0}-CMCVirtual", DateTime.Now.ToString("yyyyMMdd"))
            };
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                var sbData = new StringBuilder();
                sbData.AppendLine("Message");
                sbData.AppendLine(TXTMessage.Text);
                sbData.Append(Environment.NewLine);
                sbData.AppendLine("StackTrace");
                sbData.AppendLine(TXTStackTrace.Text);
                File.WriteAllText(Dlg.FileName, sbData.ToString());
            }
        }
    }
}
