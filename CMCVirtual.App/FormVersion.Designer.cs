namespace CMCVirtual.App
{
    partial class FormVersion
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
            this.PNLBase = new System.Windows.Forms.Panel();
            this.LSTVersions = new System.Windows.Forms.ListView();
            this.LBLTitle = new System.Windows.Forms.Label();
            this.PNLBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNLBase
            // 
            this.PNLBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNLBase.Controls.Add(this.LSTVersions);
            this.PNLBase.Controls.Add(this.LBLTitle);
            this.PNLBase.Location = new System.Drawing.Point(0, 1);
            this.PNLBase.Name = "PNLBase";
            this.PNLBase.Size = new System.Drawing.Size(584, 285);
            this.PNLBase.TabIndex = 20;
            // 
            // LSTVersions
            // 
            this.LSTVersions.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSTVersions.Location = new System.Drawing.Point(10, 101);
            this.LSTVersions.Name = "LSTVersions";
            this.LSTVersions.Size = new System.Drawing.Size(561, 167);
            this.LSTVersions.TabIndex = 1;
            this.LSTVersions.UseCompatibleStateImageBehavior = false;
            this.LSTVersions.View = System.Windows.Forms.View.List;
            // 
            // LBLTitle
            // 
            this.LBLTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBLTitle.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LBLTitle.Location = new System.Drawing.Point(10, 10);
            this.LBLTitle.Margin = new System.Windows.Forms.Padding(10);
            this.LBLTitle.Name = "LBLTitle";
            this.LBLTitle.Size = new System.Drawing.Size(561, 70);
            this.LBLTitle.TabIndex = 0;
            this.LBLTitle.Text = "APP VERSIONS";
            this.LBLTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(584, 286);
            this.Controls.Add(this.PNLBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormVersion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "                                                                                C" +
    " M C   V I R T U A L";
            this.Shown += new System.EventHandler(this.FormVersion_Shown);
            this.PNLBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNLBase;
        private System.Windows.Forms.Label LBLTitle;
        private System.Windows.Forms.ListView LSTVersions;
    }
}