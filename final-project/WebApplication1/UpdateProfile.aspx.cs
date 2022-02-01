using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=webbased;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"]==null)
            {
                Response.Redirect("home.aspx");
            }
            else if(Session["role"].Equals("manager"))
            {
                link1.Visible = false;
            }
            else if (Session["role"].Equals("employee"))
            {
                link1.Visible = false;
                link2.Visible = false;

            }
            AccountType.Text = "Account Type : " + Session["role"] + "";
            Label2.Text = "Cargo /:: " + Session["firstname"] + "";
            Newpassword.Visible = true;
            Oldpassword.Visible = true;
            CurrentPassword.Visible = false;
            NewUsername.Visible = false;
            Button2.Visible = false;
            msg.Visible= false;
            msg2.Visible= false;
            msg3.Visible = false;
            msg4.Visible = false;
            Passform.Visible = false;
        }
        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("home.aspx");

        }
        
        protected void ChangePass_Click(object sender , EventArgs e)
        {
            Newpassword.Visible = true;
            Oldpassword.Visible = true;
            CurrentPassword.Visible = false;
            NewUsername.Visible = false;
            Button2.Visible = false;
            Button1.Visible = true;
            UserNameform.Visible = true;
            Passform.Visible = false;
        }
        protected void ChangeUsername_Click(object sender, EventArgs e)
        {
            Newpassword.Visible = false;
            Oldpassword.Visible = false;   
            CurrentPassword.Visible = true;
            NewUsername.Visible = true;
            Button1.Visible = false;
            Button2.Visible = true;
            UserNameform.Visible = false;
            Passform.Visible = true;

        }
        protected void UpdateUsername_Click(object sender , EventArgs e)
        {

            try
            {
                con1.Open();
                SqlCommand cmd = new SqlCommand("select * from Employee where UserName='" + Session["username"].ToString() + "' AND UserPassword='" + CurrentPassword.Text.Trim() + "'", con1);
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    msg.Visible = false;
                    msg2.Visible = true;
                    CurrentPassword.BorderColor = System.Drawing.Color.Red;
                }
                else
                {
                    msg2.Visible = false;
                    reader.Close();
                    SqlCommand cmd2 = new SqlCommand("select * from Employee where UserName='" + NewUsername.Text.Trim() + "'", con1);
                    SqlDataReader reader2 = cmd2.ExecuteReader();
                    if (reader2.HasRows)
                    {
                        msg.Visible = true;
                        msg2.Visible = false;
                        NewUsername.BorderColor= System.Drawing.Color.Red;
                    }
                    else
                    {
                        reader2.Close();
                        SqlCommand cmd3 = new SqlCommand("UPDATE Employee SET UserName='" + NewUsername.Text.Trim() + "' WHERE UserName='" + Session["username"].ToString() + "'", con1);
                        cmd3.ExecuteNonQuery();
                        cmd3.Dispose();
                        con1.Close();
                        msg.Visible = false;
                        msg3.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            ChangeUsername_Click(sender, e);
        }
        protected void Updatepassword_Click(object sender, EventArgs e)
        {

            try
            {
                con1.Open();
                SqlCommand cmd = new SqlCommand("select * from Employee where UserName='" + Session["username"].ToString() + "' AND UserPassword='" + Oldpassword.Text.Trim() + "'", con1);
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    msg.Visible = false;
                    msg2.Visible = true;
                    Oldpassword.BorderColor = System.Drawing.Color.Red;

                }
                else
                {
                    reader.Close();
                    SqlCommand cmd3 = new SqlCommand("UPDATE Employee SET UserPassword='" + Newpassword.Text.Trim() + "' WHERE UserName='" + Session["username"].ToString() + "'", con1);
                    cmd3.ExecuteNonQuery();
                    cmd3.Dispose();
                    con1.Close();
                    msg2.Visible = false;
                    msg4.Visible = true; 
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}