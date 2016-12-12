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
                    MessageBox.Show("baglandi");
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
    }
}
