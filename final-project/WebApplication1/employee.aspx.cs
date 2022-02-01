using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Label1.Text = "hey "+ Session["firstname"] + "";
                Label2.Text = "Cargo /:: " + Session["firstname"] + "";
                
                if (Session["Role"].Equals("manager"))
                {
                    link1.Visible = false;
                }
                else if (Session["Role"].Equals("employee"))
                {
                    link1.Visible = false;
                    link2.Visible = false;
                }
            } 
            
            
        }
        protected void Logout_Click(object sender , EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("home.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("updateprofile.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("updateshipments.aspx");
        }
    }
}