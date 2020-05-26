using System;
using System.Windows.Forms;
using fox.My_code.browser;
using fox.My_code.browser.basics;
using fox.My_code.db;
using Gecko;
using Gecko.WebIDL;

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
            Client_Manager manager = new Client_Manager(this);
            manager.StartClient(Client_Type.ySense);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FoxXmlData db = new FoxXmlData();
            db.Read();

        }
    }
}
