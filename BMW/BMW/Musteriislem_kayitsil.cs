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
    public partial class Musteriislem_kayitsil : Form
    {
        SQL cumle = new SQL();
        public string tcno;


        public Musteriislem_kayitsil()
        {
            InitializeComponent();
        }

        private void Musteriislem_kayitsilara_Load(object sender, EventArgs e)
        {
            try
            {
                cumle.Select("Select * from Musteri", "Musterikayitsil");
                Musterigrid.DataSource = cumle.ds.Tables["Musterikayitsil"];
                // MessageBox.Show(cumle.ds.Tables["Musterikayitsil"].Columns["M_kodı"].ToString());


                sutunsec.Items.Add(cumle.ds.Tables["Musterikayitsil"].Columns["M_kodu"].ToString());
                sutunsec.Items.Add(cumle.ds.Tables["Musterikayitsil"].Columns["M_TCno"].ToString());
                sutunsec.SelectedIndex = 0;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
            

        }

        private void geridon_Click(object sender, EventArgs e)
        {
            try
            {
                MusteriHizmetleriPanel m = new MusteriHizmetleriPanel();
                this.Close();
                m.tcno = tcno;
                m.Show();
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
                if (sutunsec.SelectedItem.ToString() == "M_kodu")
                {
                    cumle.IDU("DELETE FROM Musteri WHERE M_kodu='" + Silinecekdeger.Text.ToString() + "'");

                }
                else if (sutunsec.SelectedItem.ToString() == "M_TCno")
                {
                    cumle.IDU("DELETE FROM Musteri WHERE M_TCno='" + Silinecekdeger.Text.ToString() + "'");

                }
                //   cumle.IDU("DELETE FROM Musteri WHERE M_kodu='" + Silinecekdeger.Text.ToString() + "'");
                cumle.ds.Tables["Musterikayitsil"].Clear();
                cumle.Select("SELECT * FROM Musteri", "Musterikayitsil");
                Musterigrid.DataSource = cumle.ds.Tables["Musterikayitsil"];
            }
            catch (Exception hata)
            {
                MessageBox.Show("Üzgünüz Beklenmedik Bİr Hata Ooluştu Lütfen Sistem Yöneticisine Başvurunuz. Hata " + hata.Message.ToString());
            }
           

        }



      
       
    }
}
