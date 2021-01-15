namespace Railway_Admin
{
    partial class BackGroundProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackGroundProcess));
            this.btnJsonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ipJson = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ipServer = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJsonStart
            // 
            this.btnJsonStart.BackColor = System.Drawing.Color.LightGray;
            this.btnJsonStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnJsonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJsonStart.ForeColor = System.Drawing.Color.DarkRed;
            this.btnJsonStart.Location = new System.Drawing.Point(10, 60);
            this.btnJsonStart.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.btnJsonStart.Name = "btnJsonStart";
            this.btnJsonStart.Size = new System.Drawing.Size(1023, 38);
            this.btnJsonStart.TabIndex = 3;
            this.btnJsonStart.Text = "Start";
            this.btnJsonStart.UseVisualStyleBackColor = false;
            this.btnJsonStart.AutoSizeChanged += new System.EventHandler(this.BackGroundProcess_Load);
            this.btnJsonStart.Click += new System.EventHandler(this.btnJsonStart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.ipServer);
            this.panel1.Controls.Add(this.ipJson);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnJsonStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1043, 108);
            this.panel1.TabIndex = 4;
            // 
            // ipJson
            // 
            this.ipJson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipJson.AutoSize = true;
            this.ipJson.BackColor = System.Drawing.Color.White;
            this.ipJson.Location = new System.Drawing.Point(582, 9);
            this.ipJson.Name = "ipJson";
            this.ipJson.Size = new System.Drawing.Size(199, 17);
            this.ipJson.TabIndex = 5;
            this.ipJson.Text = "JSON IP address : Loading ....";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "** This application should only run  on SERVER !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 108);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1043, 475);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.Url = new System.Uri("https://hits-rail.herokuapp.com/", System.UriKind.Absolute);
            // 
            // ipServer
            // 
            this.ipServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipServer.Location = new System.Drawing.Point(580, 30);
            this.ipServer.Name = "ipServer";
            this.ipServer.ReadOnly = true;
            this.ipServer.Size = new System.Drawing.Size(288, 22);
            this.ipServer.TabIndex = 6;
            this.ipServer.Text = "Server IP address: Loading ....";
            // 
            // BackGroundProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 583);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BackGroundProcess";
            this.Text = "IP Fixer";
            this.Load += new System.EventHandler(this.BackGroundProcess_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnJsonStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label ipJson;
        private System.Windows.Forms.TextBox ipServer;
    }
}