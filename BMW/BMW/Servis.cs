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

        public void parca_stok_goster()
        {
            SqlDataAdapter sv_DA = new SqlDataAdapter("Select * From Parca_Stok", sv_baglanti);
            DataSet sv_DS = new DataSet();
            sv_baglanti.Open();
            sv_DA.Fill(sv_DS, "Parca_Stok");
            dataGridView1.DataSource = sv_DS.Tables["Parca_Stok"];
            sv_baglanti.Close();
        }
        public Servis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            parca_stok_goster();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            sv_baglanti.Open();
            komut.Connection = sv_baglanti;
            komut.CommandText="INSERT INTO Parca_Stok Values("+"'"+textPAK.Text+"',"+"'"+textPAad.Text+"',"+textPAstok.Text+","+textPAfiyat.Text+",'"+textPAaciklama.Text+"')";
            komut.ExecuteNonQuery();
            sv_baglanti.Close();
            parca_stok_goster();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textPAid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textPAK.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textPAad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textPAstok.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textPAfiyat.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value).ToString();
            textPAaciklama.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textPAK.Clear();
            textPAad.Clear();
            textPAstok.Clear();
            textPAfiyat.Clear();
            textPAaciklama.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sv_sorgu = "UPDATE Parca_Stok Set Parca_kodu='"+textPAK.Text+"',"+"Parca_adi='"+textPAad.Text+"',"+"Stok_adet="+Convert.ToInt32(textPAstok.Text)+","+"Birim_Fiyat="+Convert.ToInt32(textPAfiyat.Text)+","+"Aciklama='"+textPAaciklama.Text+"' Where PStok_id="+Convert.ToInt32(textPAid.Text);
            MessageBox.Show(sv_sorgu);
            SqlCommand komut = new SqlCommand(sv_sorgu,sv_baglanti);
            sv_baglanti.Open();
            komut.ExecuteNonQuery();
            sv_baglanti.Close();
            parca_stok_goster();
        }
    }
}
