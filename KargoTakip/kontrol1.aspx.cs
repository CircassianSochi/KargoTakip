using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KargoTakip
{
    public partial class konrol1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            anatablo b1 = new anatablo();
            if (Session["Kullanici_Adi"] == "" || Session["Kullanici_Adi"] == null)
            {

                Response.Redirect("Login.aspx");
            }
            else if (Session["Kullanici_Adi"] != "" && Session["Kullanici_Adi"] != null)
            {
                string username = Session["Kullanici_Adi"].ToString();
                if (b1.Kargocumu(username))
                {
                    Response.Redirect("KargoIslemleri.aspx");
                }
                else
                {
                    Response.Redirect("KargoIslemleri.aspx");
                }

            }
        }
    }
}