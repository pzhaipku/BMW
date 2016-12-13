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
    public partial class Musteriislem_kayitsilara : Form
    {
        SQL cumle = new SQL();
        public Musteriislem_kayitsilara()
        {
            InitializeComponent();
        }

        private void Musteriislem_kayitsilara_Load(object sender, EventArgs e)
        {
            cumle.Select("Select * from Musteri", "Musterikayitsil");
            Musterigrid.DataSource = cumle.ds.Tables["Musterikayitsil"];
           // MessageBox.Show(cumle.ds.Tables["Musterikayitsil"].Columns["M_kodı"].ToString());

            sutunsec.Items.Add(cumle.ds.Tables["Musterikayitsil"].Columns["M_kodu"].ToString());
            sutunsec.Items.Add(cumle.ds.Tables["Musterikayitsil"].Columns["M_TCno"].ToString());
        

        }

        private void geridon_Click(object sender, EventArgs e)
        {
            MusteriHizmetleriPanel m = new MusteriHizmetleriPanel();
            this.Close();
            m.Show();

        }
    }
}
