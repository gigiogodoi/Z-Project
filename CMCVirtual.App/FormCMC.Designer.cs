namespace CMCVirtual.App
{
    partial class FormCMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCMC));
            this.TXTInputData = new System.Windows.Forms.TextBox();
            this.BGTitle = new System.Windows.Forms.Label();
            this.TXTLowerScreen = new System.Windows.Forms.TextBox();
            this.TXTUpperScreen = new System.Windows.Forms.TextBox();
            this.BTNScan = new System.Windows.Forms.Label();
            this.BGLogScreen = new System.Windows.Forms.Label();
            this.BGTextbox = new System.Windows.Forms.Label();
            this.LBLTitle = new System.Windows.Forms.Label();
            this.BTNException = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BTNException)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTInputData
            // 
            this.TXTInputData.BackColor = System.Drawing.SystemColors.Window;
            this.TXTInputData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTInputData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTInputData.Font = new System.Drawing.Font("Consolas", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTInputData.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TXTInputData.Location = new System.Drawing.Point(28, 101);
            this.TXTInputData.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.TXTInputData.Name = "TXTInputData";
            this.TXTInputData.Size = new System.Drawing.Size(450, 39);
            this.TXTInputData.TabIndex = 0;
            this.TXTInputData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTInputData_KeyDown);
            // 
            // BGTitle
            // 
            this.BGTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BGTitle.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BGTitle.Location = new System.Drawing.Point(19, 14);
            this.BGTitle.Margin = new System.Windows.Forms.Padding(10);
            this.BGTitle.Name = "BGTitle";
            this.BGTitle.Size = new System.Drawing.Size(746, 60);
            this.BGTitle.TabIndex = 7;
            this.BGTitle.Text = "station name";
            this.BGTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXTLowerScreen
            // 
            this.TXTLowerScreen.BackColor = System.Drawing.Color.DarkGreen;
            this.TXTLowerScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTLowerScreen.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTLowerScreen.ForeColor = System.Drawing.Color.Black;
            this.TXTLowerScreen.Location = new System.Drawing.Point(22, 379);
            this.TXTLowerScreen.Margin = new System.Windows.Forms.Padding(0);
            this.TXTLowerScreen.Multiline = true;
            this.TXTLowerScreen.Name = "TXTLowerScreen";
            this.TXTLowerScreen.ReadOnly = true;
            this.TXTLowerScreen.Size = new System.Drawing.Size(740, 60);
            this.TXTLowerScreen.TabIndex = 9;
            // 
            // TXTUpperScreen
            // 
            this.TXTUpperScreen.BackColor = System.Drawing.Color.DarkGreen;
            this.TXTUpperScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTUpperScreen.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTUpperScreen.ForeColor = System.Drawing.Color.Black;
            this.TXTUpperScreen.Location = new System.Drawing.Point(22, 168);
            this.TXTUpperScreen.Margin = new System.Windows.Forms.Padding(0);
            this.TXTUpperScreen.Multiline = true;
            this.TXTUpperScreen.Name = "TXTUpperScreen";
            this.TXTUpperScreen.ReadOnly = true;
            this.TXTUpperScreen.Size = new System.Drawing.Size(740, 211);
            this.TXTUpperScreen.TabIndex = 8;
            // 
            // BTNScan
            // 
            this.BTNScan.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTNScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNScan.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNScan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNScan.Location = new System.Drawing.Point(19, 99);
            this.BTNScan.Margin = new System.Windows.Forms.Padding(10);
            this.BTNScan.Name = "BTNScan";
            this.BTNScan.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.BTNScan.Size = new System.Drawing.Size(746, 44);
            this.BTNScan.TabIndex = 1;
            this.BTNScan.Text = "scan";
            this.BTNScan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNScan.Click += new System.EventHandler(this.BTNScan_Click);
            // 
            // BGLogScreen
            // 
            this.BGLogScreen.BackColor = System.Drawing.Color.Green;
            this.BGLogScreen.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGLogScreen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BGLogScreen.Location = new System.Drawing.Point(19, 165);
            this.BGLogScreen.Margin = new System.Windows.Forms.Padding(10);
            this.BGLogScreen.Name = "BGLogScreen";
            this.BGLogScreen.Size = new System.Drawing.Size(746, 277);
            this.BGLogScreen.TabIndex = 2;
            this.BGLogScreen.Text = "station name";
            this.BGLogScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BGTextbox
            // 
            this.BGTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.BGTextbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGTextbox.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGTextbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BGTextbox.Location = new System.Drawing.Point(20, 100);
            this.BGTextbox.Margin = new System.Windows.Forms.Padding(10);
            this.BGTextbox.Name = "BGTextbox";
            this.BGTextbox.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.BGTextbox.Size = new System.Drawing.Size(467, 42);
            this.BGTextbox.TabIndex = 14;
            this.BGTextbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBLTitle
            // 
            this.LBLTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LBLTitle.Font = new System.Drawing.Font("Consolas", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBLTitle.Location = new System.Drawing.Point(20, 15);
            this.LBLTitle.Margin = new System.Windows.Forms.Padding(10);
            this.LBLTitle.Name = "LBLTitle";
            this.LBLTitle.Size = new System.Drawing.Size(744, 58);
            this.LBLTitle.TabIndex = 15;
            this.LBLTitle.Text = "CMC VIRTUAL";
            this.LBLTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTNException
            // 
            this.BTNException.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNException.Image = ((System.Drawing.Image)(resources.GetObject("BTNException.Image")));
            this.BTNException.Location = new System.Drawing.Point(730, 34);
            this.BTNException.Name = "BTNException";
            this.BTNException.Size = new System.Drawing.Size(25, 20);
            this.BTNException.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTNException.TabIndex = 16;
            this.BTNException.TabStop = false;
            this.BTNException.Visible = false;
            this.BTNException.Click += new System.EventHandler(this.BTNException_Click);
            // 
            // FormCMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.BTNException);
            this.Controls.Add(this.LBLTitle);
            this.Controls.Add(this.TXTInputData);
            this.Controls.Add(this.BGTextbox);
            this.Controls.Add(this.BTNScan);
            this.Controls.Add(this.TXTLowerScreen);
            this.Controls.Add(this.TXTUpperScreen);
            this.Controls.Add(this.BGTitle);
            this.Controls.Add(this.BGLogScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormCMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                                 C M C   V I R T U A L";
            this.Shown += new System.EventHandler(this.FormCMC_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.BTNException)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTInputData;
        private System.Windows.Forms.Label BGTitle;
        private System.Windows.Forms.TextBox TXTLowerScreen;
        private System.Windows.Forms.TextBox TXTUpperScreen;
        private System.Windows.Forms.Label BTNScan;
        private System.Windows.Forms.Label BGLogScreen;
        private System.Windows.Forms.Label BGTextbox;
        private System.Windows.Forms.Label LBLTitle;
        private System.Windows.Forms.PictureBox BTNException;
    }
}

