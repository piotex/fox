using System;
using Gecko;

namespace fox.My_code.browser
{
    public class Firefox_Base: GeckoWebBrowser
    {
        public Firefox_Base()
        {
            int size_X =1400;
            int size_Y =780;

            FrameEventsPropagateToMainWindow = false;
            Location = new System.Drawing.Point(0,0);
            Name = "FoX";
            Size = new System.Drawing.Size(size_X,size_Y);
            TabIndex = 0;
            UseHttpActivityObserver = false;
            //Click += new System.EventHandler(this.geckoWebBrowser1_Click);
        }
    }
}
