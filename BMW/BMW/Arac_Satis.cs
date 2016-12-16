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
    public partial class Arac_Satis : Form
    {
        string astmuskod, astmustc, astperadi, astpersoyadi, astperadsoy, astperadi1, astpersoyadi1, astperkod, astpersoneladsoy, astmodelkod;
        string[] personel;
        SqlConnection asatis_baglanti = new SqlConnection("Data Source=PC-BILGISAYAR; Initial Catalog=BMW;Integrated Security=true;");
        public Arac_Satis()
        {
            InitializeComponent();
        }
        private void astmusteri_tckontrol()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Execute Musteri_sorgu_mtcno " + textASTmus.Text, asatis_baglanti);
                asatis_baglanti.Open();
                SqlDataReader ast_DR;
                ast_DR = komut.ExecuteReader();
                ast_DR.Read();
                astmuskod = (ast_DR["Müşteri Kodu"]).ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                asatis_baglanti.Close();
            }
        }
        private void astmusteri_kodkontrol()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Execute Musteri_sorgu_mkodu " + astmuskod, asatis_baglanti);
                asatis_baglanti.Open();
                SqlDataReader ast_DR;
                ast_DR = komut.ExecuteReader();
                ast_DR.Read();
                astmustc = (ast_DR["TC Numarası"]).ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                asatis_baglanti.Close();
            }
        }
        private void astpersonel_goster()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select P_adi,P_soyadi From Personel", asatis_baglanti);
                asatis_baglanti.Open();
                SqlDataReader ast_DR;
                ast_DR = komut.ExecuteReader();
                while (ast_DR.Read())
                {
                    astperadi1 = ast_DR["P_adi"].ToString();
                    astpersoyadi1 = ast_DR["P_soyadi"].ToString();
                    astperadsoy = astperadi1 +" "+ astpersoyadi1;
                    comboASTper.Items.Add(astperadsoy);
                }
                asatis_baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                asatis_baglanti.Close();
            }
        }
        private void astseri_goster()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select Seri_kodu From Arac_Serisi", asatis_baglanti);
                asatis_baglanti.Open();
                SqlDataReader ast_DR;
                ast_DR = komut.ExecuteReader();
                while (ast_DR.Read())
                {
                    comboASTsri.Items.Add(ast_DR["Seri_kodu"]);
                }
                asatis_baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                asatis_baglanti.Close();
            }
        }
        private void astdp_goster()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select Dp_adi From Donanim_Paket", asatis_baglanti);
                asatis_baglanti.Open();
                SqlDataReader ast_DR;
                ast_DR = komut.ExecuteReader();
                while (ast_DR.Read())
                {
                    comboASTdpk.Items.Add(ast_DR["Dp_adi"]);
                }
                asatis_baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                asatis_baglanti.Close();
            }
        }
        private void astmodel_kontrol()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Exec Arac_Stok_model_kodu_bul2 '"+comboASTsri.SelectedItem.ToString()+"','"+comboASTmod.SelectedItem.ToString()+ "','"+comboASTdpk.SelectedItem.ToString()+"'",asatis_baglanti);
                asatis_baglanti.Open();
                SqlDataReader ast_DR;
                ast_DR = komut.ExecuteReader();
                ast_DR.Read();
                astmodelkod = (ast_DR["Model_kodu"]).ToString();
                textASTmod.Text = astmodelkod;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                asatis_baglanti.Close();
            }
        }
        private void aracsatis_goster()
        {
            try
            {
                SqlDataAdapter ast_DA = new SqlDataAdapter("Select * From Arac_Satis", asatis_baglanti);
                DataSet ast_DS = new DataSet();
                asatis_baglanti.Open();
                ast_DA.Fill(ast_DS, "Arac_Satis");
                dataGridView1.DataSource = ast_DS.Tables["Arac_Satis"];
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                asatis_baglanti.Close();
            }
        }
        private void Arac_Satis_Load(object sender, EventArgs e)
        {
            aracsatis_goster();
            astpersonel_goster();
            astseri_goster();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                astmodel_kontrol();
                astmusteri_tckontrol();
                string sorgu = "Exec Arac_Satis_kayitekle @satiskodu,@modelkodu,@personelkodu,@musterikodu,@satistarihi,@satisfiyati,@plaka";
                SqlCommand komut = new SqlCommand(sorgu, asatis_baglanti);
                komut.Parameters.AddWithValue("@satiskodu", textASTkod.Text);
                komut.Parameters.AddWithValue("@modelkodu", astmodelkod.ToString());
                komut.Parameters.AddWithValue("@personelkodu", astperkod.ToString());
                komut.Parameters.AddWithValue("@musterikodu", astmuskod.ToString());
                komut.Parameters.AddWithValue("@satistarihi", Convert.ToDateTime(dateTimeASTsth.Text));
                komut.Parameters.AddWithValue("@satisfiyati", Convert.ToDouble(textASTfyt.Text));
                komut.Parameters.AddWithValue("@plaka", textASTplk.Text);
                asatis_baglanti.Open();
                komut.ExecuteNonQuery();
                asatis_baglanti.Close();
                aracsatis_goster();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                asatis_baglanti.Close();
            }
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                SqlCommand komut = new SqlCommand("Select P_adi,P_soyadi From Personel Where P_kodu='" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "'", asatis_baglanti);
                asatis_baglanti.Open();
                SqlDataReader sv_DR;
                sv_DR = komut.ExecuteReader();
                sv_DR.Read();
                astperadi = (sv_DR["P_adi"]).ToString();
                astpersoyadi = (sv_DR["P_soyadi"]).ToString();
                asatis_baglanti.Close();
                textASTid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textASTkod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textASTmod.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboASTper.Text = astperadi+" "+astpersoyadi;
                astmuskod = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                astmusteri_kodkontrol();
                textASTmus.Text = astmustc;
                dateTimeASTsth.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textASTfyt.Text =Convert.ToDouble( dataGridView1.CurrentRow.Cells[6].Value).ToString();
                textASTplk.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }

            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                asatis_baglanti.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AracStok aracstok = new AracStok();
            aracstok.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textASTid.Clear();
                textASTkod.Clear();
                textASTmod.Clear();
                textASTmus.Clear();
                textASTplk.Clear();
                textASTfyt.Clear();
                comboASTper.Items.Clear();
                comboASTper.Text = "";
                comboASTsri.Items.Clear();
                comboASTsri.Text = "";
                comboASTmod.Items.Clear();
                comboASTmod.Text = "";
                comboASTdpk.Items.Clear();
                comboASTdpk.Text = "";
                dateTimeASTsth.Text = System.DateTime.Today.ToShortDateString();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
        }

        private void comboASTper_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                astpersoneladsoy = Convert.ToString(comboASTper.SelectedItem);
                personel = astpersoneladsoy.Split(' ');
                SqlCommand komut = new SqlCommand("Exec Personel_sorgu_padsoyad'" + personel[0] + "','" + personel[1] + "'", asatis_baglanti);
                asatis_baglanti.Open();
                SqlDataReader as_DR;
                as_DR = komut.ExecuteReader();
                while (as_DR.Read())
                {
                    astperkod = (as_DR["Personel Kodu"]).ToString();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                asatis_baglanti.Close();
            }
        }

        private void comboASTsri_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboASTmod.Items.Clear();
                comboASTmod.Text = "";
                comboASTdpk.Items.Clear();
                comboASTdpk.Text = "";
                SqlCommand komut = new SqlCommand("Select Model_adi From Arac_Model Where Seri_kodu='" + comboASTsri.SelectedItem.ToString() + "'", asatis_baglanti);
                asatis_baglanti.Open();
                SqlDataReader ast_DR;
                ast_DR = komut.ExecuteReader();
                while (ast_DR.Read())
                {
                    comboASTmod.Items.Add(ast_DR["Model_adi"]);
                }
                asatis_baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                asatis_baglanti.Close();
            }
        }

        private void comboASTmod_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboASTdpk.Items.Clear();
            comboASTdpk.Text = "";
            astdp_goster();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            astmodel_kontrol();
        }

        private void comboASTdpk_SelectedIndexChanged(object sender, EventArgs e)
        {
            astmodel_kontrol();
        }

    }
}

