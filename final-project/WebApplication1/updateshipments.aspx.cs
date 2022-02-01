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
    public partial class WebForm3 : System.Web.UI.Page
    {
        public static int sid =5;
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=webbased;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            bige.Visible = false;
            returnit.Visible = false;
            teslim.Visible = false;
            yolda.Visible = false;
            Lstat.Visible = false;
            if (Session["Role"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else if (Session["Role"].Equals("employee"))
            {
                link1.Visible = false;
                link2.Visible = false;
            }
            if (Session["Role"].Equals("manager"))
            {
                link1.Visible = false;
            }
        }
        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Home.aspx");

        }

        protected void searchfor_Click(object sender, EventArgs e)
        {
            bige.InnerText = "Not found!!";
            bige.Visible = false;   
            string stat ="";
            sid = Convert.ToInt32(TextBox1.Text.Trim()) ;
            try
            {
                con1.Open();
                SqlCommand cmd3 = new SqlCommand("SELECT CurrentStatus from Shipments where id = '" + TextBox1.Text.Trim() + "'", con1);
                SqlDataReader dr = cmd3.ExecuteReader();
                while (dr.Read())
                {
                   stat = dr.GetValue(0).ToString();
                    
                }
                con1.Close();
                bige.InnerText = "Update the shipment status of shipment : " + sid + "";
                Lstat.InnerText = "last update : " + stat + "";
                bige.Visible = true;
                Lstat.Visible = true;
                if (stat.Equals("Göndericiden Teslim alindi"))
                {        
                    returnit.Visible = true;
                    yolda.Visible = true;
                }
                else if(stat.Equals("yolda"))
                {
                    returnit.Visible = true;
                    teslim.Visible = true;
                }
                else if (stat.Equals("iade edildi"))
                {
                    
                }
                else if (stat.Equals("teslim edildi"))
                {
                    
                }

            }
            catch (Exception ex)
            {
                
            }
            
        }

        protected void returnit_Click(object sender, EventArgs e)
        {
            con1.Open();
            SqlCommand cmd3 = new SqlCommand("UPDATE  Shipments set CurrentStatus='iade edildi' , Rdate='" + DateTime.UtcNow + "' where id = " + sid + "", con1);
            cmd3.ExecuteNonQuery();
            con1.Close();
        }

        protected void teslim_Click(object sender, EventArgs e)
        {
            con1.Open();
            SqlCommand cmd3 = new SqlCommand("UPDATE  Shipments set CurrentStatus='teslim edildi' , Rdate='" + DateTime.UtcNow + "' where id = " + sid + "", con1);
            cmd3.ExecuteNonQuery();
            con1.Close();
        }

        protected void yolda_Click(object sender, EventArgs e)
        {
            con1.Open();
            SqlCommand cmd3 = new SqlCommand("UPDATE  Shipments set CurrentStatus='yolda' where id = "+sid+" ", con1);
            cmd3.ExecuteNonQuery();
            con1.Close();
        }
    }
}