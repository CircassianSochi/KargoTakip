using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KargoTakip.Personel
{
    public partial class KargoIslemleri : System.Web.UI.Page
    {
        //string connection_string = "Data Source=Ahk;Initial Catalog=kargoTakip;Integrated Security=True";
        anatablo b1 = new anatablo();

        protected void Page_Load(object sender, EventArgs e)
        {
            Text1.BackColor = System.Drawing.Color.White;
            Text2.BackColor = System.Drawing.Color.White;
            Text3.BackColor = System.Drawing.Color.White;
            Text4.BackColor = System.Drawing.Color.White;
            Text5.BackColor = System.Drawing.Color.White;
            Text6.BackColor = System.Drawing.Color.White;
            GridView1.BackColor = System.Drawing.Color.White;
           

            if (!IsPostBack)
            {


                try
                {
                    b1.ac();
                    SqlCommand bag = new SqlCommand("Select id,sehir from Iller", b1.baglanti);
                    SqlDataAdapter DataAdapter = new SqlDataAdapter(bag);
                    DataSet DataSet = new DataSet();
                    DataAdapter.Fill(DataSet);
                    DD1.DataSource = DataSet;//drop down lara illeri veritabanından çekiyoruz
                    DD3.DataSource = DataSet;
                    DD1.DataTextField = "sehir";
                    DD1.DataValueField = "id";
                    DD3.DataTextField = "sehir";
                    DD3.DataValueField = "id";
                    DD1.DataBind();
                    DD3.DataBind();
                    DataSet.Clear();
                    b1.kapat();
                    lbltarih.Text = DateTime.Now.ToShortDateString();

                    //DD1.DataTextField = "SubeAdi";
                    //DD1.DataBind();
                    //DD1.Items.Insert(0, new ListItem("Seçiminiz...", "0"));
                    //DD1.SelectedIndex = 0;

                    //DD3.DataTextField = "SubeAdi";
                    //DD3.DataBind();
                    //DD3.Items.Insert(0, new ListItem("Seçiminiz...", "0"));
                    //DD3.SelectedIndex = 0;


                }
                catch (Exception)
                {


                }

            }
        }
       


     
        protected void DD1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DD1.SelectedIndex)+1;
            try
            {
                b1.kapat();
                b1.ac();
                SqlCommand bag1 = new SqlCommand("Select id,ilce from Ilceler where sehir='" + id + "' ", b1.baglanti);
                SqlDataAdapter DataAdapter1 = new SqlDataAdapter(bag1);
                DataSet DataSet1 = new DataSet();
                DataAdapter1.Fill(DataSet1);
                DD2.DataSource = DataSet1;
                DD2.DataTextField = "ilce";
                DD2.DataValueField = "id";
                DD2.DataBind();
                
                DataSet1.Clear();
                b1.kapat();
            }
            catch (Exception)
            {


            }
        }

        protected void DD2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        protected void DD3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DD3.SelectedIndex) + 1;
            try
            {

                b1.ac();
                SqlCommand bag2 = new SqlCommand("Select id,ilce from Ilceler where sehir='" + id + "' ", b1.baglanti);
                SqlDataAdapter DataAdapter2 = new SqlDataAdapter(bag2);
                DataSet DataSet2 = new DataSet();
                DataAdapter2.Fill(DataSet2);
                DD4.DataSource = DataSet2;
                DD4.DataTextField = "ilce";
                DD4.DataValueField = "id";
                DD4.DataBind();
                DataSet2.Clear();
                b1.kapat();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem arızası sistem yöneticisine başvurun...");

            }
        }

        protected void B1_Click1(object sender, EventArgs e)
        {
            if (Text1.Text == "" || Text2.Text == "" || Text3.Text == "" || Text4.Text == "" || Text6.Text == "" )
            {
                MessageBox.Show("Tüm Alanları Doldurun...");
            }
            else
            {
                try
                {
                    string sondurum = "kargo teslim alındı.";
                    string personel = Session["Kullanici_Adi"].ToString();
                    //anatablo b1 = new anatablo();
                    b1.UrunKaydet(Text1.Text, DD1.SelectedItem.ToString(), DD2.SelectedItem.ToString(), Text2.Text, Text3.Text, DD3.SelectedItem.ToString(), DD4.SelectedItem.ToString(), Text6.Text, Text4.Text, sondurum, personel, lbltarih.Text.ToString());


                    Response.Redirect(Request.RawUrl);

                }
                catch (Exception)
                {

                    MessageBox.Show("Sistem arızası sistem yöneticisine başvurun...");
                }
               

            }
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (Text5.Text=="")
            {
                MessageBox.Show("Son Durum Alanını Doldurun...");
            }
            else
            {
                try
                {
                    anatablo b1 = new anatablo();
                    b1.UrunKonumuGuncelle(Text5.Text.ToString(), Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text));
                    MessageBox.Show("Güncelleme Başarılı.");

                    Response.Redirect(Request.RawUrl);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sistem arızası sistem yöneticisine başvurun...");
                }
               
            }

        }
    }
}