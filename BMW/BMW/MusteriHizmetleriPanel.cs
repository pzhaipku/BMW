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
    public partial class MusteriHizmetleriPanel : Form
    {
        SQL cumle = new SQL();

        public MusteriHizmetleriPanel()
        {
            InitializeComponent();
        }

        private void MusteriHizmetleriPanel_Load(object sender, EventArgs e)
        {
            string tcno = "12345678901";

            aktifkisi.Text = cumle.Giris_Bilgisi(tcno);
            cumle.Select("SELECT * FROM Musteri", "Musteri");
            Musterigrid.DataSource = cumle.ds.Tables["Musteri"];
            cumle.Select("SELECT * FROM Firma_Musteri", "Firma");
            Firmagrid.DataSource = cumle.ds.Tables["Firma"];
            cumle.Select("SELECT * FROM Servis", "Servis");
            Servisgrid.DataSource = cumle.ds.Tables["Servis"];

        }

        private void Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Musteriekle_Click(object sender, EventArgs e)
        {
            Musteriislem_kayitekle_guncelle m = new Musteriislem_kayitekle_guncelle();
            this.Hide();
            m.Show();

        }

        private void Musteriguncelle_Click(object sender, EventArgs e)
        {
            Musteriislem_kayitekle_guncelle m = new Musteriislem_kayitekle_guncelle();
            this.Hide();
            m.Show();
        }

        private void Musterisil_Click(object sender, EventArgs e)
        {
            Musteriislem_kayitsil m = new Musteriislem_kayitsil();
            this.Hide();
            
            m.Show();
        }

        private void Musteriara_Click(object sender, EventArgs e)
        {
            Musteriislem_kayitbul m = new Musteriislem_kayitbul();
            this.Hide();
            
            m.Show();
            


          


        }

        private void programkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void firmaekle_Click(object sender, EventArgs e)
        {
            Firmaislem_kayitekle_guncelle m = new Firmaislem_kayitekle_guncelle();
            this.Hide();
            m.Show();

        }

        private void firmasil_Click(object sender, EventArgs e)
        {
            Firmaislem_kayitsil m = new Firmaislem_kayitsil();
            this.Hide();
            m.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Firmaislem_kayitekle_guncelle m = new Firmaislem_kayitekle_guncelle();
            this.Hide();
            m.Show();

        }

        private void firmaara_Click(object sender, EventArgs e)
        {
            Firmaislem_kayitbul m = new Firmaislem_kayitbul();
            this.Hide();
            m.Show();

        }

        private void progkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

     
    }
}
