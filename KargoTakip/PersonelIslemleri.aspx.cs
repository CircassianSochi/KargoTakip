using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KargoTakip.Admin
{
    public partial class PersonelIslemleri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.BackColor = System.Drawing.Color.White;
            TextBox2.BackColor = System.Drawing.Color.White;
            TextBox3.BackColor = System.Drawing.Color.White;
            TextBox4.BackColor = System.Drawing.Color.White;
            TextBox5.BackColor = System.Drawing.Color.White;

        }
        anatablo b1 = new anatablo();

        
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "")
                {
                    MessageBox.Show("Tüm alanları Doldurun...");
                }
                else if(Page.IsValid)
                {
                    
                    b1.KullaniciGuncelle(TextBox1.Text, TextBox2.Text, TextBox5.Text, TextBox3.Text, TextBox4.Text);
                    SqlDataSource1.SelectCommand = "select adsad,TC,kullanici_tipi,kullanici_ad,kullanici_sifre from kullanicilar ";
                    MessageBox.Show("başarılı");
                    TextBox2.Enabled = true;

                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Düzenleme işleminde bir arıza oluştu  lütfen sistem sorumlusuna bildirin...");
            }
            
        }

    

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[1].Text;
            TextBox2.Text = GridView1.SelectedRow.Cells[2].Text;
            TextBox5.Text = GridView1.SelectedRow.Cells[3].Text;
            TextBox3.Text = GridView1.SelectedRow.Cells[4].Text;
            TextBox4.Text = GridView1.SelectedRow.Cells[5].Text;
            TextBox2.Enabled = false;

        }





        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (TextBox1.Text=="" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" )
            {
                MessageBox.Show("Tüm alanları Doldurun...");
            }
            else if(Page.IsValid)
            {

                try
                {
                    if (b1.kullanicivarmi(TextBox2.Text))
                    {
                        MessageBox.Show("Kullanıcı sisteme kayıtlıdır...");
                        return;
                    }
                    b1.KullaniciEkle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text);

                    SqlDataSource1.SelectCommand = "select adsad,TC,kullanici_tipi,kullanici_ad,kullanici_sifre from kullanicilar ";

                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Ekleme işleminde bir arıza oluştu lütfen sistem sorumlusuna bildirin...");
                }
            }
           
        }
        protected void Button3_Click1(object sender, EventArgs e)
        {
            try
            {
               
                if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "")
                {
                    MessageBox.Show("Lütfen silinecek personeli seçin");
                }
                else
                {
                    b1.kullanicisil(GridView1.SelectedRow.Cells[2].Text);
                    SqlDataSource1.SelectCommand = "select adsad,TC,kullanici_tipi,kullanici_ad,kullanici_sifre from kullanicilar ";
                    MessageBox.Show("başarılı");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silme işleminde bir sıkıntı oluştu lütfen sistem sorumlusuna bildirin...");

            }
            
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string KimlikNumarasi = TextBox2.Text;
            long KimlikSonHane = Convert.ToInt64(KimlikNumarasi.Substring(10));
            //TC Kimlik No uzunluğunu kontrol edelim
            if (KimlikNumarasi.Length != 11)
            {
                args.IsValid = false;
                return;
            }
            //TC Kİmlik no son hanenin çift olup olmadığını kontrol edelim
            if (KimlikSonHane % 2 == 1)
            {
                args.IsValid = false;
                return;
            }
            //İlk 10 hane toplamını alalım
            string OnHane = KimlikNumarasi.Substring(0, 10);
            int toplam = 0;
            foreach (char c in OnHane)
            {
                toplam += Convert.ToInt32(c.ToString());
            }
            //10 sane toplamını kontrol edelim
            if (toplam % 10 == KimlikSonHane)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}