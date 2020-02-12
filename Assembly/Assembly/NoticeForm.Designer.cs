namespace Assembly
{
    partial class NoticeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoticeForm));
            this.lblAssembly = new System.Windows.Forms.Label();
            this.tbProtocol = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // lblAssembly
            // 
            this.lblAssembly.AutoSize = true;
            this.lblAssembly.Location = new System.Drawing.Point(12, 7);
            this.lblAssembly.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAssembly.Name = "lblAssembly";
            this.lblAssembly.Size = new System.Drawing.Size(77, 20);
            this.lblAssembly.TabIndex = 0;
            this.lblAssembly.Text = "Assembly";
            // 
            // tbProtocol
            // 
            this.tbProtocol.Location = new System.Drawing.Point(10, 30);
            this.tbProtocol.Margin = new System.Windows.Forms.Padding(2);
            this.tbProtocol.Multiline = true;
            this.tbProtocol.Name = "tbProtocol";
            this.tbProtocol.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbProtocol.Size = new System.Drawing.Size(561, 508);
            this.tbProtocol.TabIndex = 1;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // NoticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 549);
            this.Controls.Add(this.tbProtocol);
            this.Controls.Add(this.lblAssembly);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "NoticeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Протокол сборки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAssembly;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        public System.Windows.Forms.TextBox tbProtocol;
    }
}