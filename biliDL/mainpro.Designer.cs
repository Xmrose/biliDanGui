namespace biliDL
{
    partial class mainwin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainwin));
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.lkL1 = new System.Windows.Forms.LinkLabel();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.ckB1 = new System.Windows.Forms.CheckBox();
            this.ckB2 = new System.Windows.Forms.CheckBox();
            this.wB1 = new System.Windows.Forms.WebBrowser();
            this.pB1 = new System.Windows.Forms.ProgressBar();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.txtBox5 = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox1
            // 
            this.txtBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtBox1.Location = new System.Drawing.Point(89, 272);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(280, 17);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.Text = "http://www.bilibili.com/video/av12450/";
            this.txtBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eKeyD);
            this.txtBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ePKeyD);
            // 
            // lkL1
            // 
            this.lkL1.AutoSize = true;
            this.lkL1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lkL1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lkL1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lkL1.Location = new System.Drawing.Point(88, 310);
            this.lkL1.Name = "lkL1";
            this.lkL1.Size = new System.Drawing.Size(0, 17);
            this.lkL1.TabIndex = 1;
            this.lkL1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.elkC);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl2.Location = new System.Drawing.Point(88, 291);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(177, 17);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "真实地址（可点击手动下载）";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl1.Location = new System.Drawing.Point(89, 249);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(162, 18);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "在此输入观看地址并回车";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1.Location = new System.Drawing.Point(303, 328);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(66, 27);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "退出(&X)";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // ckB1
            // 
            this.ckB1.AutoSize = true;
            this.ckB1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ckB1.Checked = true;
            this.ckB1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckB1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckB1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ckB1.Location = new System.Drawing.Point(148, 224);
            this.ckB1.Name = "ckB1";
            this.ckB1.Size = new System.Drawing.Size(71, 19);
            this.ckB1.TabIndex = 5;
            this.ckB1.Text = "下载视频";
            this.ckB1.UseVisualStyleBackColor = false;
            // 
            // ckB2
            // 
            this.ckB2.AutoSize = true;
            this.ckB2.BackColor = System.Drawing.Color.Silver;
            this.ckB2.Checked = true;
            this.ckB2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckB2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckB2.ForeColor = System.Drawing.Color.Purple;
            this.ckB2.Location = new System.Drawing.Point(226, 224);
            this.ckB2.Name = "ckB2";
            this.ckB2.Size = new System.Drawing.Size(71, 19);
            this.ckB2.TabIndex = 6;
            this.ckB2.Text = "下载弹幕";
            this.ckB2.UseVisualStyleBackColor = false;
            this.ckB2.CheckedChanged += new System.EventHandler(this.eCkCg);
            // 
            // wB1
            // 
            this.wB1.AllowWebBrowserDrop = false;
            this.wB1.IsWebBrowserContextMenuEnabled = false;
            this.wB1.Location = new System.Drawing.Point(12, 12);
            this.wB1.MinimumSize = new System.Drawing.Size(20, 20);
            this.wB1.Name = "wB1";
            this.wB1.ScrollBarsEnabled = false;
            this.wB1.Size = new System.Drawing.Size(20, 20);
            this.wB1.TabIndex = 7;
            this.wB1.TabStop = false;
            this.wB1.Visible = false;
            this.wB1.WebBrowserShortcutsEnabled = false;
            this.wB1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.eDocC);
            // 
            // pB1
            // 
            this.pB1.Location = new System.Drawing.Point(89, 272);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(280, 17);
            this.pB1.TabIndex = 8;
            this.pB1.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl3.ForeColor = System.Drawing.Color.Purple;
            this.lbl3.Location = new System.Drawing.Point(159, 144);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(106, 14);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "输入你的屏幕分辨率";
            // 
            // txtBox2
            // 
            this.txtBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtBox2.Location = new System.Drawing.Point(158, 160);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(36, 21);
            this.txtBox2.TabIndex = 10;
            this.txtBox2.Text = "1920";
            this.txtBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl4.ForeColor = System.Drawing.Color.Purple;
            this.lbl4.Location = new System.Drawing.Point(199, 163);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(15, 14);
            this.lbl4.TabIndex = 11;
            this.lbl4.Text = "X";
            // 
            // txtBox3
            // 
            this.txtBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtBox3.Location = new System.Drawing.Point(220, 160);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(39, 21);
            this.txtBox3.TabIndex = 12;
            this.txtBox3.Text = "1080";
            this.txtBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl5.ForeColor = System.Drawing.Color.Purple;
            this.lbl5.Location = new System.Drawing.Point(151, 184);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(51, 14);
            this.lbl5.TabIndex = 13;
            this.lbl5.Text = "字体大小";
            // 
            // txtBox4
            // 
            this.txtBox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtBox4.Location = new System.Drawing.Point(160, 200);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.Size = new System.Drawing.Size(30, 21);
            this.txtBox4.TabIndex = 14;
            this.txtBox4.Text = "35";
            this.txtBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox5
            // 
            this.txtBox5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBox5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtBox5.Location = new System.Drawing.Point(233, 200);
            this.txtBox5.Name = "txtBox5";
            this.txtBox5.Size = new System.Drawing.Size(30, 21);
            this.txtBox5.TabIndex = 16;
            this.txtBox5.Text = "8";
            this.txtBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl6.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl6.ForeColor = System.Drawing.Color.Purple;
            this.lbl6.Location = new System.Drawing.Point(213, 184);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(73, 14);
            this.lbl6.TabIndex = 15;
            this.lbl6.Text = "弹幕滚动速度";
            // 
            // mainwin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(412, 367);
            this.Controls.Add(this.txtBox5);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.txtBox4);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.pB1);
            this.Controls.Add(this.wB1);
            this.Controls.Add(this.ckB2);
            this.Controls.Add(this.ckB1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lkL1);
            this.Controls.Add(this.txtBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainwin";
            this.Opacity = 0.95D;
            this.Text = "Bilibili Video Downloader";
            this.TransparencyKey = System.Drawing.SystemColors.WindowText;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.eMD);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.eMM);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.LinkLabel lkL1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.CheckBox ckB1;
        private System.Windows.Forms.CheckBox ckB2;
        private System.Windows.Forms.WebBrowser wB1;
        private System.Windows.Forms.ProgressBar pB1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txtBox4;
        private System.Windows.Forms.TextBox txtBox5;
        private System.Windows.Forms.Label lbl6;
    }
}

