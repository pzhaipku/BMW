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
    public partial class Arac_Model : Form
    {
        public string tc_no8;
        SQL cumle = new SQL();
        string seri_kod, dp_kod, sanziman_kod, motor_kod,ekle_tarih;
        int satir_sayisi=0;
        double dp_fiyati;
        public Arac_Model()
        {
            InitializeComponent();
        }
        public void Seri_Getir()
        {
            cmb_Seri.Items.Clear();
            if (cumle.ds.Tables["Arac_Serisi"] != null)
            {
                cumle.ds.Tables["Arac_Serisi"].Clear();
            }
            cumle.Select("Select Seri_adi from Arac_Serisi", "Arac_Serisi");
            satir_sayisi = cumle.ds.Tables["Arac_Serisi"].Rows.Count;
            while (satir_sayisi > 0)
            {
                satir_sayisi--;
                cmb_Seri.Items.Add(cumle.ds.Tables["Arac_Serisi"].Rows[satir_sayisi]["Seri_adi"]);
            }
        }
        public void DP_Getir()
        {
            cmb_DP.Items.Clear();
            if (cumle.ds.Tables["Donanim_Paket"] != null)
            {
                cumle.ds.Tables["Donanim_Paket"].Clear();
            }
            cumle.Select("Select DP_adi from Donanim_Paket", "Donanim_Paket");
            satir_sayisi = cumle.ds.Tables["Donanim_Paket"].Rows.Count;
            while (satir_sayisi > 0)
            {
                satir_sayisi--;
                cmb_DP.Items.Add(cumle.ds.Tables["Donanim_Paket"].Rows[satir_sayisi]["DP_adi"]);
            }
        }
        public void Motor_Getir()
        {
            cmb_Motor.Items.Clear();
            if (cumle.ds.Tables["Arac_Motor"] != null)
            {
                cumle.ds.Tables["Arac_Motor"].Clear();
            }
            cumle.Select("Select AracM_kodu from Arac_Motor", "Arac_Motor");
            satir_sayisi = cumle.ds.Tables["Arac_Motor"].Rows.Count;
            while (satir_sayisi > 0)
            {
                satir_sayisi--;
                cmb_Motor.Items.Add(cumle.ds.Tables["Arac_Motor"].Rows[satir_sayisi]["AracM_kodu"]);
            }
        }
        public void Sanziman_Getir()
        {
            cmb_Sanziman.Items.Clear();
            if (cumle.ds.Tables["Arac_Sanziman"] != null)
            {
                cumle.ds.Tables["Arac_Sanziman"].Clear();
            }
            cumle.Select("Select Sanziman_adi from Arac_Sanziman", "Arac_Sanziman");
            satir_sayisi = cumle.ds.Tables["Arac_Sanziman"].Rows.Count;
            while (satir_sayisi > 0)
            {
                satir_sayisi--;
                cmb_Sanziman.Items.Add(cumle.ds.Tables["Arac_Sanziman"].Rows[satir_sayisi]["Sanziman_adi"]);
            }
        }
        private void Arac_Model_Load(object sender, EventArgs e)
        {
            lbl_ModelFiyatGosterim.Visible = false;
            lbl_ModelFiyati.Visible = false;
            Seri_Getir();
            DP_Getir();
            Motor_Getir();
            Sanziman_Getir();
        }

        private void btn_GeriDon_Click(object sender, EventArgs e)
        {
            AdminPanel AP = new AdminPanel();
            AP.Tc_no = tc_no8;
            AP.Show();
            this.Hide();
        }

        private void cmb_DP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cumle.ds.Tables["Donanim_Paket"] != null)
            {
                cumle.ds.Tables["Donanim_Paket"].Clear();
            }
            //----
            if (cmb_DP.SelectedIndex != -1)
            {
                lbl_DP_adi.Text = cmb_DP.Text.ToString();
                cumle.Select("Select*from Donanim_Paket where Dp_adi='" + lbl_DP_adi.Text + "'", "Donanim_Paket");
                dp_fiyati = Convert.ToDouble(cumle.ds.Tables["Donanim_Paket"].Rows[0]["Dp_fiyat"]);
                dp_kod = cumle.ds.Tables["Donanim_Paket"].Rows[0]["Dp_kodu"].ToString();
            }
            else { lbl_DP_adi.Text = "Paket Adı"; }
            
        }

        private void dtp_ModelTarih_ValueChanged(object sender, EventArgs e)
        {
            ekle_tarih = dtp_ModelTarih.Value.Date.Year + "-" + dtp_ModelTarih.Value.Date.Month + "-" + dtp_ModelTarih.Value.Date.Day;
        }

        private void btn_Bilgi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Giriş Biçimi: Model adı-Donanım Paketi");
        }

        private void txt_PaketsizFiyat_TextChanged(object sender, EventArgs e)
        {
            if (cmb_DP.SelectedIndex != -1 && txt_PaketsizFiyat.Text != "")
            {
                lbl_ModelFiyati.Visible = true;
                lbl_ModelFiyatGosterim.Visible = true;
                lbl_ModelFiyati.Text = Convert.ToDouble(Convert.ToDouble(txt_PaketsizFiyat.Text) + dp_fiyati).ToString();
            }
            else
            {
                lbl_ModelFiyatGosterim.Visible = false;
                lbl_ModelFiyati.Visible = false;

            }
        }

        private void txt_PaketsizFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (cmb_Seri.SelectedIndex != -1 && cmb_Sanziman.SelectedIndex != -1 && cmb_Motor.SelectedIndex != -1 && cmb_DP.SelectedIndex != -1 && txt_ModelAdi.Text != "" && txt_ModelKodu.Text != "" && txt_PaketsizFiyat.Text != "")
            {
                cumle.IDU("Insert into Arac_Model values('"+txt_ModelKodu.Text+"','"+txt_ModelAdi.Text.ToString()+"-"+lbl_DP_adi.Text.ToString()+"','"+seri_kod+"','"+motor_kod+"','"+dp_kod+"','"+sanziman_kod+"','"+ekle_tarih+"',"+Convert.ToDouble(lbl_ModelFiyati.Text)+")");
                MessageBox.Show("İşlem Başarılı");
                cmb_DP.SelectedIndex = -1;
                cmb_Motor.SelectedIndex = -1;
                cmb_Sanziman.SelectedIndex = -1;
                cmb_Seri.SelectedIndex = -1;
                txt_ModelAdi.Text = "";
                txt_ModelKodu.Text = "";
                txt_PaketsizFiyat.Text = "";
                
            }
            else { MessageBox.Show("Lütfen tüm alanları doldurun."); }
        }

        private void btn_Bilgi2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Giriş Biçimi: [STCGRHB][EOARPM][0-9][0-9]");
        }

        private void cmb_Seri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cumle.ds.Tables["Arac_Serisi"] != null)
            {
                cumle.ds.Tables["Arac_Serisi"].Clear();
            }
            if (cmb_Seri.SelectedIndex != -1)
            {
                cumle.Select("Select*from Arac_Serisi where Seri_adi='" + cmb_Seri.Text.ToString() + "'", "Arac_Serisi");
                seri_kod = cumle.ds.Tables["Arac_Serisi"].Rows[0]["Seri_kodu"].ToString();
            }
        }

        private void cmb_Motor_SelectedIndexChanged(object sender, EventArgs e)
        {
            motor_kod = cmb_Motor.Text.ToString();
        }

        private void cmb_Sanziman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cumle.ds.Tables["Arac_Sanziman"] != null)
            {
                cumle.ds.Tables["Arac_Sanziman"].Clear();
            }
            if (cmb_Sanziman.SelectedIndex!=-1)
            {
                cumle.Select("Select*from Arac_Sanziman where Sanziman_adi='" + cmb_Sanziman.Text.ToString() + "'", "Arac_Sanziman");
                sanziman_kod = cumle.ds.Tables["Arac_Sanziman"].Rows[0]["Sanziman_kodu"].ToString();
            }
        }

    }
}
