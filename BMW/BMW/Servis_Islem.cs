﻿using System;
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
        double parcafiyat;
        int parca_adet;
        string parcakod,parca_adi;
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
        private void parcalari_goster()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select * From Parca_Stok", si_baglanti);
                si_baglanti.Open();
                SqlDataReader si_DR;
                si_DR = komut.ExecuteReader();
                while (si_DR.Read())
                {
                    comboSIprc.Items.Add(si_DR["Parca_adi"].ToString());
                }
                si_baglanti.Close();
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
        private void servis_ucret_guncelle()
        {
            try{
            SqlCommand komut = new SqlCommand();
            MessageBox.Show(parca_adet.ToString());
            MessageBox.Show((parca_adet * parcafiyat).ToString());
            komut.CommandText = "Update Servis Set Servis_ucret=Servis_ucret+" + (parca_adet * parcafiyat) + " Where S_kodu='" + textSIsvk.Text + "'";
            si_baglanti.Open();
            komut.Connection = si_baglanti;
            komut.ExecuteNonQuery();
            si_baglanti.Close();
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
        private void servis_parca_ucret_sil()
        {
            try
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "Update Servis Set Servis_ucret=Servis_ucret-" + parca_adet * parcafiyat + " Where S_kodu='" + textSIsvk.Text + "'";
                si_baglanti.Open();
                komut.Connection = si_baglanti;
                komut.ExecuteNonQuery();
                si_baglanti.Close();
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
        private void adet_stok_kontrol()
        {   try
            {
                
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
        private void adet_dusur()
        {
            try{
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Update Parca_Stok Set Stok_adet=Stok_adet-" + parca_adet + " Where Parca_kodu='" + parcakod + "'";
            si_baglanti.Open();
            komut.Connection = si_baglanti;
            komut.ExecuteNonQuery();
            si_baglanti.Close();
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
        private void parcakodu_bul()
        {
            try
            {
                si_baglanti.Close();
                SqlCommand komut = new SqlCommand("Select * From Parca_Stok Where Parca_adi='" + comboSIprc.SelectedItem.ToString() + "'", si_baglanti);
                si_baglanti.Open();
                SqlDataReader sv_DR;
                sv_DR = komut.ExecuteReader();
                sv_DR.Read();
                parcakod = (sv_DR["Parca_kodu"]).ToString();
                parcafiyat = Convert.ToDouble(sv_DR["Birim_fiyat"]);
                textSIfyt.Text = parcafiyat.ToString();
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
        private void parcayi_goster()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select * From Parca_Stok Where Parca_kodu='"+parcakod+"'", si_baglanti);
                si_baglanti.Open();
                SqlDataReader si_DR;
                si_DR = komut.ExecuteReader();
                si_DR.Read();
                comboSIprc.SelectedItem=(si_DR["Parca_adi"].ToString());
                si_baglanti.Close();
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
            parcalari_goster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parca prc_form = new Parca();
            prc_form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommand pkomut = new SqlCommand("Select * From Parca_Stok Where Parca_kodu='" + parcakod + "'", si_baglanti);
            si_baglanti.Open();
            SqlDataReader si_DR;
            si_DR = pkomut.ExecuteReader();
            si_DR.Read();
            parca_adet = Convert.ToInt32(si_DR["Stok_adet"]);
            parca_adi = (si_DR["Parca_adi"]).ToString();
            si_baglanti.Close();
            if (Convert.ToInt32(textSIadt.Text) > parca_adet)
            {
                MessageBox.Show("Stokta yeterli Adet yok. Stokta " + parca_adet + " adet " + parca_adi + " var");

            }
            else
            {
                try
                {
                    //parcafiyat = parcafiyat + Convert.ToDouble(textSIfyt.Text);
                    parca_adet = Convert.ToInt32(textSIadt.Text);
                    SqlCommand komut = new SqlCommand();
                    komut.CommandText = "INSERT INTO Islem Values(" + "'" + textSIkod.Text + "'," + "'" + textSIisl.Text + "','" + parcakod + "'," + textSIadt.Text + ",'" + textSIsvk.Text + "'," + Convert.ToDouble(textSIfyt.Text) + ")";
                    si_baglanti.Open();
                    komut.Connection = si_baglanti;
                    komut.ExecuteNonQuery();
                    si_baglanti.Close();
                    islem_goster();
                    servis_ucret_guncelle();
                    adet_dusur();
                    adet_stok_kontrol();
                    
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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textSIid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textSIkod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textSIisl.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                parcakod = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                parcayi_goster();
                textSIadt.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value).ToString();
                textSIsvk.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
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
                parcafiyat = Convert.ToDouble(textSIfyt.Text);
                parca_adet = Convert.ToInt32(textSIadt.Text);
                MessageBox.Show(parcafiyat.ToString());
                komut.CommandText = "Delete From Islem Where Islem_id='" + textSIid.Text + "'";
                si_baglanti.Open();
                komut.Connection = si_baglanti;
                komut.ExecuteNonQuery();
                si_baglanti.Close();
                servis_parca_ucret_sil();
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
                komut.CommandText = "Update Islem Set Islem_kodu=" + "'" + textSIkod.Text + "',Islem=" + "'" + textSIisl.Text + "',Parca_kodu='" + parcakod + "',Parca_adet=" + Convert.ToInt32(textSIadt.Text) + ",S_kodu='" + textSIsvk.Text+ "',Ucret=" + Convert.ToDouble(textSIfyt.Text) + " Where Islem_id='" + textSIid.Text + "'";
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

        private void comboSIprc_SelectedIndexChanged(object sender, EventArgs e)
        {

            parcakodu_bul();
        }

        private void button5_Click(object sender, EventArgs e)
        {
             try
            {
                textSIid.Clear();
                textSIkod.Clear();
                textSIadt.Clear();
                textSIfyt.Clear();
                textSIisl.Clear();
                textSIsvk.Clear();
                comboSIprc.Text = "";
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yanlış bir şeyler var hataları kontrol ediniz");
                MessageBox.Show(hata.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Servis servisform = new Servis();
            servisform.Show();
            this.Hide();
        }

    }
}

