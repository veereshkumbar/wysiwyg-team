using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace sie
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        int count=0;
        protected void Page_Load(object sender, EventArgs e)
        {
                        

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\HP1\Documents\smartedu.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into blog values( '" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')", con);
            cmd.ExecuteNonQuery();
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            Response.Write("Posted Successfully!");
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("Default.aspx");
        }
    }
}