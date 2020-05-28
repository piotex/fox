using System;
using System.Windows.Forms;
using fox.My_code.browser;
using fox.My_code.browser.basics;
using fox.My_code.browser.Factory;
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
        Client_Manager manager;
        private void Form1_Load(object sender, EventArgs e)
        {
            Xpcom.Initialize("Firefox");
            manager = new Client_Manager(this);
            manager.NavigatoToMain_Client(Client_Type.ySense);

            //manager.LogIn_Client(Client_Type.ySense);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FoxXmlData db = new FoxXmlData();
            db.Read();
            manager.NavigatoToMain_Client(Client_Type.ySense);
        }
    }
}
