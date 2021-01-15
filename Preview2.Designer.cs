namespace Railway_Admin
{
    partial class Preview2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preview2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.show = new System.Windows.Forms.TextBox();
            this.groupExcel = new System.Windows.Forms.GroupBox();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupLocation = new System.Windows.Forms.GroupBox();
            this.btnDoneLocation = new System.Windows.Forms.Button();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupExcel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.show);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 559);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tables in the Database";
            // 
            // show
            // 
            this.show.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.show.Location = new System.Drawing.Point(0, 21);
            this.show.Multiline = true;
            this.show.Name = "show";
            this.show.ReadOnly = true;
            this.show.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.show.Size = new System.Drawing.Size(305, 538);
            this.show.TabIndex = 1;
            // 
            // groupExcel
            // 
            this.groupExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupExcel.Controls.Add(this.tb5);
            this.groupExcel.Controls.Add(this.btnDownload);
            this.groupExcel.Controls.Add(this.label2);
            this.groupExcel.Controls.Add(this.label1);
            this.groupExcel.Controls.Add(this.tb4);
            this.groupExcel.Controls.Add(this.tb3);
            this.groupExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupExcel.Location = new System.Drawing.Point(390, 35);
            this.groupExcel.Name = "groupExcel";
            this.groupExcel.Size = new System.Drawing.Size(346, 300);
            this.groupExcel.TabIndex = 3;
            this.groupExcel.TabStop = false;
            this.groupExcel.Text = "Download into Excel file";
            // 
            // tb5
            // 
            this.tb5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb5.Location = new System.Drawing.Point(6, 250);
            this.tb5.Multiline = true;
            this.tb5.Name = "tb5";
            this.tb5.ReadOnly = true;
            this.tb5.Size = new System.Drawing.Size(334, 35);
            this.tb5.TabIndex = 3;
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.AutoSize = true;
            this.btnDownload.Location = new System.Drawing.Point(118, 179);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(125, 48);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download File";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "New excel file name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the table Name:";
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(27, 139);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(292, 24);
            this.tb4.TabIndex = 0;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(27, 70);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(292, 24);
            this.tb3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 617);
            this.panel1.TabIndex = 4;
            // 
            // groupLocation
            // 
            this.groupLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupLocation.AutoSize = true;
            this.groupLocation.Controls.Add(this.btnDoneLocation);
            this.groupLocation.Controls.Add(this.tbLocation);
            this.groupLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupLocation.Location = new System.Drawing.Point(435, 351);
            this.groupLocation.Name = "groupLocation";
            this.groupLocation.Size = new System.Drawing.Size(251, 107);
            this.groupLocation.TabIndex = 7;
            this.groupLocation.TabStop = false;
            this.groupLocation.Text = "Enter Storage Location";
            this.groupLocation.Visible = false;
            // 
            // btnDoneLocation
            // 
            this.btnDoneLocation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDoneLocation.Location = new System.Drawing.Point(148, 63);
            this.btnDoneLocation.Name = "btnDoneLocation";
            this.btnDoneLocation.Size = new System.Drawing.Size(75, 23);
            this.btnDoneLocation.TabIndex = 1;
            this.btnDoneLocation.Text = "Done";
            this.btnDoneLocation.UseVisualStyleBackColor = true;
            this.btnDoneLocation.Click += new System.EventHandler(this.btnDoneLocation_Click);
            // 
            // tbLocation
            // 
            this.tbLocation.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbLocation.Location = new System.Drawing.Point(17, 32);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(206, 22);
            this.tbLocation.TabIndex = 0;
            // 
            // Preview2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 618);
            this.Controls.Add(this.groupLocation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupExcel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preview2";
            this.Text = "Preview Table";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupExcel.ResumeLayout(false);
            this.groupExcel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupLocation.ResumeLayout(false);
            this.groupLocation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox show;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.GroupBox groupLocation;
        private System.Windows.Forms.Button btnDoneLocation;
        private System.Windows.Forms.TextBox tbLocation;
    }
}