using fox.My_code.browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fox.My_code.ySense
{
    public class ySense_client : Firefox_Base
    {
        public ySense_client()
        {
            string path = @"https://www.ysense.com";
            Navigate(path);
        }

        public override int doSth()
        {
            string body = Document.Body.InnerHtml;

            return 1;
        }
    }
}
