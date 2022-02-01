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
 
    public partial class WebForm6 : System.Web.UI.Page
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=webbased;Integrated Security=True");
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else if(Session["Role"].Equals("employee"))
            {
                Response.Redirect("employee.aspx");
            }
            if (Session["Role"].Equals("manager"))
            {
                link1.Visible = false;
            }
            Label2.Text = "CARGO/::" + Session["firstname"].ToString();
            
            if (!IsPostBack)
            {
                msg.Visible = false;
                msg3.Visible = false;
                msg2.Visible = false;
                msg4.Visible = false;
                AddNew.Visible = false;
                datagrid.Visible = false;
                TextBox2.Visible = false;
                bige.Visible = false;
                SCity.Items.Insert(0, new ListItem("ADANA", "01"));
                SCity.Items.Insert(1, new ListItem("ADIYAMAN", "02"));
                SCity.Items.Insert(2, new ListItem("AFYONKARAHİSAR", "03"));
                SCity.Items.Insert(3, new ListItem("AĞRI", "04"));
                SCity.Items.Insert(4, new ListItem("AMASYA", "05"));
                SCity.Items.Insert(5, new ListItem("ANKARA", "06"));
                SCity.Items.Insert(6, new ListItem("ANTALYA", "07"));
                SCity.Items.Insert(7, new ListItem("ARTVİN", "08"));
                SCity.Items.Insert(8, new ListItem("AYDIN", "09"));
                SCity.Items.Insert(9, new ListItem("BALIKESİR", "10"));
                SCity.Items.Insert(10, new ListItem("BİLECİK", "11"));
                SCity.Items.Insert(11, new ListItem("BİNGÖL", "12"));
                SCity.Items.Insert(12, new ListItem("BİTLİS", "13"));
                SCity.Items.Insert(13, new ListItem("BOLU	", "14"));
                SCity.Items.Insert(14, new ListItem("BURDUR", "15"));
                SCity.Items.Insert(15, new ListItem("BURSA", "16"));
                SCity.Items.Insert(16, new ListItem("ÇANAKKALE", "17"));
                SCity.Items.Insert(17, new ListItem("ÇANKIRI", "18"));
                SCity.Items.Insert(18, new ListItem("ÇORUM", "19"));
                SCity.Items.Insert(19, new ListItem("DENİZLİ", "20"));
                SCity.Items.Insert(20, new ListItem("DİYARBAKIR", "21"));
                SCity.Items.Insert(21, new ListItem("EDİRNE", "22"));
                SCity.Items.Insert(22, new ListItem("ELAZIĞ", "23"));
                SCity.Items.Insert(23, new ListItem("ERZİNCAN", "24"));
                SCity.Items.Insert(24, new ListItem("ERZURUM", "25"));
                SCity.Items.Insert(25, new ListItem("ESKİŞEHİR", "26"));
                SCity.Items.Insert(26, new ListItem("GAZİANTEP", "27"));
                SCity.Items.Insert(27, new ListItem("GİRESUN", "28"));
                SCity.Items.Insert(28, new ListItem("GÜMÜŞHANE", "29"));
                SCity.Items.Insert(29, new ListItem("HAKKARİ", "30"));
                SCity.Items.Insert(30, new ListItem("HATAY", "31"));
                SCity.Items.Insert(31, new ListItem("ISPARTA", "32"));
                SCity.Items.Insert(32, new ListItem("MERSİN", "33"));
                SCity.Items.Insert(33, new ListItem("İSTANBUL", "34"));
                SCity.Items.Insert(34, new ListItem("İZMİR", "35"));
                SCity.Items.Insert(35, new ListItem("KARS", "36"));
                SCity.Items.Insert(36, new ListItem("KASTAMONU", "37"));
                SCity.Items.Insert(37, new ListItem("KAYSERİ", "38"));
                SCity.Items.Insert(38, new ListItem("KIRKLARELİ", "39"));
                SCity.Items.Insert(39, new ListItem("KIRŞEHİR", "40"));
                SCity.Items.Insert(40, new ListItem("KOCAELİ", "41"));
                SCity.Items.Insert(41, new ListItem("KONYA", "42"));
                SCity.Items.Insert(42, new ListItem("KÜTAHYA", "43"));
                SCity.Items.Insert(43, new ListItem("MALATYA", "44"));
                SCity.Items.Insert(44, new ListItem("MANİSA", "45"));
                SCity.Items.Insert(45, new ListItem("KAHRAMANMARAŞ", "46"));
                SCity.Items.Insert(46, new ListItem("MARDİN", "47"));
                SCity.Items.Insert(47, new ListItem("MUĞLA", "48"));
                SCity.Items.Insert(48, new ListItem("MUŞ", "49"));
                SCity.Items.Insert(49, new ListItem("NEVŞEHİR", "50"));
                SCity.Items.Insert(50, new ListItem("NİĞDE	", "51"));
                SCity.Items.Insert(51, new ListItem("ORDU", "52"));
                SCity.Items.Insert(52, new ListItem("RİZE", "53"));
                SCity.Items.Insert(53, new ListItem("SAKARYA", "54"));
                SCity.Items.Insert(54, new ListItem("SAMSUN", "55"));
                SCity.Items.Insert(55, new ListItem("SİİRT", "56"));
                SCity.Items.Insert(56, new ListItem("SİNOP", "57"));
                SCity.Items.Insert(57, new ListItem("SİVAS", "58"));
                SCity.Items.Insert(58, new ListItem("TEKİRDAĞ", "59"));
                SCity.Items.Insert(59, new ListItem("TOKAT", "60"));
                SCity.Items.Insert(60, new ListItem("TRABZON", "61"));
                SCity.Items.Insert(61, new ListItem("TUNCELİ", "62"));
                SCity.Items.Insert(62, new ListItem("ŞANLIURFA", "63"));
                SCity.Items.Insert(63, new ListItem("UŞAK	", "64"));
                SCity.Items.Insert(64, new ListItem("VAN	", "65"));
                SCity.Items.Insert(65, new ListItem("YOZGAT", "66"));
                SCity.Items.Insert(66, new ListItem("ZONGULDAK", "67"));
                SCity.Items.Insert(67, new ListItem("AKSARAY", "68"));
                SCity.Items.Insert(68, new ListItem("BAYBURT", "69"));
                SCity.Items.Insert(69, new ListItem("KARAMAN", "70"));
                SCity.Items.Insert(70, new ListItem("KIRIKKALE", "71"));
                SCity.Items.Insert(71, new ListItem("BATMAN", "72"));
                SCity.Items.Insert(72, new ListItem("ŞIRNAK", "73"));
                SCity.Items.Insert(73, new ListItem("BARTIN", "74"));
                SCity.Items.Insert(74, new ListItem("ARDAHAN", "75"));
                SCity.Items.Insert(75, new ListItem("IĞDIR", "76"));
                SCity.Items.Insert(76, new ListItem("YALOVA", "77"));
                SCity.Items.Insert(77, new ListItem("KARABÜK", "78"));
                SCity.Items.Insert(78, new ListItem("KİLİS", "79"));
                SCity.Items.Insert(79, new ListItem("OSMANİYE", "80"));
                SCity.Items.Insert(80, new ListItem("DÜZCE", "81"));

                RCity.Items.Insert(0, new ListItem("ADANA", "01"));
                RCity.Items.Insert(1, new ListItem("ADIYAMAN", "02"));
                RCity.Items.Insert(2, new ListItem("AFYONKARAHİSAR", "03"));
                RCity.Items.Insert(3, new ListItem("AĞRI", "04"));
                RCity.Items.Insert(4, new ListItem("AMASYA", "05"));
                RCity.Items.Insert(5, new ListItem("ANKARA", "06"));
                RCity.Items.Insert(6, new ListItem("ANTALYA", "07"));
                RCity.Items.Insert(7, new ListItem("ARTVİN", "08"));
                RCity.Items.Insert(8, new ListItem("AYDIN", "09"));
                RCity.Items.Insert(9, new ListItem("BALIKESİR", "10"));
                RCity.Items.Insert(10, new ListItem("BİLECİK", "11"));
                RCity.Items.Insert(11, new ListItem("BİNGÖL", "12"));
                RCity.Items.Insert(12, new ListItem("BİTLİS", "13"));
                RCity.Items.Insert(13, new ListItem("BOLU	", "14"));
                RCity.Items.Insert(14, new ListItem("BURDUR", "15"));
                RCity.Items.Insert(15, new ListItem("BURSA", "16"));
                RCity.Items.Insert(16, new ListItem("ÇANAKKALE", "17"));
                RCity.Items.Insert(17, new ListItem("ÇANKIRI", "18"));
                RCity.Items.Insert(18, new ListItem("ÇORUM", "19"));
                RCity.Items.Insert(19, new ListItem("DENİZLİ", "20"));
                RCity.Items.Insert(20, new ListItem("DİYARBAKIR", "21"));
                RCity.Items.Insert(21, new ListItem("EDİRNE", "22"));
                RCity.Items.Insert(22, new ListItem("ELAZIĞ", "23"));
                RCity.Items.Insert(23, new ListItem("ERZİNCAN", "24"));
                RCity.Items.Insert(24, new ListItem("ERZURUM", "25"));
                RCity.Items.Insert(25, new ListItem("ESKİŞEHİR", "26"));
                RCity.Items.Insert(26, new ListItem("GAZİANTEP", "27"));
                RCity.Items.Insert(27, new ListItem("GİRESUN", "28"));
                RCity.Items.Insert(28, new ListItem("GÜMÜŞHANE", "29"));
                RCity.Items.Insert(29, new ListItem("HAKKARİ", "30"));
                RCity.Items.Insert(30, new ListItem("HATAY", "31"));
                RCity.Items.Insert(31, new ListItem("ISPARTA", "32"));
                RCity.Items.Insert(32, new ListItem("MERSİN", "33"));
                RCity.Items.Insert(33, new ListItem("İSTANBUL", "34"));
                RCity.Items.Insert(34, new ListItem("İZMİR", "35"));
                RCity.Items.Insert(35, new ListItem("KARS", "36"));
                RCity.Items.Insert(36, new ListItem("KASTAMONU", "37"));
                RCity.Items.Insert(37, new ListItem("KAYSERİ", "38"));
                RCity.Items.Insert(38, new ListItem("KIRKLARELİ", "39"));
                RCity.Items.Insert(39, new ListItem("KIRŞEHİR", "40"));
                RCity.Items.Insert(40, new ListItem("KOCAELİ", "41"));
                RCity.Items.Insert(41, new ListItem("KONYA", "42"));
                RCity.Items.Insert(42, new ListItem("KÜTAHYA", "43"));
                RCity.Items.Insert(43, new ListItem("MALATYA", "44"));
                RCity.Items.Insert(44, new ListItem("MANİSA", "45"));
                RCity.Items.Insert(45, new ListItem("KAHRAMANMARAŞ", "46"));
                RCity.Items.Insert(46, new ListItem("MARDİN", "47"));
                RCity.Items.Insert(47, new ListItem("MUĞLA", "48"));
                RCity.Items.Insert(48, new ListItem("MUŞ", "49"));
                RCity.Items.Insert(49, new ListItem("NEVŞEHİR", "50"));
                RCity.Items.Insert(50, new ListItem("NİĞDE	", "51"));
                RCity.Items.Insert(51, new ListItem("ORDU", "52"));
                RCity.Items.Insert(52, new ListItem("RİZE", "53"));
                RCity.Items.Insert(53, new ListItem("SAKARYA", "54"));
                RCity.Items.Insert(54, new ListItem("SAMSUN", "55"));
                RCity.Items.Insert(55, new ListItem("SİİRT", "56"));
                RCity.Items.Insert(56, new ListItem("SİNOP", "57"));
                RCity.Items.Insert(57, new ListItem("SİVAS", "58"));
                RCity.Items.Insert(58, new ListItem("TEKİRDAĞ", "59"));
                RCity.Items.Insert(59, new ListItem("TOKAT", "60"));
                RCity.Items.Insert(60, new ListItem("TRABZON", "61"));
                RCity.Items.Insert(61, new ListItem("TUNCELİ", "62"));
                RCity.Items.Insert(62, new ListItem("ŞANLIURFA", "63"));
                RCity.Items.Insert(63, new ListItem("UŞAK	", "64"));
                RCity.Items.Insert(64, new ListItem("VAN	", "65"));
                RCity.Items.Insert(65, new ListItem("YOZGAT", "66"));
                RCity.Items.Insert(66, new ListItem("ZONGULDAK", "67"));
                RCity.Items.Insert(67, new ListItem("AKSARAY", "68"));
                RCity.Items.Insert(68, new ListItem("BAYBURT", "69"));
                RCity.Items.Insert(69, new ListItem("KARAMAN", "70"));
                RCity.Items.Insert(70, new ListItem("KIRIKKALE", "71"));
                RCity.Items.Insert(71, new ListItem("BATMAN", "72"));
                RCity.Items.Insert(72, new ListItem("ŞIRNAK", "73"));
                RCity.Items.Insert(73, new ListItem("BARTIN", "74"));
                RCity.Items.Insert(74, new ListItem("ARDAHAN", "75"));
                RCity.Items.Insert(75, new ListItem("IĞDIR", "76"));
                RCity.Items.Insert(76, new ListItem("YALOVA", "77"));
                RCity.Items.Insert(77, new ListItem("KARABÜK", "78"));
                RCity.Items.Insert(78, new ListItem("KİLİS", "79"));
                RCity.Items.Insert(79, new ListItem("OSMANİYE", "80"));
                RCity.Items.Insert(80, new ListItem("DÜZCE", "81"));

            }
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
        protected void ADD_Click(object sender, EventArgs e)
        {
            Update.Visible = false;
            Delete.Visible = false;
            search.Visible = false;
            AddNew.Visible = true;
            datagrid.Visible = false;
        }

        protected void Manage_Click(object sender, EventArgs e)
        {
            Update.Visible = true;
            Delete.Visible = true;
            AddNew.Visible = false;
            search.Visible = true;
            datagrid.Visible = false;
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            msg3.Visible = false;
            msg2.Visible = false;
            msg.Visible = false;
            msg4.Visible = false;
            float w = 0;
            float z = 0;
            float y = 0;
            float x = 0;
            if (!String.IsNullOrEmpty(Xd.Text))
            {
                x = (float.Parse(Xd.Text.Trim()) / 100);
            }
            if (!String.IsNullOrEmpty(Yd.Text))
            {
                y = (float.Parse(Yd.Text.Trim()) / 100);
            }
            if (!String.IsNullOrEmpty(Zd.Text))
            {
                z = (float.Parse(Zd.Text.Trim()) / 100);
            }
            if (!String.IsNullOrEmpty(weight.Text))
            {
                w = (float.Parse(weight.Text.Trim()) / 100);
            }
            float shipment_price = (x * y * z * 40) + w;
            try
            {
                con1.Open();
                SqlCommand cmd3 = new SqlCommand("UPDATE Shipments SET  Price ='" + shipment_price + "',TypeOfShipment='" + ShipmentType.SelectedValue + "' , PackageWeight='" + float.Parse(weight.Text.Trim()) + "' ,  PackageDx='" + float.Parse(Xd.Text.Trim()) + "' , PackageDy='" + float.Parse(Yd.Text.Trim()) + "' , PackageDz='" + float.Parse(Zd.Text.Trim()) + "' , SenderFirstName='" + SFname.Text.Trim() + "' , SenderLastName='" + SLname.Text.Trim() + "' , SenderCity='" + SCity.Text.Trim() + "' , RecieverFirstName='" + RFname.Text.Trim() + "' ,  RecieverLastName='" + RLname.Text.Trim() + "' , RecieverCity='" + RCity.Text.Trim() + "' where id='" + datagrid.SelectedRow.Cells[0] + "' ", con1);
                cmd3.ExecuteNonQuery();
                cmd3.Dispose();
                con1.Close();
                datagrid.DataBind();
                msg3.Visible = true;
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
                try
                {
                    con1.Open();
                    SqlCommand cmd2 = new SqlCommand("DELETE FROM Shipments where id='" + datagrid.SelectedRow.Cells[0] + "'", con1);

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

        protected void AddNew_Click(object sender, EventArgs e)
        {
            msg3.Visible = false;
            msg2.Visible = false;
            msg.Visible = false;
            msg4.Visible = false;
            float w = 0;
            float z = 0;
            float y = 0;
            float x = 0;
            if (!String.IsNullOrEmpty(Xd.Text))
            {
                x = (float.Parse(Xd.Text.Trim()) / 100);
            }
            if (!String.IsNullOrEmpty(Yd.Text))
            {
                y = (float.Parse(Yd.Text.Trim()) / 100);
            }
            if (!String.IsNullOrEmpty(Zd.Text))
            {
                z = (float.Parse(Zd.Text.Trim()) / 100);
            }
            if (!String.IsNullOrEmpty(weight.Text))
            {
                w = (float.Parse(weight.Text.Trim()) / 100);
            }
            float shipment_price = (x * y * z * 40) + w;
            try
            {
                con1.Open();
                    SqlCommand cmd3 = new SqlCommand("insert into Shipments (Price , TypeOfShipment, PackageWeight , PackageDx , PackageDy , PackageDz , SenderFirstName  , SenderLastName , SenderCity , RecieverFirstName , RecieverLastName , RecieverCity ,CurrentStatus , Sdate ) " +
                        "values ('" + shipment_price + "','" + ShipmentType.SelectedValue + "' , '" + float.Parse(weight.Text.Trim()) + "' , '" + float.Parse(Xd.Text.Trim()) + "' , '" + float.Parse(Yd.Text.Trim()) + "' , '" + float.Parse(Zd.Text.Trim()) + "' , '" + SFname.Text.Trim() + "' , '" + SLname.Text.Trim() + "' , '" + SCity.SelectedValue + "' , '" + RFname.Text.Trim() + "' , '" + RLname.Text.Trim() + "' , '" + RCity.SelectedValue + "' , 'Göndericiden Teslim alındı' , '" + DateTime.UtcNow + "') SELECT SCOPE_IDENTITY() ", con1);
               
                   SqlDataReader dr = cmd3.ExecuteReader();
                while (dr.Read())
                {
                    msg3.Text = "Shipment has been added successfully id = " + dr.GetValue(0).ToString() + "";
                    
                }
                    con1.Close();
                
                    msg3.Visible = true;

            }
            catch (Exception ex)
            {
                msg.Text = ex.Message;
                msg.Visible=true;
            }

            ADD_Click(sender, e);
        }

        protected void Calculate_Price(object sender, EventArgs e)
        {
            float w = 0;
            float z = 0;
            float y = 0;
            float x = 0;
            if (!String.IsNullOrEmpty(Xd.Text))
            {
               x = (float.Parse(Xd.Text.Trim()) / 100);
            }
            if (!String.IsNullOrEmpty(Yd.Text))
            {
                y = (float.Parse(Yd.Text.Trim()) / 100);
            }
            if (!String.IsNullOrEmpty(Zd.Text))
            {
                z = (float.Parse(Zd.Text.Trim()) / 100);
            }
            if (!String.IsNullOrEmpty(weight.Text))
            {
                w = (float.Parse(weight.Text.Trim()) / 100);
            }
            float shipment_price = ( x * y * z * 40 ) + w  ;
            price.Text = "Price : " + shipment_price.ToString() +" ₺";
        }

      

        protected void searchfor_Click(object sender, EventArgs e)
        {
            if (Searchtype.SelectedValue.Equals("id"))
            {
                SqlDataSource1.SelectCommand = "SELECT  * from Shipments where  id = '" + TextBox1.Text.Trim() + "'";
            }
            else if (Searchtype.SelectedValue.Equals("Sname"))
            {
                SqlDataSource1.SelectCommand = "SELECT  * from Shipments where  SenderFirstName = '" + TextBox1.Text.Trim() + "' AND SenderLastName = '" + TextBox2.Text.Trim() + "'";
            }
            else if (Searchtype.SelectedValue.Equals("Rname"))
            {
                SqlDataSource1.SelectCommand = "SELECT  * from Shipments where  RecieverFirstName = '" + TextBox1.Text.Trim() + "' AND RecieverLastName = '" + TextBox2.Text.Trim() + "'";
            }
            SqlDataSource1.DataBind();
            datagrid.DataBind();
            datagrid.Visible = true;
            if (datagrid.Rows.Count == 0)
            {
                bige.Visible = true;
            }
            else
            {
                bige.Visible = false;
            }
        }

        protected void Searchtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Searchtype.SelectedValue.Equals("id"))
            {
                TextBox2.Visible= false;
            }
            else
            {
                TextBox2.Visible = true;
            }
        }
        protected void datagrid_SelectedIndexChanged(object sender, EventArgs e)
        {
           int id = Convert.ToInt32( datagrid.SelectedRow.Cells[0].Text);
            try
            {
                con1.Open();
                SqlCommand cmd3 = new SqlCommand("select * from Shipments where id = '"+id+"'", con1);

                SqlDataReader dr = cmd3.ExecuteReader();
                while (dr.Read())
                {
                    ShipmentType.SelectedValue = dr.GetValue(1).ToString();
                    weight.Text = dr.GetValue(2).ToString();
                    Xd.Text     = dr.GetValue(3).ToString();
                    Yd.Text     = dr.GetValue(4).ToString();
                    Zd.Text     = dr.GetValue(5).ToString();
                    SFname.Text = dr.GetValue(7).ToString();
                    SLname.Text = dr.GetValue(8).ToString();
                    RFname.Text = dr.GetValue(10).ToString();
                    RLname.Text = dr.GetValue(11).ToString();
                    RCity.SelectedValue = dr.GetValue(12).ToString();
                    SCity.SelectedValue = dr.GetValue(9).ToString();
                }
                con1.Close();

            }
            catch (Exception ex)
            {
                msg.Text = ex.Message;
                msg.Visible = true;
            }
        }
        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Home.aspx");

        }
    }
}