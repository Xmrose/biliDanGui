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
            this.SuspendLayout();
            // 
            // txtBox1
            // 
            this.txtBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtBox1.Location = new System.Drawing.Point(89, 251);
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
            this.lkL1.Location = new System.Drawing.Point(88, 286);
            this.lkL1.Name = "lkL1";
            this.lkL1.Size = new System.Drawing.Size(0, 19);
            this.lkL1.TabIndex = 1;
            this.lkL1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.elkC);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl2.Location = new System.Drawing.Point(88, 269);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(178, 19);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "真实地址（可点击手动下载）";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl1.Location = new System.Drawing.Point(89, 230);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(163, 19);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "在此输入观看地址并回车";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1.Location = new System.Drawing.Point(303, 303);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(66, 25);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "退出(&X)";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // ckB1
            // 
            this.ckB1.AutoSize = true;
            this.ckB1.BackColor = System.Drawing.Color.Silver;
            this.ckB1.Checked = true;
            this.ckB1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckB1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckB1.ForeColor = System.Drawing.Color.Purple;
            this.ckB1.Location = new System.Drawing.Point(148, 207);
            this.ckB1.Name = "ckB1";
            this.ckB1.Size = new System.Drawing.Size(72, 21);
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
            this.ckB2.Location = new System.Drawing.Point(226, 207);
            this.ckB2.Name = "ckB2";
            this.ckB2.Size = new System.Drawing.Size(72, 21);
            this.ckB2.TabIndex = 6;
            this.ckB2.Text = "下载弹幕";
            this.ckB2.UseVisualStyleBackColor = false;
            // 
            // wB1
            // 
            this.wB1.AllowWebBrowserDrop = false;
            this.wB1.IsWebBrowserContextMenuEnabled = false;
            this.wB1.Location = new System.Drawing.Point(12, 11);
            this.wB1.MinimumSize = new System.Drawing.Size(20, 18);
            this.wB1.Name = "wB1";
            this.wB1.ScrollBarsEnabled = false;
            this.wB1.Size = new System.Drawing.Size(20, 18);
            this.wB1.TabIndex = 7;
            this.wB1.TabStop = false;
            this.wB1.Visible = false;
            this.wB1.WebBrowserShortcutsEnabled = false;
            this.wB1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.eDocC);
            // 
            // pB1
            // 
            this.pB1.Location = new System.Drawing.Point(89, 251);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(280, 16);
            this.pB1.TabIndex = 8;
            this.pB1.Visible = false;
            // 
            // mainwin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(412, 339);
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
    }
}

