using System;
using System.Windows.Forms;
using fox.My_code.browser;
using fox.My_code.db;
using Gecko;

namespace fox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Xpcom.Initialize("Firefox");

            string link = @"https://github.com/piotex/fox";
            Firefox_Base fox = new Firefox_Base();
            Controls.Add(fox);
            fox.Navigate(link);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FoxXmlData db = new FoxXmlData();
            db.Read();

        }
    }
}
