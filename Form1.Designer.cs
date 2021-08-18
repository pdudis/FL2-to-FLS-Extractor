namespace FL2_to_FLS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loadFLSBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.quitBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.donateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadFLSBtn
            // 
            this.loadFLSBtn.Location = new System.Drawing.Point(12, 12);
            this.loadFLSBtn.Name = "loadFLSBtn";
            this.loadFLSBtn.Size = new System.Drawing.Size(108, 32);
            this.loadFLSBtn.TabIndex = 0;
            this.loadFLSBtn.Text = "&Load FL2 File";
            this.loadFLSBtn.UseVisualStyleBackColor = true;
            this.loadFLSBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "FL2|*.fl2";
            this.openFileDialog1.Title = "Select Flash file with extension FL2";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 50);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(719, 628);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.Url = new System.Uri("http://Intro", System.UriKind.Absolute);
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(623, 12);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(108, 32);
            this.quitBtn.TabIndex = 3;
            this.quitBtn.Text = "&Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(509, 12);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(108, 32);
            this.aboutBtn.TabIndex = 2;
            this.aboutBtn.Text = "&About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // donateBtn
            // 
            this.donateBtn.Location = new System.Drawing.Point(395, 12);
            this.donateBtn.Name = "donateBtn";
            this.donateBtn.Size = new System.Drawing.Size(108, 32);
            this.donateBtn.TabIndex = 1;
            this.donateBtn.Text = "&Buy me a coffee!";
            this.donateBtn.UseVisualStyleBackColor = true;
            this.donateBtn.Click += new System.EventHandler(this.donateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 691);
            this.Controls.Add(this.donateBtn);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.loadFLSBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FL2 to FLS Extractor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadFLSBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button donateBtn;
    }
}

