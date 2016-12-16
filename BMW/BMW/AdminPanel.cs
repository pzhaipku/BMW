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
    public partial class AdminPanel : Form
    {
        SQL AP_cumle = new SQL();
        A_Kullanici kullanici;
        YetkiTanimlama yetki;
        Giris giris;
        Il_Ilce il_ilce;
        AracSerileri seriler;

        public string Tc_no;
        public AdminPanel()
        {
            InitializeComponent();
        }

        

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            //Giris sırasında textboxda girilen tc no bilgisi public tanımlanan Tc_no değişkenine
            //gönderiliyor ve giriş bilgisini elde etmek için tc no değişkeni fonksiyona gönderiliyor.
            lbl_GirisBilgisi.Text=AP_cumle.Giris_Bilgisi(Tc_no); 
        }

        private void btn_Kullanicilar_Click(object sender, EventArgs e)
        {
            kullanici = new A_Kullanici();
            kullanici.Tc_no2 = Tc_no;
            kullanici.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void btn_YetkiTanimlama_Click(object sender, EventArgs e)
        {
            yetki = new YetkiTanimlama();
            yetki.Tc_no3 = Tc_no;
            yetki.Show();
            this.Hide();
        }

        private void btn_Il_Ilce_Click(object sender, EventArgs e)
        {
            il_ilce = new Il_Ilce();
            il_ilce.Tc_no4 = Tc_no;
            il_ilce.Show();
            this.Hide();
        }

        private void btn_AracSerileri_Click(object sender, EventArgs e)
        {
            seriler = new AracSerileri();
            seriler.tc_no5 = Tc_no;
            seriler.Show();
            this.Hide();
        }
    }
}
