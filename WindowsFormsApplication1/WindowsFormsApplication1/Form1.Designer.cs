namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.prgsbar = new System.Windows.Forms.ProgressBar();
            this.lblfolderpath = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lstbox = new System.Windows.Forms.ListBox();
            this.lblvirus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 89);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(140, 44);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse Folder";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(158, 89);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(140, 44);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Start Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.button2_Click);
            // 
            // prgsbar
            // 
            this.prgsbar.Location = new System.Drawing.Point(12, 192);
            this.prgsbar.Name = "prgsbar";
            this.prgsbar.Size = new System.Drawing.Size(678, 35);
            this.prgsbar.TabIndex = 2;
            // 
            // lblfolderpath
            // 
            this.lblfolderpath.AutoSize = true;
            this.lblfolderpath.Location = new System.Drawing.Point(12, 150);
            this.lblfolderpath.Name = "lblfolderpath";
            this.lblfolderpath.Size = new System.Drawing.Size(57, 13);
            this.lblfolderpath.TabIndex = 3;
            this.lblfolderpath.Text = "folder path";
            // 
            // lstbox
            // 
            this.lstbox.FormattingEnabled = true;
            this.lstbox.Location = new System.Drawing.Point(376, 20);
            this.lstbox.Name = "lstbox";
            this.lstbox.Size = new System.Drawing.Size(313, 147);
            this.lstbox.TabIndex = 4;
            // 
            // lblvirus
            // 
            this.lblvirus.AutoSize = true;
            this.lblvirus.Location = new System.Drawing.Point(14, 174);
            this.lblvirus.Name = "lblvirus";
            this.lblvirus.Size = new System.Drawing.Size(79, 13);
            this.lblvirus.TabIndex = 5;
            this.lblvirus.Text = "viruses found : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 239);
            this.Controls.Add(this.lblvirus);
            this.Controls.Add(this.lstbox);
            this.Controls.Add(this.lblfolderpath);
            this.Controls.Add(this.prgsbar);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ProgressBar prgsbar;
        private System.Windows.Forms.Label lblfolderpath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox lstbox;
        private System.Windows.Forms.Label lblvirus;
    }
}

