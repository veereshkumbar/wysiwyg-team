using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using sie.Models;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace sie.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            //var manager = new UserManager();
            //var user = new ApplicationUser() { UserName = UserName.Text };
            //IdentityResult result = manager.Create(user, Password.Text);
            //if (result.Succeeded)
            //{
            //    IdentityHelper.SignIn(manager, user, isPersistent: false);
            //    IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            //}
            //else 
            //{
            //    ErrorMessage.Text = result.Errors.FirstOrDefault();
            //}
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DropDownList4.SelectedItem.Text=="Principal")
            {
                Label7.Text = "Professional Information";
                Label4.Text = "Website";
                Label5.Text = "Office No";
                Label7.Visible = true;
                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;
                Label4.Visible = true;
                Label5.Visible = true;
                Label6.Visible = true;
                UserName0.Visible = true;
                DropDownList1.Visible = true;
                DropDownList2.Visible = true;
                UserName1.Visible = true;
                UserName2.Visible = true;
                UserName3.Visible = true;
                

            }
            else if (DropDownList4.SelectedItem.Text == "Student")
            {
                Label7.Text = "Personnel Information";
                Label7.Visible = true;
                UserName4.Visible = true;
                UserName1.Visible = false;
                UserName2.Visible = true;
                Label4.Visible = true;
                Label4.Text = "Reg No";
                Label5.Visible = true;
                Label5.Text = "DOB";
                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = false;
                UserName0.Visible = true;
                DropDownList1.Visible = true;
                DropDownList2.Visible = true;
                Label6.Visible = true;
                UserName3.Visible = true;

            }
           
        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList4.SelectedItem.Text == "Principal")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\HP1\Documents\smartedu.mdf;Integrated Security=True;Connect Timeout=30;");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Princi values('" + UserName.Text + "','" + Password.Text + "','" + UserName0.Text + "','" + DropDownList1.Text + "','" + DropDownList2.Text + "','" + UserName2.Text + "','" + UserName3.Text + "','" + UserName1.Text + "')", con);
                cmd.ExecuteNonQuery();
                Label7.Visible = true;
                Label7.Text = "Successfully Registered";
            }
            else if (DropDownList4.SelectedItem.Text == "Student")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\HP1\Documents\smartedu.mdf;Integrated Security=True;Connect Timeout=30;");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Student values('" + UserName.Text + "','" + Password.Text + "','" + UserName0.Text + "','" + DropDownList1.Text + "','" + UserName2.Text + "','" + UserName3.Text + "','" + UserName4.Text + "')", con);
                cmd.ExecuteNonQuery();
                Label7.Visible = true;
                Label7.Text = "Successfully Registered";
                              

            }
            UserName.Text = "";
            UserName0.Text = "";
            UserName1.Text = "";
            UserName2.Text = "";
            UserName3.Text = "";
            DropDownList1.ClearSelection();


            DropDownList2.ClearSelection();
            DropDownList4.ClearSelection();



                        

        }

       

        
    }
}