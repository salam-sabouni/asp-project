using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class calculate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                price.Visible = false;
                Sender.Items.Insert(0, new ListItem("ADANA", "01"));
                Sender.Items.Insert(1, new ListItem("ADIYAMAN", "02"));
                Sender.Items.Insert(2, new ListItem("AFYONKARAHİSAR", "03"));
                Sender.Items.Insert(3, new ListItem("AĞRI", "04"));
                Sender.Items.Insert(4, new ListItem("AMASYA", "05"));
                Sender.Items.Insert(5, new ListItem("ANKARA", "06"));
                Sender.Items.Insert(6, new ListItem("ANTALYA", "07"));
                Sender.Items.Insert(7, new ListItem("ARTVİN", "08"));
                Sender.Items.Insert(8, new ListItem("AYDIN", "09"));
                Sender.Items.Insert(9, new ListItem("BALIKESİR", "10"));
                Sender.Items.Insert(10, new ListItem("BİLECİK", "11"));
                Sender.Items.Insert(11, new ListItem("BİNGÖL", "12"));
                Sender.Items.Insert(12, new ListItem("BİTLİS", "13"));
                Sender.Items.Insert(13, new ListItem("BOLU	", "14"));
                Sender.Items.Insert(14, new ListItem("BURDUR", "15"));
                Sender.Items.Insert(15, new ListItem("BURSA", "16"));
                Sender.Items.Insert(16, new ListItem("ÇANAKKALE", "17"));
                Sender.Items.Insert(17, new ListItem("ÇANKIRI", "18"));
                Sender.Items.Insert(18, new ListItem("ÇORUM", "19"));
                Sender.Items.Insert(19, new ListItem("DENİZLİ", "20"));
                Sender.Items.Insert(20, new ListItem("DİYARBAKIR", "21"));
                Sender.Items.Insert(21, new ListItem("EDİRNE", "22"));
                Sender.Items.Insert(22, new ListItem("ELAZIĞ", "23"));
                Sender.Items.Insert(23, new ListItem("ERZİNCAN", "24"));
                Sender.Items.Insert(24, new ListItem("ERZURUM", "25"));
                Sender.Items.Insert(25, new ListItem("ESKİŞEHİR", "26"));
                Sender.Items.Insert(26, new ListItem("GAZİANTEP", "27"));
                Sender.Items.Insert(27, new ListItem("GİRESUN", "28"));
                Sender.Items.Insert(28, new ListItem("GÜMÜŞHANE", "29"));
                Sender.Items.Insert(29, new ListItem("HAKKARİ", "30"));
                Sender.Items.Insert(30, new ListItem("HATAY", "31"));
                Sender.Items.Insert(31, new ListItem("ISPARTA", "32"));
                Sender.Items.Insert(32, new ListItem("MERSİN", "33"));
                Sender.Items.Insert(33, new ListItem("İSTANBUL", "34"));
                Sender.Items.Insert(34, new ListItem("İZMİR", "35"));
                Sender.Items.Insert(35, new ListItem("KARS", "36"));
                Sender.Items.Insert(36, new ListItem("KASTAMONU", "37"));
                Sender.Items.Insert(37, new ListItem("KAYSERİ", "38"));
                Sender.Items.Insert(38, new ListItem("KIRKLARELİ", "39"));
                Sender.Items.Insert(39, new ListItem("KIRŞEHİR", "40"));
                Sender.Items.Insert(40, new ListItem("KOCAELİ", "41"));
                Sender.Items.Insert(41, new ListItem("KONYA", "42"));
                Sender.Items.Insert(42, new ListItem("KÜTAHYA", "43"));
                Sender.Items.Insert(43, new ListItem("MALATYA", "44"));
                Sender.Items.Insert(44, new ListItem("MANİSA", "45"));
                Sender.Items.Insert(45, new ListItem("KAHRAMANMARAŞ", "46"));
                Sender.Items.Insert(46, new ListItem("MARDİN", "47"));
                Sender.Items.Insert(47, new ListItem("MUĞLA", "48"));
                Sender.Items.Insert(48, new ListItem("MUŞ", "49"));
                Sender.Items.Insert(49, new ListItem("NEVŞEHİR", "50"));
                Sender.Items.Insert(50, new ListItem("NİĞDE	", "51"));
                Sender.Items.Insert(51, new ListItem("ORDU", "52"));
                Sender.Items.Insert(52, new ListItem("RİZE", "53"));
                Sender.Items.Insert(53, new ListItem("SAKARYA", "54"));
                Sender.Items.Insert(54, new ListItem("SAMSUN", "55"));
                Sender.Items.Insert(55, new ListItem("SİİRT", "56"));
                Sender.Items.Insert(56, new ListItem("SİNOP", "57"));
                Sender.Items.Insert(57, new ListItem("SİVAS", "58"));
                Sender.Items.Insert(58, new ListItem("TEKİRDAĞ", "59"));
                Sender.Items.Insert(59, new ListItem("TOKAT", "60"));
                Sender.Items.Insert(60, new ListItem("TRABZON", "61"));
                Sender.Items.Insert(61, new ListItem("TUNCELİ", "62"));
                Sender.Items.Insert(62, new ListItem("ŞANLIURFA", "63"));
                Sender.Items.Insert(63, new ListItem("UŞAK	", "64"));
                Sender.Items.Insert(64, new ListItem("VAN	", "65"));
                Sender.Items.Insert(65, new ListItem("YOZGAT", "66"));
                Sender.Items.Insert(66, new ListItem("ZONGULDAK", "67"));
                Sender.Items.Insert(67, new ListItem("AKSARAY", "68"));
                Sender.Items.Insert(68, new ListItem("BAYBURT", "69"));
                Sender.Items.Insert(69, new ListItem("KARAMAN", "70"));
                Sender.Items.Insert(70, new ListItem("KIRIKKALE", "71"));
                Sender.Items.Insert(71, new ListItem("BATMAN", "72"));
                Sender.Items.Insert(72, new ListItem("ŞIRNAK", "73"));
                Sender.Items.Insert(73, new ListItem("BARTIN", "74"));
                Sender.Items.Insert(74, new ListItem("ARDAHAN", "75"));
                Sender.Items.Insert(75, new ListItem("IĞDIR", "76"));
                Sender.Items.Insert(76, new ListItem("YALOVA", "77"));
                Sender.Items.Insert(77, new ListItem("KARABÜK", "78"));
                Sender.Items.Insert(78, new ListItem("KİLİS", "79"));
                Sender.Items.Insert(79, new ListItem("OSMANİYE", "80"));
                Sender.Items.Insert(80, new ListItem("DÜZCE", "81"));

                Reciever.Items.Insert(0, new ListItem("ADANA", "01"));
                Reciever.Items.Insert(1, new ListItem("ADIYAMAN", "02"));
                Reciever.Items.Insert(2, new ListItem("AFYONKARAHİSAR", "03"));
                Reciever.Items.Insert(3, new ListItem("AĞRI", "04"));
                Reciever.Items.Insert(4, new ListItem("AMASYA", "05"));
                Reciever.Items.Insert(5, new ListItem("ANKARA", "06"));
                Reciever.Items.Insert(6, new ListItem("ANTALYA", "07"));
                Reciever.Items.Insert(7, new ListItem("ARTVİN", "08"));
                Reciever.Items.Insert(8, new ListItem("AYDIN", "09"));
                Reciever.Items.Insert(9, new ListItem("BALIKESİR", "10"));
                Reciever.Items.Insert(10, new ListItem("BİLECİK", "11"));
                Reciever.Items.Insert(11, new ListItem("BİNGÖL", "12"));
                Reciever.Items.Insert(12, new ListItem("BİTLİS", "13"));
                Reciever.Items.Insert(13, new ListItem("BOLU	", "14"));
                Reciever.Items.Insert(14, new ListItem("BURDUR", "15"));
                Reciever.Items.Insert(15, new ListItem("BURSA", "16"));
                Reciever.Items.Insert(16, new ListItem("ÇANAKKALE", "17"));
                Reciever.Items.Insert(17, new ListItem("ÇANKIRI", "18"));
                Reciever.Items.Insert(18, new ListItem("ÇORUM", "19"));
                Reciever.Items.Insert(19, new ListItem("DENİZLİ", "20"));
                Reciever.Items.Insert(20, new ListItem("DİYARBAKIR", "21"));
                Reciever.Items.Insert(21, new ListItem("EDİRNE", "22"));
                Reciever.Items.Insert(22, new ListItem("ELAZIĞ", "23"));
                Reciever.Items.Insert(23, new ListItem("ERZİNCAN", "24"));
                Reciever.Items.Insert(24, new ListItem("ERZURUM", "25"));
                Reciever.Items.Insert(25, new ListItem("ESKİŞEHİR", "26"));
                Reciever.Items.Insert(26, new ListItem("GAZİANTEP", "27"));
                Reciever.Items.Insert(27, new ListItem("GİRESUN", "28"));
                Reciever.Items.Insert(28, new ListItem("GÜMÜŞHANE", "29"));
                Reciever.Items.Insert(29, new ListItem("HAKKARİ", "30"));
                Reciever.Items.Insert(30, new ListItem("HATAY", "31"));
                Reciever.Items.Insert(31, new ListItem("ISPARTA", "32"));
                Reciever.Items.Insert(32, new ListItem("MERSİN", "33"));
                Reciever.Items.Insert(33, new ListItem("İSTANBUL", "34"));
                Reciever.Items.Insert(34, new ListItem("İZMİR", "35"));
                Reciever.Items.Insert(35, new ListItem("KARS", "36"));
                Reciever.Items.Insert(36, new ListItem("KASTAMONU", "37"));
                Reciever.Items.Insert(37, new ListItem("KAYSERİ", "38"));
                Reciever.Items.Insert(38, new ListItem("KIRKLARELİ", "39"));
                Reciever.Items.Insert(39, new ListItem("KIRŞEHİR", "40"));
                Reciever.Items.Insert(40, new ListItem("KOCAELİ", "41"));
                Reciever.Items.Insert(41, new ListItem("KONYA", "42"));
                Reciever.Items.Insert(42, new ListItem("KÜTAHYA", "43"));
                Reciever.Items.Insert(43, new ListItem("MALATYA", "44"));
                Reciever.Items.Insert(44, new ListItem("MANİSA", "45"));
                Reciever.Items.Insert(45, new ListItem("KAHRAMANMARAŞ", "46"));
                Reciever.Items.Insert(46, new ListItem("MARDİN", "47"));
                Reciever.Items.Insert(47, new ListItem("MUĞLA", "48"));
                Reciever.Items.Insert(48, new ListItem("MUŞ", "49"));
                Reciever.Items.Insert(49, new ListItem("NEVŞEHİR", "50"));
                Reciever.Items.Insert(50, new ListItem("NİĞDE	", "51"));
                Reciever.Items.Insert(51, new ListItem("ORDU", "52"));
                Reciever.Items.Insert(52, new ListItem("RİZE", "53"));
                Reciever.Items.Insert(53, new ListItem("SAKARYA", "54"));
                Reciever.Items.Insert(54, new ListItem("SAMSUN", "55"));
                Reciever.Items.Insert(55, new ListItem("SİİRT", "56"));
                Reciever.Items.Insert(56, new ListItem("SİNOP", "57"));
                Reciever.Items.Insert(57, new ListItem("SİVAS", "58"));
                Reciever.Items.Insert(58, new ListItem("TEKİRDAĞ", "59"));
                Reciever.Items.Insert(59, new ListItem("TOKAT", "60"));
                Reciever.Items.Insert(60, new ListItem("TRABZON", "61"));
                Reciever.Items.Insert(61, new ListItem("TUNCELİ", "62"));
                Reciever.Items.Insert(62, new ListItem("ŞANLIURFA", "63"));
                Reciever.Items.Insert(63, new ListItem("UŞAK	", "64"));
                Reciever.Items.Insert(64, new ListItem("VAN	", "65"));
                Reciever.Items.Insert(65, new ListItem("YOZGAT", "66"));
                Reciever.Items.Insert(66, new ListItem("ZONGULDAK", "67"));
                Reciever.Items.Insert(67, new ListItem("AKSARAY", "68"));
                Reciever.Items.Insert(68, new ListItem("BAYBURT", "69"));
                Reciever.Items.Insert(69, new ListItem("KARAMAN", "70"));
                Reciever.Items.Insert(70, new ListItem("KIRIKKALE", "71"));
                Reciever.Items.Insert(71, new ListItem("BATMAN", "72"));
                Reciever.Items.Insert(72, new ListItem("ŞIRNAK", "73"));
                Reciever.Items.Insert(73, new ListItem("BARTIN", "74"));
                Reciever.Items.Insert(74, new ListItem("ARDAHAN", "75"));
                Reciever.Items.Insert(75, new ListItem("IĞDIR", "76"));
                Reciever.Items.Insert(76, new ListItem("YALOVA", "77"));
                Reciever.Items.Insert(77, new ListItem("KARABÜK", "78"));
                Reciever.Items.Insert(78, new ListItem("KİLİS", "79"));
                Reciever.Items.Insert(79, new ListItem("OSMANİYE", "80"));
                Reciever.Items.Insert(80, new ListItem("DÜZCE", "81"));
                Type.Items.Insert(0, new ListItem("Normal", "0"));
                Type.Items.Insert(1, new ListItem("By Air", "1"));
            }
        }

        protected void calc_Click(object sender, EventArgs e)
        {
            float wd = 0;
            float zd = 0;
            float yd = 0;
            float xd = 0;
            if (!String.IsNullOrEmpty(x.Text))
            {
                xd = (float.Parse(x.Text.Trim()) / 100);
            }
            if (!String.IsNullOrEmpty(y.Text))
            {
                yd = (float.Parse(y.Text.Trim()) / 100);
            }
            if (!String.IsNullOrEmpty(z.Text))
            {
                zd = (float.Parse(z.Text.Trim()) / 100);
            }
            if (!String.IsNullOrEmpty(w.Text))
            {
                wd = (float.Parse(w.Text.Trim()) / 100);
            }
            float shipment_price = (xd * yd * zd * 40) + wd;
            price.Visible = true;
            price.InnerText = "Price is : "+ shipment_price + "";
        }
    }
}