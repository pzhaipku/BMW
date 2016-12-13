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
    public partial class Giris : Form
    {
        SQL G_cumle = new SQL();
        AdminPanel admin = new AdminPanel();
        public Giris()
        {
            InitializeComponent();
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            G_cumle.Select("Select*from Kullanici where Kullanici_adi='"+txt_Kulad.Text.ToString()+"' AND Kullanici_sifre='"+txt_Sifre.Text.ToString()+"'","Kullanici");
            if (G_cumle.ds.Tables["Kullanici"].Rows.Count == 1)
            {
                admin.Tc_no = txt_Kulad.Text.ToString();
                admin.Show();
                this.Hide();
            }
            else { MessageBox.Show("Hatalı Giriş"); }
        }
    }
}
