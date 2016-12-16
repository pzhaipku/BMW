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
    public partial class Servis_Islem : Form
    {
        public Servis_Islem()
        {
            InitializeComponent();
        }
        SqlConnection si_baglanti = new SqlConnection("Data Source=PC-BILGISAYAR; Initial Catalog=BMW;Integrated Security=true;");
        private void islem_goster()
        {
            try
            {
                SqlDataAdapter si_DA = new SqlDataAdapter("Select * From Islem", si_baglanti);
                DataSet sv_DS = new DataSet();
                si_baglanti.Open();
                si_DA.Fill(sv_DS, "Islem");
                dataGridView1.DataSource = sv_DS.Tables["Islem"];
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                si_baglanti.Close();
            }
        }

        private void Servis_Islem_Load(object sender, EventArgs e)
        {
            islem_goster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parca prc_form = new Parca();
            prc_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "INSERT INTO Islem Values(" + "'" + textSIkod.Text + "'," + "'" + textSIisl.Text + "','PAK000'," + textSIadt.Text + ",'" + textSIsvk.Text + "'," + Convert.ToDouble(textSIfyt.Text) +")";
                si_baglanti.Open();
                komut.Connection = si_baglanti;
                komut.ExecuteNonQuery();
                si_baglanti.Close();
                islem_goster();
            }
            catch (Exception eklehata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(eklehata.ToString());
            }
            finally
            {
                si_baglanti.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textSIid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textSIkod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textSIisl.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboSIprc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textSIadt.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value).ToString();
                textSIsvk.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textSIfyt.Text = Convert.ToDouble(dataGridView1.CurrentRow.Cells[6].Value).ToString();
            }

            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                si_baglanti.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "Delete From Islem Where Islem_id='" + textSIid.Text + "'";
                si_baglanti.Open();
                komut.Connection = si_baglanti;
                komut.ExecuteNonQuery();
                si_baglanti.Close();
                islem_goster();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                si_baglanti.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "Update Islem Set Islem_kodu=" + "'" + textSIkod.Text + "',Islem=" + "'" + textSIisl.Text + "',Parca_kodu='" + comboSIprc.Text + "',Parca_adet=" + Convert.ToInt32(textSIadt.Text) + ",S_kodu='" + textSIsvk.Text+ "',Ucret=" + Convert.ToDouble(textSIfyt.Text) + " Where Islem_id='" + textSIid.Text + "'";
                si_baglanti.Open();
                MessageBox.Show(komut.CommandText);
                komut.Connection = si_baglanti;
                komut.ExecuteNonQuery();
                si_baglanti.Close();
                islem_goster();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
               si_baglanti.Close();
            }
        }
    }
}
