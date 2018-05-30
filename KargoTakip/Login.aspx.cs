using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KargoTakip.Account
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Text1.BackColor = System.Drawing.Color.White;
            Text2.BackColor = System.Drawing.Color.White;

        }
        protected void B1_Click1(object sender, EventArgs e)
        {

            anatablo b1 = new anatablo();
            if (Text1.Text == "" || Text2.Text == "")
            {
                MessageBox.Show("Bütün verileri eksiksiz girmelisiniz.");
            }
            else
            {
                if (b1.kullaniciDogrula(Text1.Text, Text2.Text))
                {
                    Session["Kullanici_Adi"] = Text1.Text;
                    Session.Timeout = 20;
                    if (b1.Kargocumu(Text1.Text))
                    {

                        //MessageBox.Show("Bu sayfaya erişim yetkiniz bulunmamaktadır..");
                        Response.Redirect("KargoIslemleri.aspx");

                    }
                    else
                        Response.Redirect("PersonelIslemleri.aspx");
                }


                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifreniz geçersiz.");

                }



            }
        }
    }
}
        





