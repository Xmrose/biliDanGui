using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.ComponentModel;

namespace biliDL
{
    public partial class mainwin : Form
    {
        string comment_url, cid;
        string bef_comcon;
        string aft_comcon;

        public mainwin()
        {
            InitializeComponent();
        }

        //Begin of the drag to move window event
        private Point offset;

        private void eMD(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - Left, cur.Y - this.Top);
        }

        private void eMM(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }
        //End of event

        private void ePKeyD(object sender, PreviewKeyDownEventArgs e)
        {
            lbl1.Text = lbl1.Text.Replace("(下载完成)", "");
            if (e.KeyCode == Keys.Enter)
            {
                lkL1.Text = "Initializing to detect...";
            }
            else
            {
                lkL1.Text = "Hit the enter to start...";
            }            
            Application.DoEvents();
        }

        private void eKeyD(object sender, KeyEventArgs e)   //keydown event
        {
            Regex reg;
            //Match match;
            if (e.KeyCode == Keys.Enter)
            {
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.Start();

                p.StandardInput.WriteLine(string.Format("media_address.py{0}{1}", " ", txtBox1.Text));
                Application.DoEvents();
                p.StandardInput.WriteLine("exit");
                string cmd_out = p.StandardOutput.ReadToEnd();

                p.WaitForExit();
                p.Close();

                if (cmd_out != null)   //env normal
                {
                    reg = new Regex("ht{2,}.+\\?.+");

                    if (reg.Match(cmd_out).Length == 0)
                    {
                        lkL1.Text = "Fetch failure, please check the url && ur network...";
                    }
                    else
                    {
                        lkL1.Text = reg.Match(cmd_out).Value;    //successfully fetched the download address
                        reg = new Regex("\\/\\d+-");
                        cid = reg.Match(lkL1.Text).Value.Substring(1, reg.Match(lkL1.Text).Value.Length - 2);
                        comment_url = string.Format("http://comment.bilibili.com/{0}.xml", cid);
                        
                        if (ckB1.Checked)
                        {
                            media_down(lkL1.Text, cid); //downloading .flv media
                        }

                        if (ckB2.Checked)
                        {
                            HtmlDocument hd = wB1.Document;
                            wB1.DocumentCompleted += eDocC;
                            wB1.Navigate(comment_url);   //downloading .xml comments
                        }
                    }
                }
                else
                {
                    lkL1.Text = "Unknowm error occured... ";
                }
            }
        }

        private void elkC(object sender, LinkLabelLinkClickedEventArgs e)   //if cannot pop-up automatically
        {
            try
            {
                Process.Start(lkL1.Text);
            }
            catch (Win32Exception)
            {
                lkL1.Text = "This is not an url...";
            }            
        }

        private void eDocC(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser wB1 = sender as WebBrowser;
            HtmlDocument doc = wB1.Document;
            HtmlElementCollection divCollection = doc.Body.GetElementsByTagName("div");
            FileStream fs = new FileStream(string.Format("{0}.xml", cid), FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            int index = 0;
            foreach (HtmlElement divItem in divCollection)
            {
                if (divItem.InnerHtml.ToUpper().Contains("DIV"))
                {
                    continue;
                }
                else
                {
                    string strContent = divItem.InnerText.TrimStart(new char[] { ' ' });
                    index++;

                    if (strContent != special_com(strContent)) //if containes escape character(s)
                    {
                        strContent = strContent.Replace(aft_comcon, special_com(strContent)); //reformed comment
                    }
                    
                    if (strContent.Substring(0, 2).Equals("- "))
                    {
                        strContent = strContent.Replace("- ", "");
                    }

                    if (index < 3) //reform the two rows of header info in case of .py unexpection
                    {
                        strContent = strContent.Replace(" ?> ", "?>");
                        sw.Write(strContent);
                        continue;
                    }
                    sw.WriteLine(strContent);
                }
            }
            sw.Close();
            fs.Close();
        }

        public string special_com(string txt)   //escape character(s) goes here
        {
            Regex l_reg = new Regex("\\>.+\\<");
            int flg_ac = 0;
            bef_comcon = txt;

            if (l_reg.Match(txt).Length != 0) 
            {
                txt = l_reg.Match(txt).Value.Substring(1, l_reg.Match(txt).Length - 2);
                aft_comcon = txt;
                if (txt.IndexOf("<") != -1)
                {
                    txt = txt.Replace("<","&lt;");
                    flg_ac = 1;
                }

                if (txt.IndexOf(">") != -1)
                {
                    txt = txt.Replace(">", "&gt;");
                    flg_ac = 1;
                }
            }

            if (flg_ac == 1)
            {
                return txt;
            }
            else
            {
               txt = bef_comcon;
               return txt;
            }
        }

        public void media_down(string url, string cid)
        {
            pB1.Visible = true;
            lbl1.Text += "(自动下载中...)";
            WebClient wc = new WebClient();
            wc.DownloadProgressChanged += wc_DownloadProgressChanged;
            wc.DownloadFileAsync(new Uri(url), string.Format("{0}.flv", cid));
            wc.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
        }

        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pB1.Value = 100;
            lbl1.Text = lbl1.Text.Replace("自动下载中...", "下载完成");
            pB1.Visible = false;
        }

        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pB1.Value = e.ProgressPercentage;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
