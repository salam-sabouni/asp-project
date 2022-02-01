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
    public partial class WebForm8 : System.Web.UI.Page
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=webbased;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                getinf.Visible = false;
            }
        }

        protected void search_Click(object sender, EventArgs e)
        {
            string[] cities = new String[81];
            cities[0] ="ADANA";
            cities[1] ="ADIYAMAN"              ;
            cities[2] ="AFYONKARAHİSAR"        ;
            cities[3] ="AĞRI"                  ;
            cities[4] ="AMASYA"                ;
            cities[5] ="ANKARA"                ;
            cities[6] ="ANTALYA"               ;
            cities[7] ="ARTVİN"                ;
            cities[8] ="AYDIN"                 ;
            cities[9] ="BALIKESİR"             ;
            cities[10] ="BİLECİK"               ;
            cities[11] ="BİNGÖL"                ;
            cities[12] ="BİTLİS"                ;
            cities[13] ="BOLU"                  ;
            cities[14] ="BURDUR"                ;
            cities[15] ="BURSA"                 ;
            cities[16] ="ÇANAKKALE"             ;
            cities[17] ="ÇANKIRI"               ;
            cities[18] ="ÇORUM"                 ;
            cities[19] ="DENİZLİ"               ;
            cities[20] ="DİYARBAKIR"            ;
            cities[21] ="EDİRNE"                ;
            cities[22] ="ELAZIĞ"                ;
            cities[23] ="ERZİNCAN"              ;
            cities[24] ="ERZURUM"               ;
            cities[25] ="ESKİŞEHİR"             ;
            cities[26] ="GAZİANTEP"             ;
            cities[27] ="GİRESUN"               ;
            cities[28] ="GÜMÜŞHANE"             ;
            cities[29] ="HAKKARİ"               ;
            cities[30] ="HATAY"                 ;
            cities[31] ="ISPARTA"               ;
            cities[32] ="MERSİN"                ;
            cities[33] ="İSTANBUL"              ;
            cities[34] ="İZMİR"                 ;
            cities[35] ="KARS"                  ;
            cities[36] ="KASTAMONU"             ;
            cities[37] ="KAYSERİ"               ;
            cities[38] ="KIRKLARELİ"            ;
            cities[39] ="KIRŞEHİR"              ;
            cities[40] ="KOCAELİ"               ;
            cities[41] ="KONYA"                 ;
            cities[42] ="KÜTAHYA"               ;
            cities[43] ="MALATYA"               ;
            cities[44] ="MANİSA"                ;
            cities[45] ="KAHRAMANMARAŞ"         ;
            cities[46] ="MARDİN"                ;
            cities[47] ="MUĞLA"                 ;
            cities[48] ="MUŞ"                   ;
            cities[49] ="NEVŞEHİR"              ;
            cities[50] ="NİĞDE	"             ;
            cities[51] ="ORDU"                  ;
            cities[52] ="RİZE"                  ;
            cities[53] ="SAKARYA"               ;
            cities[54] ="SAMSUN"                ;
            cities[55] ="SİİRT"                 ;
            cities[56] ="SİNOP"                 ;
            cities[57] ="SİVAS"                 ;
            cities[58] ="TEKİRDAĞ"              ;
            cities[59] ="TOKAT"                 ;
            cities[60] ="TRABZON"               ;
            cities[61] ="TUNCELİ"               ;
            cities[62] ="ŞANLIURFA"             ;
            cities[63] ="UŞAK"                  ;
            cities[64] ="VAN"                   ;
            cities[65] ="YOZGAT"                ;
            cities[66] ="ZONGULDAK"             ;
            cities[67] ="AKSARAY"               ;
            cities[68] ="BAYBURT"               ;
            cities[69] ="KARAMAN"               ;
            cities[70] ="KIRIKKALE"             ;
            cities[71] ="BATMAN"                ;
            cities[72] ="ŞIRNAK"                ;
            cities[73] ="BARTIN"                ;
            cities[74] ="ARDAHAN"               ;
            cities[75] ="IĞDIR"                 ;
            cities[76] ="YALOVA"                ;
            cities[77] ="KARABÜK"               ;
            cities[78] ="KİLİS"                 ;
            cities[79] ="OSMANİYE"              ;
            cities[80] = "DÜZCE";
            
            try
            {
                con1.Open();
                SqlCommand cmd3 = new SqlCommand("select  SenderFirstName , SenderLastName , RecieverFirstName , RecieverLastName , SenderCity , RecieverCity ,Sdate , Rdate , CurrentStatus from Shipments where id = '" + id.Text.Trim() + "'", con1);
                SqlDataReader dr = cmd3.ExecuteReader();
                if(dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Sdate.Text = " gönderme tarihi : " + dr.GetValue(6).ToString() + "";

                        if (dr.GetValue(8).ToString().Equals("teslim edildi"))
                        {
                            details.Text = "teslim edildi , tarih : " + dr.GetValue(7).ToString() + "";
                        }
                        if (dr.GetValue(8).ToString().Equals("iade edildi"))
                        {
                            details.Text = "iade edildi , tarih : " + dr.GetValue(7).ToString() + "";
                        }
                        else
                        {
                            details.Text = "Gönderi durumu : " + dr.GetValue(8).ToString() + "";
                        }

                        Sname.Text = " Sender's name : " + dr.GetValue(0).ToString() + "  " + dr.GetValue(1).ToString() + "";
                        Scity.Text = " Sender's city : " + cities[Convert.ToInt32(dr.GetValue(4).ToString()) - 1] + "";
                        Rname.Text = " Reciever's name : " + dr.GetValue(2).ToString() + "  " + dr.GetValue(3).ToString() + "";
                        Rcity.Text = " Reciever's city : " + cities[Convert.ToInt32(dr.GetValue(5).ToString()) - 1] + "";
                    }
                    getinf.Visible = true;
                }    
                con1.Close();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}