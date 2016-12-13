using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BMW
{
    public partial class Servis : Form
    {
        SqlConnection sv_baglanti = new SqlConnection("Data Source=PC-BILGISAYAR; Initial Catalog=BMW;Integrated Security=true;");
        public string perkod,peradi,muskod,mustc;

        public Servis()
        {
            InitializeComponent();
            InitializeComponent2();

        }
        private void musteri_tckontrol()
        {
            SqlCommand komut = new SqlCommand("Execute Musteri_sorgu_mtcno "+textSVmus.Text, sv_baglanti);
            sv_baglanti.Open();
            SqlDataReader sv_DR;
            sv_DR = komut.ExecuteReader();
            sv_DR.Read();
            muskod=(sv_DR["Müşteri Kodu"]).ToString();
            sv_baglanti.Close();
        }
        private void musteri_kodkontrol()
        {
            SqlCommand komut = new SqlCommand("Execute Musteri_sorgu_mkodu " + muskod, sv_baglanti);
            sv_baglanti.Open();
            SqlDataReader sv_DR;
            sv_DR = komut.ExecuteReader();
            sv_DR.Read();
            mustc = (sv_DR["TC Numarası"]).ToString();
            sv_baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parca prc_form = new Parca();
            prc_form.Show();
        }
        private void servis_goster()
        {
            SqlDataAdapter sv_DA = new SqlDataAdapter("Select * From Servis", sv_baglanti);
            DataSet sv_DS = new DataSet();
            sv_baglanti.Open();
            sv_DA.Fill(sv_DS, "Servis");
            dataGridView1.DataSource = sv_DS.Tables["Servis"];
            sv_baglanti.Close();
        }
        private void personel_goster()
        {
            
            SqlCommand komut = new SqlCommand("Select P_adi From Personel",sv_baglanti);
            sv_baglanti.Open();
            SqlDataReader sv_DR;
            sv_DR = komut.ExecuteReader();
            while (sv_DR.Read())
            {
            comboSVprc.Items.Add(sv_DR["P_adi"]);
            }
            sv_baglanti.Close();
        }
        private void Servis_Load(object sender, EventArgs e)
        {
            servis_goster();
            personel_goster();
            dateTimeSVcik.Visible=false;
            label8.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                musteri_tckontrol();
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "INSERT INTO Servis Values(" + "'" + textSVkod.Text + "'," + "'" + muskod + "','" + textSVmod.Text + "','" + perkod.ToString() + "'," + textSVgkm.Text + "," + textSVckm.Text + ",'" + Convert.ToDateTime(dateTimeSVgir.Text).ToShortDateString() + "',Null,'" + textSVplk.Text + "'," + Convert.ToInt32(textSVfyt.Text) + ",'" + Convert.ToInt32(checkSVtm.Checked) + "')";
                sv_baglanti.Open();
                komut.Connection = sv_baglanti;
                komut.ExecuteNonQuery();
                sv_baglanti.Close();
                servis_goster();
            }
            catch (Exception ) { 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SV_musform sermus = new SV_musform();
            sermus.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select P_adi From Personel Where P_kodu='" + dataGridView1.CurrentRow.Cells[4].Value.ToString()+"'", sv_baglanti);
            sv_baglanti.Open();
            SqlDataReader sv_DR;
            sv_DR = komut.ExecuteReader();
            sv_DR.Read();
            peradi = (sv_DR["P_adi"]).ToString();
            sv_baglanti.Close();

            textSVid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textSVkod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            muskod = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            musteri_kodkontrol();
            textSVmus.Text =  mustc;
            textSVmod.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboSVprc.Text = peradi;
            textSVgkm.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textSVckm.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dateTimeSVgir.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dateTimeSVcik.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textSVplk.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textSVfyt.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells[10].Value).ToString();
            checkSVtm.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[11].Value);
            dateTimeSVcik.Visible = true;
            label8.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Delete From Servis Where S_id='"+dataGridView1.CurrentRow.Cells[0].Value.ToString()+"'";
            sv_baglanti.Open();
            komut.Connection = sv_baglanti;
            komut.ExecuteNonQuery();
            sv_baglanti.Close();
            servis_goster();
        }

        private void comboSVprc_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select P_kodu From Personel Where P_adi='"+comboSVprc.SelectedItem.ToString()+"'", sv_baglanti);
            sv_baglanti.Open();
            SqlDataReader sv_DR;
            sv_DR = komut.ExecuteReader();
            while (sv_DR.Read())
            {
                perkod = (sv_DR["P_kodu"]).ToString();
            }
            sv_baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textSVid.Clear();
            textSVkod.Clear();
            textSVckm.Clear();
            textSVfyt.Clear();
            textSVgkm.Clear();
            textSVmod.Clear();
            textSVmus.Clear();
            textSVplk.Clear();
            comboSVprc.Items.Clear();
            comboSVprc.Text = "";
            personel_goster();
            dateTimeSVcik.Text=System.DateTime.Today.ToShortDateString();
            dateTimeSVgir.Text = System.DateTime.Today.ToShortDateString();
            checkSVtm.Checked = false;
            dateTimeSVcik.Visible = false;
            label8.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            musteri_tckontrol();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Update Servis Set S_kodu=" + "'" + textSVkod.Text + "',M_kodu=" + "'" + muskod + "',Model_kodu='" + textSVmod.Text + "',P_kodu='" + perkod.ToString() + "',Arac_giriskm=" + textSVgkm.Text + ",Arac_cikiskm=" + textSVckm.Text + ",S_giris_tarih='" + dateTimeSVgir.Value.ToString("yyyy-MM-dd") + "',S_cikis_tarih='" + dateTimeSVcik.Value.ToString("yyyy-MM-dd") + "',Plaka='" + textSVplk.Text + "',Servis_ucret=" + Convert.ToInt32(textSVfyt.Text) + ",Durum='" + Convert.ToInt32(checkSVtm.Checked) + "' Where S_id='" + textSVid.Text + "'";
            MessageBox.Show(komut.CommandText);
            sv_baglanti.Open();
            komut.Connection = sv_baglanti;
            komut.ExecuteNonQuery();
            sv_baglanti.Close();
            servis_goster();
        }


    }
}
