namespace CMCVirtual.App
{
    partial class FormException
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormException));
            this.LBLTitle = new System.Windows.Forms.Label();
            this.LBLMessage = new System.Windows.Forms.Label();
            this.TXTMessage = new System.Windows.Forms.TextBox();
            this.LBLStackTrace = new System.Windows.Forms.Label();
            this.TXTStackTrace = new System.Windows.Forms.TextBox();
            this.BTNDownloadLog = new System.Windows.Forms.PictureBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BTNDownloadLog)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLTitle
            // 
            this.LBLTitle.BackColor = System.Drawing.Color.DarkRed;
            this.LBLTitle.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.LBLTitle.Location = new System.Drawing.Point(0, 0);
            this.LBLTitle.Name = "LBLTitle";
            this.LBLTitle.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.LBLTitle.Size = new System.Drawing.Size(484, 361);
            this.LBLTitle.TabIndex = 0;
            this.LBLTitle.Text = "...[ EXCEPTION ]...";
            this.LBLTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBLMessage
            // 
            this.LBLMessage.BackColor = System.Drawing.Color.DarkRed;
            this.LBLMessage.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMessage.ForeColor = System.Drawing.SystemColors.Window;
            this.LBLMessage.Location = new System.Drawing.Point(12, 79);
            this.LBLMessage.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.LBLMessage.Name = "LBLMessage";
            this.LBLMessage.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LBLMessage.Size = new System.Drawing.Size(460, 100);
            this.LBLMessage.TabIndex = 1;
            this.LBLMessage.Text = "[ Message ]";
            // 
            // TXTMessage
            // 
            this.TXTMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTMessage.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTMessage.Location = new System.Drawing.Point(12, 114);
            this.TXTMessage.Multiline = true;
            this.TXTMessage.Name = "TXTMessage";
            this.TXTMessage.ReadOnly = true;
            this.TXTMessage.Size = new System.Drawing.Size(460, 40);
            this.TXTMessage.TabIndex = 1;
            // 
            // LBLStackTrace
            // 
            this.LBLStackTrace.BackColor = System.Drawing.Color.DarkRed;
            this.LBLStackTrace.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLStackTrace.ForeColor = System.Drawing.SystemColors.Window;
            this.LBLStackTrace.Location = new System.Drawing.Point(12, 177);
            this.LBLStackTrace.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.LBLStackTrace.Name = "LBLStackTrace";
            this.LBLStackTrace.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LBLStackTrace.Size = new System.Drawing.Size(460, 175);
            this.LBLStackTrace.TabIndex = 3;
            this.LBLStackTrace.Text = "[ Stack Trace ]";
            // 
            // TXTStackTrace
            // 
            this.TXTStackTrace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTStackTrace.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTStackTrace.Location = new System.Drawing.Point(12, 212);
            this.TXTStackTrace.Multiline = true;
            this.TXTStackTrace.Name = "TXTStackTrace";
            this.TXTStackTrace.ReadOnly = true;
            this.TXTStackTrace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TXTStackTrace.Size = new System.Drawing.Size(460, 137);
            this.TXTStackTrace.TabIndex = 2;
            this.TXTStackTrace.WordWrap = false;
            // 
            // BTNDownloadLog
            // 
            this.BTNDownloadLog.BackColor = System.Drawing.Color.Transparent;
            this.BTNDownloadLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNDownloadLog.Image = ((System.Drawing.Image)(resources.GetObject("BTNDownloadLog.Image")));
            this.BTNDownloadLog.Location = new System.Drawing.Point(442, 122);
            this.BTNDownloadLog.Name = "BTNDownloadLog";
            this.BTNDownloadLog.Size = new System.Drawing.Size(25, 25);
            this.BTNDownloadLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTNDownloadLog.TabIndex = 4;
            this.BTNDownloadLog.TabStop = false;
            this.BTNDownloadLog.Click += new System.EventHandler(this.BTNDownloadLog_Click);
            // 
            // ToolTip
            // 
            this.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // FormException
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.BTNDownloadLog);
            this.Controls.Add(this.TXTStackTrace);
            this.Controls.Add(this.LBLStackTrace);
            this.Controls.Add(this.TXTMessage);
            this.Controls.Add(this.LBLMessage);
            this.Controls.Add(this.LBLTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormException";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "                                                               C M C   V I R T U " +
    "A L";
            this.Shown += new System.EventHandler(this.FormException_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.BTNDownloadLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLTitle;
        private System.Windows.Forms.Label LBLMessage;
        private System.Windows.Forms.TextBox TXTMessage;
        private System.Windows.Forms.Label LBLStackTrace;
        private System.Windows.Forms.TextBox TXTStackTrace;
        private System.Windows.Forms.PictureBox BTNDownloadLog;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}