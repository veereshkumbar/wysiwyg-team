using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sie
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                setimage();
            }
            
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            setimage();
        }

        private void setimage()
        {
            Random r1 = new Random();
            int i = r1.Next(1, 7);
            Image1.ImageUrl = "~/images/" + i.ToString() + ".jpg";
        }
    }
}