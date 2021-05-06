using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenWebsite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser2.Load("https://music.youtube.com/");
            Text = "YTMusic";
            panel1.BackColor = Color.DarkRed;
            panel2.BackColor = Color.DarkRed;

        }

        private void button3_Click(object sender, EventArgs e)
        {


            if(MessageBox.Show("Visit Owner", "More", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://github.com/ferend");
            }
           
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.Text = e.Url.ToString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser2.Back();
        }

        private void chromiumWebBrowser2_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Text;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser2.Load("https://newretrowave.com/");
            Text = "NewRetroWave";
            panel1.BackColor = Color.Purple;
            panel2.BackColor = Color.Purple;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser2.Forward();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser2.Load("https://www.tradingview.com/");
            Text = "Tradingview";
            panel1.BackColor = Color.Aqua;
            panel2.BackColor = Color.Aqua;

        }
    }
}
