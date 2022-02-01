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
    public partial class manageemployees : System.Web.UI.Page
    {
        
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=webbased;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"] == null)
            {
                Response.Redirect("home.aspx");
            }
            else if (Session["role"].Equals("manager") || Session["role"].Equals("employee"))
            {
                Response.Redirect("employee.aspx");
            }

            Label2.Text = "CARGO/::" + Session["firstname"].ToString();
            msg.Visible = false;
            msg3.Visible = false;
            msg2.Visible = false;
            msg4.Visible = false;
            AddNew.Visible = false;
            Manage.Visible = false;
        }
        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("home.aspx");

        }
        protected void Gridview1_SelectedIndexChanged(Object sender , EventArgs e)
        {
            Fname.Text = datagrid.SelectedRow.Cells[2].Text;
            Lname.Text = datagrid.SelectedRow.Cells[3].Text;
            Username.Text = datagrid.SelectedRow.Cells[1].Text;
            AccountType.SelectedValue = datagrid.SelectedRow.Cells[4].Text;


        }

        protected override void Render(HtmlTextWriter writer)
        {
            foreach (GridViewRow r in datagrid.Rows)
            {
                if (r.RowType == DataControlRowType.DataRow)
                {
                    r.ToolTip = "Click to select row";
                    r.Attributes["onclick"] = this.Page.ClientScript.GetPostBackClientHyperlink(this.datagrid, "Select$" + r.RowIndex, true);

                }
            }

            base.Render(writer);
        }


        protected void Update_Click(object sender, EventArgs e)
        {
            msg3.Visible = false;
            msg2.Visible = false;
            msg.Visible = false;
            msg4.Visible = false;
            try
            {
                con1.Open();
                
                    SqlCommand cmd2 = new SqlCommand("select * from Employee where UserName='" + Username.Text.Trim() + "'", con1);
                    SqlDataReader reader2 = cmd2.ExecuteReader();
                    if (reader2.HasRows && (!Username.Text.Trim().Equals(datagrid.SelectedRow.Cells[1].Text)))
                    {
                        msg.Visible = true;
                        Username.BorderColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        msg.Visible = false;
                        reader2.Close();
                        SqlCommand cmd3 = new SqlCommand("UPDATE Employee SET UserName='" + Username.Text.Trim() + "' , FirstName ='" + Fname.Text.Trim() + "' , LastName ='" + Lname.Text.Trim() + "' , UserRole ='" + AccountType.SelectedValue + "'  , UserPassword ='" + Password.Text.Trim() + "' WHERE UserName='" + datagrid.SelectedRow.Cells[1].Text + "'", con1);
                        cmd3.ExecuteNonQuery();
                        cmd3.Dispose();
                        con1.Close();
                        datagrid.DataBind();
                        msg.Visible = false;
                        msg3.Visible = true;
                }
                
            }
            catch (Exception ex)
            {

            }

        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            msg3.Visible = false;
            msg2.Visible = false;
            msg.Visible = false;
            msg4.Visible = false;
            if (!Username.Text.Trim().Equals(Session["username"]))
            {
                try
                {
                    con1.Open();
                    SqlCommand cmd2 = new SqlCommand("DELETE FROM Employee where UserName='" + Username.Text.Trim() + "'", con1);
                    
                        cmd2.ExecuteNonQuery();
                        cmd2.Dispose();
                        con1.Close();
                        datagrid.DataBind();
                        msg4.Visible = true;
                    

                }
                catch (Exception ex)
                {

                }
            }
        
            else
            {
                msg2.Visible = true;
            }
        }

        protected void ADD_Click(object sender, EventArgs e)
        {
            Update.Visible = false;
            Delete.Visible = false;
            AddNew.Visible = true;
            ADD.Visible = false;
            Manage.Visible = true;
        }

        protected void Manage_Click(object sender, EventArgs e)
        {
            Update.Visible = true;
            Delete.Visible = true;
            AddNew.Visible = false;
            ADD.Visible = true;
            Manage.Visible = false;
        }

        protected void AddNew_Click(object sender, EventArgs e)
        {
            msg3.Visible = false;
            msg2.Visible = false;
            msg.Visible = false;
            msg4.Visible = false;
            try
            {
                con1.Open();

                SqlCommand cmd2 = new SqlCommand("select * from Employee where UserName='" + Username.Text.Trim() + "'", con1);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.HasRows)
                {
                    msg.Visible = true;
                    Username.BorderColor = System.Drawing.Color.Red;
                }
                else
                {
                    msg.Visible = false;
                    reader2.Close();
                    SqlCommand cmd3 = new SqlCommand("insert into Employee (UserName, FirstName , LastName , UserRole , UserPassword ) values ('" + Username.Text.Trim() + "' , '" + Fname.Text.Trim() + "' , '" + Lname.Text.Trim() + "' , '" + AccountType.SelectedValue + "' , '" + Password.Text.Trim() + "') ", con1);
                    cmd3.ExecuteNonQuery();
                    cmd3.Dispose();
                    con1.Close();
                    datagrid.DataBind();
                    msg3.Text = "Account has been added successfully";
                    msg3.Visible = true;
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            ADD_Click(sender, e);
        }
    }
}