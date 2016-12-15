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
    public partial class AracStok : Form
    {
        public string modelkodu;
        double model_fiyat;
        SqlConnection astok_baglanti = new SqlConnection("Data Source=PC-BILGISAYAR; Initial Catalog=BMW;Integrated Security=true;");
        public AracStok()
        {
            InitializeComponent();
        }
        private void model_goster()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select Distinct(Model_adi) From Arac_Model", astok_baglanti);
                astok_baglanti.Open();
                SqlDataReader as_DR;
                as_DR = komut.ExecuteReader();
                while (as_DR.Read())
                {
                    comboASmod.Items.Add(as_DR["Model_adi"]);
                }
                astok_baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                astok_baglanti.Close();
            }
        }
        private void dpaketi_goster()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select Distinct(Dp_adi) From Donanim_Paket", astok_baglanti);
                astok_baglanti.Open();
                SqlDataReader as_DR;
                as_DR = komut.ExecuteReader();
                while (as_DR.Read())
                {
                    comboASdpk.Items.Add(as_DR["Dp_adi"]);
                }
                astok_baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                astok_baglanti.Close();
            }
        }
        private void aracstok_goster()
        {
            try
            {
                SqlDataAdapter sv_DA = new SqlDataAdapter("Select * From Arac_Stok", astok_baglanti);
                DataSet sv_DS = new DataSet();
                astok_baglanti.Open();
                sv_DA.Fill(sv_DS, "Arac_Stok");
                dataGridView1.DataSource = sv_DS.Tables["Arac_Stok"];
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                astok_baglanti.Close();
            }
        }
        private void AracStok_Load(object sender, EventArgs e)
        {
            aracstok_goster();
            model_goster();
            dpaketi_goster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "INSERT INTO Arac_Stok Values('" + textASmod.Text + "'," + textASadt.Text + ",'" + Convert.ToDouble(textASalf.Text) + "','" + Convert.ToDouble(textASotv.Text) + "','" + Convert.ToDouble(textASkdv.Text) + "','" + Convert.ToDouble(textASkar.Text) + "','" + Convert.ToDouble(textASbtf.Text)+"')";
                MessageBox.Show(komut.CommandText);
                astok_baglanti.Open();
                komut.Connection = astok_baglanti;
                komut.ExecuteNonQuery();
                astok_baglanti.Close();
            }
            catch (Exception eklehata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(eklehata.ToString());
            }
            finally
            {
                astok_baglanti.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textASid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                modelkodu = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textASmod.Text = modelkodu;
                textASadt.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value).ToString();
                textASalf.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value).ToString();
                textASotv.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value).ToString();
                textASkdv.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value).ToString();
                textASkar.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value).ToString();
                textASbtf.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value).ToString();
            }

            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                astok_baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ASmodel aracstokmodelform = new ASmodel();
            aracstokmodelform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textASadt.Clear();
            textASalf.Clear();
            textASbtf.Clear();
            textASid.Clear();
            textASkar.Clear();
            textASkdv.Clear();
            textASmod.Clear();
            textASotv.Clear();
        }

        private void comboASmod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Exec Arac_model_sorgu_modeladi'" + comboASmod.SelectedItem.ToString()+"'" , astok_baglanti);
                astok_baglanti.Open();
                SqlDataReader as_DR;
                as_DR = komut.ExecuteReader();
                while (as_DR.Read())
                {
                    model_fiyat = Convert.ToDouble((as_DR["Aracın Fiyatı"]));
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                astok_baglanti.Close();
            }
        }

        private void comboASdpk_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Exec Arac_model_sorgu_modeladi'" + comboASmod.SelectedItem.ToString() + "'", astok_baglanti);
                astok_baglanti.Open();
                SqlDataReader as_DR;
                as_DR = komut.ExecuteReader();
                while (as_DR.Read())
                {
                    textASalf.Text = Convert.ToDouble((as_DR["Aracın Fiyatı"])).ToString();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                astok_baglanti.Close();
            }
        }
    }
}
