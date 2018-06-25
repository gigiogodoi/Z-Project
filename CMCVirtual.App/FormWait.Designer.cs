namespace CMCVirtual.App
{
    partial class FormWait
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWait));
            this.LBLWait = new System.Windows.Forms.Label();
            this.GIFGears = new System.Windows.Forms.PictureBox();
            this.LBLMessage = new System.Windows.Forms.Label();
            this.BGLightBody = new System.Windows.Forms.Label();
            this.BGDarkBody = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GIFGears)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLWait
            // 
            this.LBLWait.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBLWait.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLWait.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LBLWait.Location = new System.Drawing.Point(19, 19);
            this.LBLWait.Margin = new System.Windows.Forms.Padding(10);
            this.LBLWait.Name = "LBLWait";
            this.LBLWait.Size = new System.Drawing.Size(746, 70);
            this.LBLWait.TabIndex = 1;
            this.LBLWait.Text = "A G U A R D E";
            this.LBLWait.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // GIFGears
            // 
            this.GIFGears.Image = ((System.Drawing.Image)(resources.GetObject("GIFGears.Image")));
            this.GIFGears.Location = new System.Drawing.Point(317, 271);
            this.GIFGears.Name = "GIFGears";
            this.GIFGears.Size = new System.Drawing.Size(150, 150);
            this.GIFGears.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GIFGears.TabIndex = 2;
            this.GIFGears.TabStop = false;
            // 
            // LBLMessage
            // 
            this.LBLMessage.BackColor = System.Drawing.SystemColors.Control;
            this.LBLMessage.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMessage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBLMessage.Location = new System.Drawing.Point(20, 109);
            this.LBLMessage.Margin = new System.Windows.Forms.Padding(10);
            this.LBLMessage.Name = "LBLMessage";
            this.LBLMessage.Size = new System.Drawing.Size(744, 149);
            this.LBLMessage.TabIndex = 4;
            this.LBLMessage.Text = "...";
            this.LBLMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BGLightBody
            // 
            this.BGLightBody.BackColor = System.Drawing.SystemColors.Control;
            this.BGLightBody.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGLightBody.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BGLightBody.Location = new System.Drawing.Point(20, 139);
            this.BGLightBody.Margin = new System.Windows.Forms.Padding(10);
            this.BGLightBody.Name = "BGLightBody";
            this.BGLightBody.Size = new System.Drawing.Size(744, 302);
            this.BGLightBody.TabIndex = 5;
            this.BGLightBody.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BGDarkBody
            // 
            this.BGDarkBody.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BGDarkBody.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGDarkBody.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BGDarkBody.Location = new System.Drawing.Point(19, 19);
            this.BGDarkBody.Margin = new System.Windows.Forms.Padding(10);
            this.BGDarkBody.Name = "BGDarkBody";
            this.BGDarkBody.Size = new System.Drawing.Size(746, 423);
            this.BGDarkBody.TabIndex = 6;
            this.BGDarkBody.Text = "A G U A R D E";
            this.BGDarkBody.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.GIFGears);
            this.Controls.Add(this.LBLMessage);
            this.Controls.Add(this.LBLWait);
            this.Controls.Add(this.BGLightBody);
            this.Controls.Add(this.BGDarkBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormWait";
            this.Shown += new System.EventHandler(this.FormWait_Shown);
            this.VisibleChanged += new System.EventHandler(this.FormWait_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.GIFGears)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBLWait;
        private System.Windows.Forms.PictureBox GIFGears;
        private System.Windows.Forms.Label LBLMessage;
        private System.Windows.Forms.Label BGLightBody;
        private System.Windows.Forms.Label BGDarkBody;
    }
}