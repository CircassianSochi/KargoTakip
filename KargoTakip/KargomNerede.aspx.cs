using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KargoTakip
{
    public partial class KargomNerede : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanici_Adi"] == null)
            {
               Session["Kullanici_Adi"] = "";
               
                 
           }
          

            Text1.BackColor = System.Drawing.Color.White;

        }
        
         anatablo bu1 = new anatablo();
        protected void B1_Click(object sender, EventArgs e)
        {
            if (Text1.Text.ToString()=="")
            {
                MessageBox.Show("Lütfen Kargo Takip Kodunu Girin.");
            }

            else
            {
                try
                {
                    GridView1.Visible = true;
                    int id = bu1.Idvarmi(Convert.ToInt32(Text1.Text));
                    bu1.kapat();
                    bu1.ac();

                    SqlDataSource1.SelectCommand = "select KargoId,GondericiAdSad,SonDurum,AliciAdSad from Kargolar where KargoId=" + id + ";";
                    bu1.kapat();
                }
                catch (Exception)
                {

                    MessageBox.Show("Takip Kodunuzu Yanlış Girdiniz...");
                }
              
            }


        }
    }
}