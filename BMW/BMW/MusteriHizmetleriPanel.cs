﻿using System;
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
            try
            {
                string tcno = "12345678901";
                aktifkisi.Text = cumle.Giris_Bilgisi(tcno);
                cumle.Select("SELECT * FROM Musteri", "Musteri");
                Musterigrid.DataSource = cumle.ds.Tables["Musteri"];
                cumle.Select("SELECT * FROM Firma_Musteri", "Firma");
                Firmagrid.DataSource = cumle.ds.Tables["Firma"];
                cumle.Select("SELECT * FROM Servis", "Servis");
                Servisgrid.DataSource = cumle.ds.Tables["Servis"];
                cumle.Select("SELECT * FROM Arac_Satis", "Aracsatis");
                Aracsatisgrid.DataSource = cumle.ds.Tables["Aracsatis"];
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            
        }

        private void Kapat_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            

        }

        private void Musteriekle_Click(object sender, EventArgs e)
        {
            try
            {
                Musteriislem_kayitekle_guncelle m = new Musteriislem_kayitekle_guncelle();
                this.Hide();
                m.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            

        }

        private void Musteriguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Musteriislem_kayitekle_guncelle m = new Musteriislem_kayitekle_guncelle();
                this.Hide();
                m.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            
        }

        private void Musterisil_Click(object sender, EventArgs e)
        {
            try
            {
                Musteriislem_kayitsil m = new Musteriislem_kayitsil();
                this.Hide();

                m.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            
        }

        private void Musteriara_Click(object sender, EventArgs e)
        {
            try
            {
                Musteriislem_kayitbul m = new Musteriislem_kayitbul();
                this.Hide();

                m.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }

        }

        private void programkapat_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            

        }

        private void firmaekle_Click(object sender, EventArgs e)
        {
            try
            {
                Firmaislem_kayitekle_guncelle m = new Firmaislem_kayitekle_guncelle();
                this.Hide();
                m.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            

        }

        private void firmasil_Click(object sender, EventArgs e)
        {
            try
            {
                Firmaislem_kayitsil m = new Firmaislem_kayitsil();
                this.Hide();
                m.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Firmaislem_kayitekle_guncelle m = new Firmaislem_kayitekle_guncelle();
                this.Hide();
                m.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
           

        }

        private void firmaara_Click(object sender, EventArgs e)
        {
            try
            {
                Firmaislem_kayitbul m = new Firmaislem_kayitbul();
                this.Hide();
                m.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            

        }

        private void progkapat_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            

        }

        private void servisdurumkontrol_Click(object sender, EventArgs e)
        {
            try
            {
                Servis_durum_kontrol m = new Servis_durum_kontrol();
                this.Hide();
                m.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            

        }

        private void serviskayitara_Click(object sender, EventArgs e)
        {
            try
            {
                Servis_kayitbul m = new Servis_kayitbul();
                this.Hide();
                m.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            

        }

        private void servisdetaylikayitara_Click(object sender, EventArgs e)
        {
            try
            {
                Servis_detayli_arama m = new Servis_detayli_arama();
                this.Hide();
                m.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            

        }

        private void pkapat_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            

        }

        private void arackayitara_Click(object sender, EventArgs e)
        {
            try
            {
                Arac_satis_kayitbul m = new Arac_satis_kayitbul();
                this.Hide();
                m.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            

        }

      

 

     
    }
}
