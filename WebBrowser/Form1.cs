using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
System.Windows.Forms.Control;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://www.google.com");
            tabControl1.Size = this.Size;
            tabControl1.Width = tabControl1.Width - 10;
            tabControl1.Height = tabControl1.Height - 35;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            tabControl1.Size = this.Size;
            tabControl1.Width = tabControl1.Width - 10;
            tabControl1.Height = tabControl1.Height - 35;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            string uurl = toolStripTextBox1.Text;
            webBrowser1.Navigate(uurl);
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {
            var p = tabControl1.SelectedTab;
            if (p.Text == "New Tab")
            {
                string Title= "TabPage " + (tabControl1.TabCount).ToString();
                tabControl1.SelectedTab.Text = Title;
                tabControl1.SelectedTab.Controls.Add(webBrowser1);
                webBrowser1.Navigate("https://www.google.com");

                TabPage myTabPage = new TabPage("New Tab");
                tabControl1.TabPages.Add(myTabPage);
            }
            else
            {
                tabControl1.SelectedTab.Controls.Add(toolStrip1);
                tabControl1.SelectedTab.Controls.Add(webBrowser1);
                toolStripTextBox1.Text = webBrowser1.Url.ToString();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
