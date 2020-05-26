using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fox.My_code.browser.basics.classes
{
    public abstract class Firefox_Client : Firefox_Base
    {
        private bool ready ;
        protected string navigation_path;
        protected string login_path;

        public Firefox_Client()
        {
            ready = false;
            DocumentCompleted += documentCompleted;
        }

        protected void documentCompleted(object sender, EventArgs e)
        {
            ready = true;
        }

        protected int Navigate_Client(string path)
        {
            Navigate(path);
            while (!ready)
            {
                System.Windows.Forms.Application.DoEvents();
            }
            ready = false;
            return 1;
        }
    }
}
