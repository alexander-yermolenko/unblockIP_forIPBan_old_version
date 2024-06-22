namespace unblockIP_forIPBan
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.ListBox listBoxIPs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.listBoxIPs = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(12, 12);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(200, 20);
            this.textBoxIP.TabIndex = 0;

            // 
            // listBoxIPs
            // 
            this.listBoxIPs.FormattingEnabled = true;
            this.listBoxIPs.Location = new System.Drawing.Point(12, 38);
            this.listBoxIPs.Name = "listBoxIPs";
            this.listBoxIPs.Size = new System.Drawing.Size(200, 134);
            this.listBoxIPs.TabIndex = 1;

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add IP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(218, 39);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete IP";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);

            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(304, 181);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.listBoxIPs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "IP Ban Manager";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
