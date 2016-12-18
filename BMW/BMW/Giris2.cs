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
    public partial class Giris2 : Form
    {
        public Giris2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Servis srvs = new Servis();
            srvs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arac_Satis arcsts = new Arac_Satis();
            arcsts.Show();
        }
    }
}
