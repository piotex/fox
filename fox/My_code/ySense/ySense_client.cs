using fox.My_code.browser;
using fox.My_code.browser.basics.classes;
using Gecko.WebIDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fox.My_code.ySense
{
    public class ySense_client : Firefox_Client
    {
        public ySense_client()
        {
            navigation_path = @"https://www.ysense.com";
            login_path = @"https://www.ysense.com/login";

        }

        public override int doSth()
        {
            string body = Document.Body.InnerHtml;

            return 1;
        }

        public override int LogIn()
        {
            Navigate_Client(login_path);
            string body = Document.Body.InnerHtml;

            MessageBox.Show("Loaded");
            return 1;
        }
    }
}
