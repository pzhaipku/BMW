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
    public partial class Firmaislem_kayitsil : Form
    {
        SQL cumle = new SQL();

        public Firmaislem_kayitsil()
        {
            InitializeComponent();
        }

        private void geridon_Click(object sender, EventArgs e)
        {
            try
            {
                MusteriHizmetleriPanel m = new MusteriHizmetleriPanel();
                m.Show();
                this.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }

        }

        private void kayitsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (sutunsec.SelectedItem.ToString() == "Firma_kodu")
                {
                    cumle.IDU("DELETE FROM Firma_Musteri WHERE Firma_kodu='" + Silinecekdeger.Text.ToString() + "'");

                }

                //   cumle.IDU("DELETE FROM Musteri WHERE M_kodu='" + Silinecekdeger.Text.ToString() + "'");
                cumle.ds.Tables["firmakayitsil"].Clear();
                cumle.Select("SELECT * FROM Firma_Musteri", "firmakayitsil");
                Firmagrid.DataSource = cumle.ds.Tables["firmakayitsil"];
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            
            

        }
        

        private void Firmaislem_kayitsil_Load(object sender, EventArgs e)
        {
            try
            {
                cumle.Select("Select * from Firma_Musteri", "firmakayitsil");
                Firmagrid.DataSource = cumle.ds.Tables["firmakayitsil"];
                sutunsec.Items.Add(cumle.ds.Tables["firmakayitsil"].Columns["Firma_kodu"].ToString());
                sutunsec.SelectedIndex = 0;

            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            
           
        }
    }
}
