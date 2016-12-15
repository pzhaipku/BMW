using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMW
{
    public partial class Giris : Form
    {
        SQL cumle = new SQL();
        AdminPanel admin = new AdminPanel();
        MusteriHizmetleriPanel Musterihzmt = new MusteriHizmetleriPanel();
        public Giris()
        {
            InitializeComponent();
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            try
            {
                cumle.Select("Select*from Kullanici where Kullanici_adi='" + txt_Kulad.Text.ToString() + "' AND Kullanici_sifre='" + txt_Sifre.Text.ToString() + "'", "giris");


                if (cumle.ds.Tables["giris"].Rows[0]["Yetki_kodu"].ToString() == "YK0")
                {
                    admin.Show();
                    this.Hide();
                }
                else if (cumle.ds.Tables["giris"].Rows[0]["Yetki_kodu"].ToString() == "YK1")
                {
                    admin.Show();
                    this.Hide();
                }
                else if (cumle.ds.Tables["giris"].Rows[0]["Yetki_kodu"].ToString() == "YK2")
                {
                    admin.Show();
                    this.Hide();
                }
                else if (cumle.ds.Tables["giris"].Rows[0]["Yetki_kodu"].ToString() == "YK3")
                {
                    admin.Show();
                    this.Hide();
                }
                else if (cumle.ds.Tables["giris"].Rows[0]["Yetki_kodu"].ToString() == "YK4")
                {
                    Musterihzmt.Show();
                    this.Hide();
                }
                else { MessageBox.Show("Hatalı Giriş"); }
            }
            catch (Exception)
            {
                
                throw;
            }
            

        }
    }
}
