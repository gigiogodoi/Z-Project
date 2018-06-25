namespace CMCVirtual.App
{
    partial class FormSetStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetStation));
            this.LBLTitle = new System.Windows.Forms.Label();
            this.LBLHost = new System.Windows.Forms.Label();
            this.LBLStation = new System.Windows.Forms.Label();
            this.LBLLogin = new System.Windows.Forms.Label();
            this.LBLPassword = new System.Windows.Forms.Label();
            this.TXTPassword = new System.Windows.Forms.TextBox();
            this.BGPassword = new System.Windows.Forms.Label();
            this.BGLogin = new System.Windows.Forms.Label();
            this.TXTLogin = new System.Windows.Forms.TextBox();
            this.CMBHost = new System.Windows.Forms.ComboBox();
            this.CMBStation = new System.Windows.Forms.ComboBox();
            this.BTNCancel = new System.Windows.Forms.Button();
            this.BGStation = new System.Windows.Forms.Label();
            this.BGHost = new System.Windows.Forms.Label();
            this.BTNConfirm = new System.Windows.Forms.Button();
            this.PNLBase = new System.Windows.Forms.Panel();
            this.BTNException = new System.Windows.Forms.PictureBox();
            this.PNLBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTNException)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLTitle
            // 
            this.LBLTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBLTitle.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTitle.Location = new System.Drawing.Point(19, 18);
            this.LBLTitle.Margin = new System.Windows.Forms.Padding(10);
            this.LBLTitle.Name = "LBLTitle";
            this.LBLTitle.Size = new System.Drawing.Size(446, 70);
            this.LBLTitle.TabIndex = 0;
            this.LBLTitle.Text = "SELECIONE ESTAÇÃO";
            this.LBLTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLHost
            // 
            this.LBLHost.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBLHost.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLHost.Location = new System.Drawing.Point(19, 141);
            this.LBLHost.Margin = new System.Windows.Forms.Padding(10);
            this.LBLHost.Name = "LBLHost";
            this.LBLHost.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LBLHost.Size = new System.Drawing.Size(446, 50);
            this.LBLHost.TabIndex = 1;
            this.LBLHost.Text = "Host";
            this.LBLHost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBLStation
            // 
            this.LBLStation.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBLStation.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLStation.Location = new System.Drawing.Point(19, 211);
            this.LBLStation.Margin = new System.Windows.Forms.Padding(10);
            this.LBLStation.Name = "LBLStation";
            this.LBLStation.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LBLStation.Size = new System.Drawing.Size(446, 50);
            this.LBLStation.TabIndex = 2;
            this.LBLStation.Text = "Estação";
            this.LBLStation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBLLogin
            // 
            this.LBLLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBLLogin.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLLogin.Location = new System.Drawing.Point(19, 281);
            this.LBLLogin.Margin = new System.Windows.Forms.Padding(10);
            this.LBLLogin.Name = "LBLLogin";
            this.LBLLogin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LBLLogin.Size = new System.Drawing.Size(446, 50);
            this.LBLLogin.TabIndex = 3;
            this.LBLLogin.Text = "Login";
            this.LBLLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBLPassword
            // 
            this.LBLPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBLPassword.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPassword.Location = new System.Drawing.Point(19, 351);
            this.LBLPassword.Margin = new System.Windows.Forms.Padding(10);
            this.LBLPassword.Name = "LBLPassword";
            this.LBLPassword.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LBLPassword.Size = new System.Drawing.Size(446, 50);
            this.LBLPassword.TabIndex = 4;
            this.LBLPassword.Text = "Senha";
            this.LBLPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TXTPassword
            // 
            this.TXTPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTPassword.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPassword.Location = new System.Drawing.Point(167, 360);
            this.TXTPassword.MaxLength = 50;
            this.TXTPassword.Name = "TXTPassword";
            this.TXTPassword.PasswordChar = '*';
            this.TXTPassword.Size = new System.Drawing.Size(295, 32);
            this.TXTPassword.TabIndex = 3;
            // 
            // BGPassword
            // 
            this.BGPassword.BackColor = System.Drawing.SystemColors.Window;
            this.BGPassword.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGPassword.Location = new System.Drawing.Point(164, 352);
            this.BGPassword.Margin = new System.Windows.Forms.Padding(10);
            this.BGPassword.Name = "BGPassword";
            this.BGPassword.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BGPassword.Size = new System.Drawing.Size(300, 48);
            this.BGPassword.TabIndex = 6;
            this.BGPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BGLogin
            // 
            this.BGLogin.BackColor = System.Drawing.SystemColors.Window;
            this.BGLogin.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGLogin.Location = new System.Drawing.Point(164, 282);
            this.BGLogin.Margin = new System.Windows.Forms.Padding(10);
            this.BGLogin.Name = "BGLogin";
            this.BGLogin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BGLogin.Size = new System.Drawing.Size(300, 48);
            this.BGLogin.TabIndex = 7;
            this.BGLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TXTLogin
            // 
            this.TXTLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTLogin.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTLogin.Location = new System.Drawing.Point(167, 290);
            this.TXTLogin.MaxLength = 50;
            this.TXTLogin.Name = "TXTLogin";
            this.TXTLogin.Size = new System.Drawing.Size(295, 32);
            this.TXTLogin.TabIndex = 2;
            // 
            // CMBHost
            // 
            this.CMBHost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBHost.Font = new System.Drawing.Font("Consolas", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBHost.FormattingEnabled = true;
            this.CMBHost.Location = new System.Drawing.Point(165, 143);
            this.CMBHost.Name = "CMBHost";
            this.CMBHost.Size = new System.Drawing.Size(298, 46);
            this.CMBHost.TabIndex = 0;
            this.CMBHost.SelectedIndexChanged += new System.EventHandler(this.CMBHost_SelectedIndexChanged);
            // 
            // CMBStation
            // 
            this.CMBStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBStation.Font = new System.Drawing.Font("Consolas", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBStation.FormattingEnabled = true;
            this.CMBStation.Location = new System.Drawing.Point(165, 213);
            this.CMBStation.Name = "CMBStation";
            this.CMBStation.Size = new System.Drawing.Size(298, 46);
            this.CMBStation.TabIndex = 1;
            this.CMBStation.SelectedIndexChanged += new System.EventHandler(this.CMBStation_SelectedIndexChanged);
            // 
            // BTNCancel
            // 
            this.BTNCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTNCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNCancel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCancel.Location = new System.Drawing.Point(19, 447);
            this.BTNCancel.Margin = new System.Windows.Forms.Padding(10);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(200, 44);
            this.BTNCancel.TabIndex = 1;
            this.BTNCancel.Text = "Cancelar";
            this.BTNCancel.UseVisualStyleBackColor = false;
            // 
            // BGStation
            // 
            this.BGStation.BackColor = System.Drawing.SystemColors.Window;
            this.BGStation.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGStation.Location = new System.Drawing.Point(164, 212);
            this.BGStation.Margin = new System.Windows.Forms.Padding(10);
            this.BGStation.Name = "BGStation";
            this.BGStation.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BGStation.Size = new System.Drawing.Size(300, 48);
            this.BGStation.TabIndex = 16;
            this.BGStation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BGHost
            // 
            this.BGHost.BackColor = System.Drawing.SystemColors.Window;
            this.BGHost.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGHost.Location = new System.Drawing.Point(164, 142);
            this.BGHost.Margin = new System.Windows.Forms.Padding(10);
            this.BGHost.Name = "BGHost";
            this.BGHost.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BGHost.Size = new System.Drawing.Size(300, 48);
            this.BGHost.TabIndex = 17;
            this.BGHost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BTNConfirm
            // 
            this.BTNConfirm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTNConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTNConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNConfirm.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNConfirm.Location = new System.Drawing.Point(265, 447);
            this.BTNConfirm.Name = "BTNConfirm";
            this.BTNConfirm.Size = new System.Drawing.Size(200, 44);
            this.BTNConfirm.TabIndex = 0;
            this.BTNConfirm.Text = "Confirmar";
            this.BTNConfirm.UseVisualStyleBackColor = false;
            this.BTNConfirm.Click += new System.EventHandler(this.BTNConfirm_Click);
            // 
            // PNLBase
            // 
            this.PNLBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNLBase.Controls.Add(this.BTNException);
            this.PNLBase.Controls.Add(this.BTNConfirm);
            this.PNLBase.Controls.Add(this.LBLTitle);
            this.PNLBase.Controls.Add(this.BTNCancel);
            this.PNLBase.Location = new System.Drawing.Point(1, 1);
            this.PNLBase.Name = "PNLBase";
            this.PNLBase.Size = new System.Drawing.Size(482, 509);
            this.PNLBase.TabIndex = 19;
            // 
            // BTNException
            // 
            this.BTNException.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNException.Image = ((System.Drawing.Image)(resources.GetObject("BTNException.Image")));
            this.BTNException.Location = new System.Drawing.Point(440, 101);
            this.BTNException.Name = "BTNException";
            this.BTNException.Size = new System.Drawing.Size(25, 20);
            this.BTNException.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTNException.TabIndex = 17;
            this.BTNException.TabStop = false;
            this.BTNException.Visible = false;
            this.BTNException.Click += new System.EventHandler(this.BTNException_Click);
            // 
            // FormSetStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.ControlBox = false;
            this.Controls.Add(this.CMBHost);
            this.Controls.Add(this.BGHost);
            this.Controls.Add(this.CMBStation);
            this.Controls.Add(this.BGStation);
            this.Controls.Add(this.TXTLogin);
            this.Controls.Add(this.BGLogin);
            this.Controls.Add(this.TXTPassword);
            this.Controls.Add(this.BGPassword);
            this.Controls.Add(this.LBLPassword);
            this.Controls.Add(this.LBLLogin);
            this.Controls.Add(this.LBLStation);
            this.Controls.Add(this.LBLHost);
            this.Controls.Add(this.PNLBase);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSetStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "                                                            C M C   V I R T U A L" +
    "";
            this.Shown += new System.EventHandler(this.FormSetStation_Shown);
            this.PNLBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BTNException)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLTitle;
        private System.Windows.Forms.Label LBLHost;
        private System.Windows.Forms.Label LBLStation;
        private System.Windows.Forms.Label LBLLogin;
        private System.Windows.Forms.Label LBLPassword;
        private System.Windows.Forms.TextBox TXTPassword;
        private System.Windows.Forms.Label BGPassword;
        private System.Windows.Forms.Label BGLogin;
        private System.Windows.Forms.TextBox TXTLogin;
        private System.Windows.Forms.ComboBox CMBHost;
        private System.Windows.Forms.ComboBox CMBStation;
        private System.Windows.Forms.Button BTNCancel;
        private System.Windows.Forms.Label BGStation;
        private System.Windows.Forms.Label BGHost;
        private System.Windows.Forms.Button BTNConfirm;
        private System.Windows.Forms.Panel PNLBase;
        private System.Windows.Forms.PictureBox BTNException;
    }
}