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
    public partial class WebForm1 : System.Web.UI.Page
    {
       
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=webbased;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            msg.Visible = false;
        }
        protected void login_Click(object sender,EventArgs e)
        {
            try
            {
                baglanti.Open();
             
                SqlCommand cmd = new SqlCommand("select * from employee where UserName='" + username.Text.Trim() + "' AND UserPassword='" + password.Text.Trim() + "'", baglanti);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                   
                    while(dr.Read())
                    {
                        Session["username"]= dr.GetValue(3).ToString();
                        Session["Role"] = dr.GetValue(5).ToString();
                        Session["firstname"] = dr.GetValue(2).ToString();
                        Session["lastname"] = dr.GetValue(1).ToString();
                        Response.Redirect("employee.aspx");
                        
                    }
                }
                else
                {
                   msg.Visible = true;
                    username.BorderColor = System.Drawing.Color.Red;
                    password.BorderColor = System.Drawing.Color.Red;
                }
                baglanti.Dispose(); 
                baglanti.Close();
            }
            catch (Exception ex)
            {

            }

        }
    }
}
