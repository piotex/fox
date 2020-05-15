using System;
using System.Windows.Forms;
using Gecko;

namespace fox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Xpcom.Initialize("Firefox");
            geckoWebBrowser1.Navigate("www.bbc.com");

        }

        private void geckoWebBrowser1_Click(object sender, EventArgs e)
        {

        }
    }
}
