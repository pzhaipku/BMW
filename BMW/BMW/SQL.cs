using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BMW
{
    class SQL
    {

        SqlConnection bag_cumle = new SqlConnection("Data Source=asus-pc; Initial Catalog=BMW;Integrated Security=true");
        SqlDataAdapter adapter;
        SqlCommand komut;

        public DataSet ds = new DataSet();
        public DataTable tablo = new DataTable();
        private void baglan(int secim)
        {
            if (secim == 1)
            {
                if (bag_cumle.State == ConnectionState.Closed)
                {
                    bag_cumle.Open();
                    
                }
            }
            else if (secim == 0)
            {
                bag_cumle.Close();
            }
        }
        public void Select(string sorgu, string tablo_adi)
        {
            try
            {
                baglan(1);
                adapter = new SqlDataAdapter(sorgu, bag_cumle);
                adapter.Fill(ds, tablo_adi);
                baglan(0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu." + hata.Message);

            }

        }
        public void IDU(string sorgu)
        {
            //Insert Delete Update işlemlerimin hepsinde aynı komut satırları bulunduğu
            //için bir fonksiyon yeterli olacaktır.
            try
            {
                baglan(1);
                komut = new SqlCommand(sorgu, bag_cumle);
                komut.ExecuteNonQuery();
                baglan(0);
                MessageBox.Show("İşlem Başarılı");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu." + hata.Message);
            }

        }
        public string Giris_Bilgisi(string TC_no)
        {
            string ad_soyad, yetki, yetki_kod;

            try
            {
                //Giriş sırasında Tc_no alınıp bu fonksiyonda ad ve soyad bilgisi çekiliyor.
                Select("Select P_TCno,P_adi,P_soyadi from Personel where P_TCno='" + TC_no + "'", "Personel");
                ad_soyad = "Hoşgeldiniz" + " " + ds.Tables["Personel"].Rows[0][1].ToString() + " " + ds.Tables["Personel"].Rows[0][2];
                //Tc np ile yetki kodu elde ediliyor
                Select("Select Yetki_kodu,Kullanici_adi from Kullanici where Kullanici_adi='" + TC_no + "'", "Kullanici");
                yetki_kod = ds.Tables["Kullanici"].Rows[0][0].ToString();
                //yetki kodu ile yetki adı elde ediliyor
                Select("Select Yetki_kodu,Yetki_adi from Kullanici_Yetki where Yetki_kodu='" + yetki_kod + "'", "Kullanici_Yetki");
                yetki = ds.Tables["Kullanici_Yetki"].Rows[0][1].ToString();
                //hepsi birleştirilip çağrıldığı yere gönderiliyor
                ds.Clear();
                return ad_soyad + "(" + yetki + ")";

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu." + hata.Message);
                return "";
            }
        }

    }
}
