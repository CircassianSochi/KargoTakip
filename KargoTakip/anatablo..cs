using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;

/// <summary>
/// Summary description for anatablo
/// </summary>
public class anatablo
{



    public SqlConnection baglanti = new SqlConnection();
    public SqlDataAdapter dataAdapter1 = new SqlDataAdapter();
    public SqlCommand SelectCommand = new SqlCommand();
    public DataSet dataSet1 = new DataSet();


    public SqlDataAdapter dataAdapter2 = new SqlDataAdapter();
    public SqlCommand SelectCommand2 = new SqlCommand();
    public DataSet dataSet2 = new DataSet();

    public SqlDataAdapter dataAdapter3 = new SqlDataAdapter();
    public SqlCommand SelectCommand3 = new SqlCommand();
    public DataSet dataSet3 = new DataSet();

    public SqlDataAdapter dataAdapter4 = new SqlDataAdapter();
    public SqlCommand SelectCommand4 = new SqlCommand();
    public DataSet dataSet4 = new DataSet();

    public SqlDataAdapter dataAdapter5 = new SqlDataAdapter();
    public SqlCommand SelectCommand5 = new SqlCommand();
    public DataSet dataSet5 = new DataSet();

    public SqlDataAdapter dataAdapter6 = new SqlDataAdapter();
    public SqlCommand SelectCommand6 = new SqlCommand();
    public DataSet dataSet6 = new DataSet();

    public SqlDataAdapter dataAdapter7 = new SqlDataAdapter();
    public SqlCommand SelectCommand7 = new SqlCommand();
    public DataSet dataSet7 = new DataSet();

    public anatablo()
    {

        dataAdapter1.SelectCommand = SelectCommand;
        dataAdapter2.SelectCommand = SelectCommand2;
        dataAdapter3.SelectCommand = SelectCommand3;
        dataAdapter4.SelectCommand = SelectCommand4;
        dataAdapter5.SelectCommand = SelectCommand5;
        dataAdapter6.SelectCommand = SelectCommand6;
        dataAdapter7.SelectCommand = SelectCommand7;

        SelectCommand.Connection = baglanti;
        SelectCommand2.Connection = baglanti;
        SelectCommand3.Connection = baglanti;
        SelectCommand4.Connection = baglanti;
        SelectCommand5.Connection = baglanti;
        SelectCommand6.Connection = baglanti;
        SelectCommand7.Connection = baglanti;


        //PRODUCTION
        string connection_string = "Data Source=VAIO\\SAHIN;Initial Catalog=kargoTakip;Integrated Security=True";
        /* Eðer windows authentication ile baðlantý kurulacaksa             
            connectionString="Data Source=ACER14-PC155;Initial Catalog=Servis_Masasi;Integrated Security=True"
           þeklinde kullanýlýr.*/

        baglanti.ConnectionString = connection_string;

    }

    public void kapat()  // baðlantý kapat
    {

        baglanti.Close();

    }
    public void ac() //baðlantý aç
    {

        baglanti.Open();

    }
    public bool kullaniciDogrula(string username, string sifre)
    {
        dataSet1.Clear();
        dataAdapter1.SelectCommand.CommandText = "Select adsad from kullanicilar Where kullanici_ad='" + username + "' and kullanici_sifre='" + sifre + "';";
        dataAdapter1.Fill(dataSet1);
        if (dataSet1.Tables[0].Rows.Count > 0)
        {
            if (dataSet1.Tables[0].Rows[0][0].ToString() == "") return false;
            else return true;
        }
        else return false;

    }
    public bool Kargocumu(string username)
    {
        dataSet2.Clear();
        dataAdapter2.SelectCommand.CommandText = "Select adsad from kullanicilar Where kullanici_ad='" + username + "' and kullanici_Tipi=1;";
        dataAdapter2.Fill(dataSet2);
        if (dataSet2.Tables[0].Rows.Count > 0)
        {
            if (dataSet2.Tables[0].Rows[0][0].ToString() == "") return false;
            else return true;
        }
        else return false;

    }
    public bool kullanicivarmi(string tc)
    {
        dataSet2.Clear();
        dataAdapter2.SelectCommand.CommandText = "Select TC from kullanicilar Where TC='" + tc + "';";
        dataAdapter2.Fill(dataSet2);
        if (dataSet2.Tables[0].Rows.Count > 0)
        {
            if (dataSet2.Tables[0].Rows[0][0].ToString() == "") return false;
            else return true;
        }
        else return false;

    }
    public bool adminmi(string username)
    {
        dataSet2.Clear();
        dataAdapter2.SelectCommand.CommandText = "Select adsad from kullanicilar Where kullanici_ad='" + username + "' and kullanici_Tipi=0;";
        dataAdapter2.Fill(dataSet2);
        if (dataSet2.Tables[0].Rows.Count > 0)
        {
            if (dataSet2.Tables[0].Rows[0][0].ToString() == "") return false;
            else return true;
        }
        else return false;

    }
    public void UrunKaydet(string gonAd, string gonil, string gonilce, string gontel, string alAd, string alil, string alilce, string aladres, string altel, string sondurum, string personel, string tarih)
    {


        // SqlDataAdapter dataAdapter6 = new SqlDataAdapter();
        baglanti.Open();
        dataAdapter6.SelectCommand.CommandText = "insert into Kargolar(GondericiAdSad,GondericiIl,GondericiIlce,GondericiTel,AliciAdSad,AliciIl,AliciIlce,AliciAdres,AliciTel,SonDurum,OlusturanPersonel,OlusturmaTarihi) values('" + gonAd + "','" + gonil + "','" + gonilce + "','" + gontel + "','" + alAd + "','" + alil + "','" + alilce + "','" + aladres + "','" + altel + "','" + sondurum + "','" + personel + "','" + tarih + "'); ";
        dataAdapter6.SelectCommand.ExecuteNonQuery();
        //dataAdapter6.SelectCommand.CommandText = "Select *from Urunler ";
        //dataAdapter6.Fill(dataSet6);

        MessageBox.Show("kayýt baþarýlý");




        //dataAdapter3.SelectCommand.CommandText = "Insert into Urunler(Gonderici_Adi,Alici_Adi,Alici_Adres,Nerede,KargoNo,Satici_Adres) Values ('" + GonAd + "','" + AliciAd + "','" + Aliciadr + "','" + nerede + "','" + kargono + "','" + saticiadr + "');";
        //dataAdapter3.SelectCommand.ExecuteNonQuery();
        //dataSet3.Clear();
        //dataAdapter3.SelectCommand.CommandText = "Select *from Urunler ";
        //dataAdapter3.Fill(dataSet3);
    }
    public void UrunKonumuGuncelle(string nerede, int kargono)
    {

        baglanti.Open();
        dataAdapter4.SelectCommand.CommandText = "Update Kargolar Set SonDurum='" + nerede + "' where KargoId='" + kargono + "';";
        dataAdapter4.SelectCommand.ExecuteNonQuery();
        dataSet4.Clear();
        baglanti.Close();

    }

    public void KullaniciGuncelle(string adsad, string TC, string kul_tipi, string kul_ad, string kul_sifre)
    {

        baglanti.Open();
        dataAdapter4.SelectCommand.CommandText = "Update kullanicilar Set adsad='" + adsad + "',TC='" + TC + "',kullanici_tipi='" + kul_tipi + "',kullanici_ad='" + kul_ad + "' ,kullanici_sifre='" + kul_sifre + "'where TC='" + TC + "';";
        dataAdapter4.SelectCommand.ExecuteNonQuery();
        dataSet3.Clear();
        dataAdapter4.SelectCommand.CommandText = "Select * from kullanicilar ";
        dataAdapter4.Fill(dataSet3);
        dataSet4.Clear();
        baglanti.Close();

    }
    public int Idvarmi(int id)
    {
        dataSet2.Clear();
        dataAdapter2.SelectCommand.CommandText = "Select KargoId from Kargolar Where KargoId=" + id + ";";
        dataAdapter2.Fill(dataSet2);


        return Convert.ToInt32(dataSet2.Tables[0].Rows[0][0].ToString());



    }
    public void kullanicisil(string tc)
    {

        baglanti.Open();
        dataAdapter5.SelectCommand.CommandText = " DELETE FROM kullanicilar WHERE TC =" + tc + "; ";
        dataAdapter5.SelectCommand.ExecuteNonQuery();
        dataSet5.Clear();
        baglanti.Close();




    }
    public void KullaniciEkle(string Ad, string tckn, string kullaniciadi, string sifre, string Kullanici_Tipi)
    {


        baglanti.Close();
        baglanti.Open();

        dataSet7.Clear();
        dataAdapter7.SelectCommand.CommandText = "insert into kullanicilar (adsad,TC,kullanici_tipi,kullanici_ad,kullanici_sifre) Values ('" + Ad + "','" + tckn + "','" + Kullanici_Tipi + "','" + kullaniciadi + "','" + sifre + "'); ";
        dataAdapter7.SelectCommand.ExecuteNonQuery();
        dataSet3.Clear();
        dataAdapter3.SelectCommand.CommandText = "Select * from kullanicilar ";
        dataAdapter3.Fill(dataSet3);
        baglanti.Close();
    }


}








