namespace RSSOkumaUygulaması
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstbaslik = new System.Windows.Forms.ListBox();
            this.btngetir = new System.Windows.Forms.Button();
            this.web_browser = new System.Windows.Forms.WebBrowser();
            this.txtrssurl = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtrssurl);
            this.groupBox1.Controls.Add(this.btngetir);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSS URL";
            // 
            // lstbaslik
            // 
            this.lstbaslik.FormattingEnabled = true;
            this.lstbaslik.Location = new System.Drawing.Point(6, 23);
            this.lstbaslik.Name = "lstbaslik";
            this.lstbaslik.Size = new System.Drawing.Size(188, 407);
            this.lstbaslik.TabIndex = 1;
            this.lstbaslik.SelectedIndexChanged += new System.EventHandler(this.lstbaslik_SelectedIndexChanged);
            // 
            // btngetir
            // 
            this.btngetir.Location = new System.Drawing.Point(961, 29);
            this.btngetir.Name = "btngetir";
            this.btngetir.Size = new System.Drawing.Size(75, 23);
            this.btngetir.TabIndex = 3;
            this.btngetir.Text = "getir";
            this.btngetir.UseVisualStyleBackColor = true;
            this.btngetir.Click += new System.EventHandler(this.btngetir_Click);
            // 
            // web_browser
            // 
            this.web_browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_browser.Location = new System.Drawing.Point(3, 16);
            this.web_browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_browser.Name = "web_browser";
            this.web_browser.Size = new System.Drawing.Size(782, 417);
            this.web_browser.TabIndex = 4;
            this.web_browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // txtrssurl
            // 
            this.txtrssurl.Location = new System.Drawing.Point(6, 29);
            this.txtrssurl.Name = "txtrssurl";
            this.txtrssurl.Size = new System.Drawing.Size(943, 20);
            this.txtrssurl.TabIndex = 5;
            this.txtrssurl.Text = "https://www.sabah.com.tr/rss/spor.xml";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstbaslik);
            this.groupBox2.Location = new System.Drawing.Point(24, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 436);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Haber Başlıkları";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.web_browser);
            this.groupBox3.Location = new System.Drawing.Point(272, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(788, 436);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Haber Detay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 533);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "RSS Okuma Uygulaması";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtrssurl;
        private System.Windows.Forms.Button btngetir;
        private System.Windows.Forms.ListBox lstbaslik;
        private System.Windows.Forms.WebBrowser web_browser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

