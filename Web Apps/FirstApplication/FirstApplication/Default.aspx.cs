using System;
using System.Web;
using System.Web.UI;

namespace FirstApplication
{

    public partial class Default : System.Web.UI.Page
    {
        public void button1Clicked(object sender, EventArgs args)
        {
            if(IsPostBack)
            {
           //     button1.Text = "Already Clicked";
            }
        //    button1.Text = "You clicked me";
        }
    }
}
