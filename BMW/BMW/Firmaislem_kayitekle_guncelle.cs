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
    public partial class Firmaislem_kayitekle_guncelle : Form
    {
        SQL cumle = new SQL();
        private int i = 0;


        public Firmaislem_kayitekle_guncelle()
        {
            InitializeComponent();
        }

        private void geridon_Click(object sender, EventArgs e)
        {
            MusteriHizmetleriPanel m = new MusteriHizmetleriPanel();
            this.Close();
            m.Show();

        }

        private void Firmaislem_kayitekle_guncelle_Load(object sender, EventArgs e)
        {
            cumle.Select("SELECT*FROM Firma_Musteri", "firma");
            Firmagrid.DataSource = cumle.ds.Tables["firma"];

            fkodu.Text = cumle.ds.Tables["firma"].Columns["Firma_kodu"].ToString();
            fadi.Text = cumle.ds.Tables["firma"].Columns["Firma_adi"].ToString();
            ilkodu.Text = cumle.ds.Tables["firma"].Columns["Il_kodu"].ToString();
            ilcekodu.Text = cumle.ds.Tables["firma"].Columns["Ilce_kodu"].ToString();
            fadres.Text = cumle.ds.Tables["firma"].Columns["Firma_adres"].ToString();
            mkodu.Text = cumle.ds.Tables["firma"].Columns["M_kodu"].ToString();
            


            fid.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_id"].ToString();


            Firma_kodu.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_kodu"].ToString();
            Firma_adi.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_adi"].ToString();
            Il_koduu.Text = cumle.ds.Tables["firma"].Rows[i]["Il_kodu"].ToString();
            Ilce_koduu.Text = cumle.ds.Tables["firma"].Rows[i]["Ilce_kodu"].ToString();
            Firma_adres.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_adres"].ToString();
            M_kodu.Text = cumle.ds.Tables["firma"].Rows[i]["M_kodu"].ToString();

        }

        private void ılkkayit_Click(object sender, EventArgs e)
        {
            i = 0;

            Firma_kodu.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_kodu"].ToString();
            Firma_adi.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_adi"].ToString();
            Il_koduu.Text = cumle.ds.Tables["firma"].Rows[i]["Il_kodu"].ToString();
            Ilce_koduu.Text = cumle.ds.Tables["firma"].Rows[i]["Ilce_kodu"].ToString();
            Firma_adres.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_adres"].ToString();
            M_kodu.Text = cumle.ds.Tables["firma"].Rows[i]["M_kodu"].ToString();
            fid.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_id"].ToString();
        }

        private void sonkayit_Click(object sender, EventArgs e)
        {
            i = cumle.ds.Tables["firma"].Rows.Count - 1;

            Firma_kodu.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_kodu"].ToString();
            Firma_adi.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_adi"].ToString();
            Il_koduu.Text = cumle.ds.Tables["firma"].Rows[i]["Il_kodu"].ToString();
            Ilce_koduu.Text = cumle.ds.Tables["firma"].Rows[i]["Ilce_kodu"].ToString();
            Firma_adres.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_adres"].ToString();
            M_kodu.Text = cumle.ds.Tables["firma"].Rows[i]["M_kodu"].ToString();
            fid.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_id"].ToString();
        }

        private void sonrakikayit_Click(object sender, EventArgs e)
        {
            if (i < cumle.ds.Tables["firma"].Rows.Count - 1)
            {
                i++;
                Firma_kodu.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_kodu"].ToString();
                Firma_adi.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_adi"].ToString();
                Il_koduu.Text = cumle.ds.Tables["firma"].Rows[i]["Il_kodu"].ToString();
                Ilce_koduu.Text = cumle.ds.Tables["firma"].Rows[i]["Ilce_kodu"].ToString();
                Firma_adres.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_adres"].ToString();
                M_kodu.Text = cumle.ds.Tables["firma"].Rows[i]["M_kodu"].ToString();
                fid.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_id"].ToString();

            }
        }

        private void oncekikayit_Click(object sender, EventArgs e)
        {
            if (i == cumle.ds.Tables["firma"].Rows.Count - 1 || i != 0)
            {
                i--;
                Firma_kodu.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_kodu"].ToString();
                Firma_adi.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_adi"].ToString();
                Il_koduu.Text = cumle.ds.Tables["firma"].Rows[i]["Il_kodu"].ToString();
                Ilce_koduu.Text = cumle.ds.Tables["firma"].Rows[i]["Ilce_kodu"].ToString();
                Firma_adres.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_adres"].ToString();
                M_kodu.Text = cumle.ds.Tables["firma"].Rows[i]["M_kodu"].ToString();
                fid.Text = cumle.ds.Tables["firma"].Rows[i]["Firma_id"].ToString();
            }
        }

        private void kayitekle_Click(object sender, EventArgs e)
        {
            cumle.IDU("INSERT INTO Firma_Musteri VALUES('" + Firma_kodu.Text.ToString() + "', '" + Convert.ToString(Firma_adi.Text) + "', '" + Il_koduu.Text.ToString() + "', '" + Ilce_koduu.Text.ToString() + "', '" + Firma_adres.Text.ToString() + "', '" + M_kodu.Text.ToString() + "')");
            // cumle.IDU("INSERT INTO Musteri VALUES('" + M_kodu.Text.ToString() + "' '" + Convert.ToString(M_tcno.Text) + "' '" + M_adi.Text.ToString() + "' '" + M_soyadi.Text.ToString() + "' '" + M_tel.Text.ToString() + "' '" + M_email.Text.ToString() + "' '" + Convert.ToInt16(Il_kodu.Text) + "' '" + Ilce_kodu.Text.ToString() + "' '" + Adress.Text.ToString() + "' '" + M_turu_kodu.Text.ToString() + "')");
            cumle.ds.Tables["firma"].Clear();
            cumle.Select("Select * From Firma_Musteri", "firma");
            Firmagrid.DataSource = cumle.ds.Tables["firma"];
        }

        private void yenikayit_Click(object sender, EventArgs e)
        {
            Firma_kodu.Clear();

            Firma_adi.Clear();
            Il_koduu.Clear();
            Ilce_koduu.Clear();
            Firma_adres.Clear();
            M_kodu.Clear();
        }
    }
}
