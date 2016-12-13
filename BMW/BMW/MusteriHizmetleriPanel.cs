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
            Musteriislem m = new Musteriislem();
            this.Hide();
            m.Show();

        }

        private void Musteriguncelle_Click(object sender, EventArgs e)
        {
            Musteriislem m = new Musteriislem();
            this.Hide();
            m.Show();
        }
    }
}
