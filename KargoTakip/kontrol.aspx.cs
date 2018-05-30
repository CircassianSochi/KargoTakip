using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KargoTakip
{
    public partial class kontrol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Text1.BackColor = System.Drawing.Color.White;
            Text2.BackColor = System.Drawing.Color.White;
            anatablo b1 = new anatablo();
            if (!IsPostBack)
            {

                if (Session["Kullanici_Adi"] == "" || Session["Kullanici_Adi"] == null)
                {
                    MessageBox.Show("Lütfen giriş yapın...");

                }
            }
             if (Session["Kullanici_Adi"] != "" && Session["Kullanici_Adi"] != null)
            {
                string username = Session["Kullanici_Adi"].ToString();
                if (b1.adminmi(username))
                {
                    Session["Kullanici_Adi"] = username;
                    Response.Redirect("PersonelIslemleri.aspx");
                }
                else
                {
                    MessageBox.Show("Bu sayfaya erişmek için 'admin' yetkinizin bulunması gerekmektedir...");
                }

            }


        }

        protected void B1_Click1(object sender, EventArgs e)
        {

            anatablo b1 = new anatablo();
            if (b1.adminmi(Text1.Text))
            {
                Session["Kullanici_Adi"] = Text1.Text;
                Response.Redirect("PersonelIslemleri.aspx");
            }
            else
                MessageBox.Show("Bu sayfaya erişim yetkiniz bulunmamaktadır..");
        }
    }
}