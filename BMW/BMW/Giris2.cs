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
    public partial class Giris2 : Form
    {
        SQL2 cumle = new SQL2();
        public Giris2()
        {
            InitializeComponent();
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            cumle.Select("Select*from Kullanici where Kullanici_adi='"+txt_Kulad.Text.ToString()+"' AND Kullanici_sifre='"+txt_Sifre.Text.ToString()+"'");
            if (cumle.tablo.Rows.Count > 0)
            {
                this.Hide();
            }
            else { MessageBox.Show("Hatalı Giriş"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Servis srv_form = new Servis();
            srv_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arac_Satis asatisfrm = new Arac_Satis();
            asatisfrm.Show();
        }
    }
}
